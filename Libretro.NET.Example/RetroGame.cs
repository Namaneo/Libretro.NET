using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Libretro.NET.Bindings;

namespace Libretro.NET
{
    public class RetroGame : Game
    {
        private RetroWrapper _retro;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private DynamicSoundEffectInstance _soundEffect;
        private Texture2D _currentTexture;
        private SurfaceFormat _pixelFormat;

        public RetroGame(string corePath, string gamePath)
        {
            _retro = new RetroWrapper();
            _retro.LoadCore(corePath);
            _retro.LoadGame(gamePath);

            _graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Window.AllowUserResizing = true;

            _graphics.PreferredBackBufferWidth = (int)_retro.Width * 4;
            _graphics.PreferredBackBufferHeight = (int)_retro.Height * 4;
            _graphics.ApplyChanges();

            _pixelFormat = _retro.PixelFormat switch
            {
                retro_pixel_format.RETRO_PIXEL_FORMAT_RGB565 => SurfaceFormat.Bgr565,
                retro_pixel_format.RETRO_PIXEL_FORMAT_0RGB1555 => SurfaceFormat.Bgra5551,
                retro_pixel_format.RETRO_PIXEL_FORMAT_XRGB8888 => SurfaceFormat.Bgra32,
                retro_pixel_format.RETRO_PIXEL_FORMAT_UNKNOWN => SurfaceFormat.Bgr565,
                _ => SurfaceFormat.Bgr565,
            };

            _soundEffect = new DynamicSoundEffectInstance((int)_retro.SampleRate, AudioChannels.Stereo);
            _soundEffect.Play();

            _retro.OnFrame = OnFrame;
            _retro.OnSample = OnSample;
            _retro.OnCheckInput = OnCheckInput;

            base.Initialize();
        }

        private void OnFrame(byte[] frame, uint width, uint height)
        {
            if (_currentTexture != null) _currentTexture.Dispose();

            _currentTexture = new Texture2D(GraphicsDevice, (int)_retro.Width, (int)_retro.Height, false, _pixelFormat);
            _currentTexture.SetData(frame);
        }

        private void OnSample(byte[] sample)
        {
            _soundEffect.SubmitBuffer(sample);
        }

        private bool OnCheckInput(uint port, uint device, uint index, uint id)
        {
            KeyboardState state = Keyboard.GetState();

            return id switch
            {
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_A => state.IsKeyDown(Keys.X),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_B => state.IsKeyDown(Keys.C),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_L => state.IsKeyDown(Keys.A),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_R => state.IsKeyDown(Keys.Z),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_UP => state.IsKeyDown(Keys.Up),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_DOWN => state.IsKeyDown(Keys.Down),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_LEFT => state.IsKeyDown(Keys.Left),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_RIGHT => state.IsKeyDown(Keys.Right),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_START => state.IsKeyDown(Keys.Enter),
                RetroBindings.RETRO_DEVICE_ID_JOYPAD_SELECT => state.IsKeyDown(Keys.RightShift),
                _ => false
            };
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            _retro.Run();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);

            var texture = _currentTexture;

            var widthRatio = (double)Window.ClientBounds.Width / texture.Width;
            var heightRatio = (double)Window.ClientBounds.Height / texture.Height;

            var width = (widthRatio < heightRatio ? widthRatio : heightRatio) * texture.Width;
            var height = (widthRatio < heightRatio ? widthRatio : heightRatio) * texture.Height;

            var posX = (Window.ClientBounds.Width - width) / 2;
            var posY = (Window.ClientBounds.Height - height) / 2;

            _spriteBatch.Begin();
            _spriteBatch.Draw(texture, new Rectangle((int)posX, (int)posY, (int)width, (int)height), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _retro.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
