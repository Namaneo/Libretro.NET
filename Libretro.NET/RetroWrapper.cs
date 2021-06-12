using System;
using System.IO;
using System.Runtime.InteropServices;
using Libretro.NET.Bindings;

namespace Libretro.NET
{
    /// <summary>
    /// Wraps all (most? (necessary?)) libretro mechanisms used to run a core and a game.
    /// After creation, <see cref="LoadCore(string)"/> and then <see cref="LoadGame(string)"/> must be called before anything else.
    /// </summary>
    public unsafe class RetroWrapper : IDisposable
    {
        private IRetro _interop;

        public uint Width { get; private set; }
        public uint Height { get; private set; }
        public double FPS { get; private set; }
        public double SampleRate { get; private set; }
        public retro_pixel_format PixelFormat { get; private set; }

        public delegate void OnFrameDelegate(byte[] frame, uint width, uint height);
        public OnFrameDelegate OnFrame { get; set; }

        public delegate void OnSampleDelegate(byte[] sample);
        public OnSampleDelegate OnSample { get; set; }

        public delegate bool OnCheckInputDelegate(uint port, uint device, uint index, uint id);
        public OnCheckInputDelegate OnCheckInput { get; set; }

        public void LoadCore(string corePath)
        {
            _interop = NativeDispatchProxy.Create<IRetro>(corePath, "retro_");

            _interop.set_environment(Environment);
            _interop.set_video_refresh(VideoRefresh);
            _interop.set_input_poll(InputPoll);
            _interop.set_input_state(InputState);
            _interop.set_audio_sample(AudioSample);
            _interop.set_audio_sample_batch(AudioSampleBatch);
            _interop.init();
        }

        public bool LoadGame(string gamePath)
        {
            var game = new retro_game_info
            {
                path = (sbyte*)Marshal.StringToHGlobalAuto(gamePath),
                size = (UIntPtr)new FileInfo(gamePath).Length
            };

            var system = new retro_system_info();
            _interop.get_system_info(ref system);

            if (!system.need_fullpath)
            {
                game.data = (void*)Marshal.AllocHGlobal((int)game.size);
                Marshal.Copy(File.ReadAllBytes(gamePath), 0, (IntPtr)game.data, (int)game.size);
            }

            var result = _interop.load_game(ref game);

            var av = new retro_system_av_info();
            _interop.get_system_av_info(ref av);

            Width = av.geometry.base_width;
            Height = av.geometry.base_height;
            FPS = av.timing.fps;
            SampleRate = av.timing.sample_rate;

            return result == 1;
        }

        public void Run()
        {
            _interop.run();
        }

        private bool Environment(uint cmd, void* data)
        {
            switch (cmd)
            {
                case RetroBindings.RETRO_ENVIRONMENT_GET_SYSTEM_DIRECTORY:
                    {
                        char** cb = (char**)data;
                        *cb = (char*)Marshal.StringToHGlobalAuto(".");
                        return true;
                    }
                case RetroBindings.RETRO_ENVIRONMENT_SET_PIXEL_FORMAT:
                    {
                        PixelFormat = (retro_pixel_format)(*(byte*)data);
                        return true;
                    }
                case RetroBindings.RETRO_ENVIRONMENT_GET_LOG_INTERFACE:
                    {
                        retro_log_callback* cb = (retro_log_callback*)data;
                        cb->log = NativeDispatchProxy.Register<retro_log_printf_t>(Log);
                        return true;
                    }
                case RetroBindings.RETRO_ENVIRONMENT_GET_CAN_DUPE:
                    {
                        return *(bool*)data = true;
                    }
                case RetroBindings.RETRO_ENVIRONMENT_SET_FRAME_TIME_CALLBACK:
                    {
                        retro_frame_time_callback* cb = (retro_frame_time_callback*)data;
                        cb->callback = NativeDispatchProxy.Register<retro_frame_time_callback_t>(Time);
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        private void VideoRefresh(void* data, uint width, uint height, UIntPtr pitch)
        {
            byte[] raw = new byte[(uint)pitch * height];
            Marshal.Copy((IntPtr)data, raw, 0, (int)pitch * (int)height);

            byte[] result = new byte[width * 2 * height];
            var destinationIndex = 0;
            for (var sourceIndex = 0; sourceIndex < (uint)pitch * height; sourceIndex += (int)pitch)
            {
                Array.Copy(raw, sourceIndex, result, destinationIndex, width * 2);
                destinationIndex += (int)width * 2;
            }

            OnFrame?.Invoke(result, width, height);
        }

        private void InputPoll()
        {
            //Am I supposed to do something?
        }

        private short InputState(uint port, uint device, uint index, uint id)
        {
            return OnCheckInput?.Invoke(port, device, index, id) ?? false ? (short)1 : (short)0;
        }

        private void AudioSample(short left, short right)
        {
            var count = 2;
            var audio = new byte[count * 2];
            var data = Marshal.AllocHGlobal(count * 2);

            Marshal.Copy(new[] { left, right }, 0, data, 0);
            Marshal.Copy(data, audio, 0, count * 2);

            OnSample?.Invoke(audio);
        }

        private UIntPtr AudioSampleBatch(short* data, UIntPtr frames)
        {
            var count = (int)frames * 2;
            var audio = new byte[count * 2];

            Marshal.Copy((IntPtr)data, audio, 0, count * 2);

            OnSample?.Invoke(audio);

            return frames;
        }

        private void Log(retro_log_level level, sbyte* fmt)
        {
            //Hard to log anything relevant without varargs support.
        }

        private void Time(long usec)
        {
            //Nothing relevant to do yet...
        }

        public void Dispose()
        {
            NativeDispatchProxy.Dispose(_interop);
        }
    }
}
