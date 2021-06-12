using Libretro.NET.Bindings;
using Xunit;

namespace Libretro.NET.Tests
{
    public class RetroWrapperTests
    {
        private const string _corePath = "Resources/mgba_libretro.so";
        private const string _gamePath = "Resources/celeste_classic.gba";


        [Fact]
        public void Should_load_core_and_game()
        {
            var wrapper = new RetroWrapper();
            wrapper.LoadCore(_corePath);
            wrapper.LoadGame(_gamePath);

            Assert.Equal(240u, wrapper.Width);
            Assert.Equal(160u, wrapper.Height);
            Assert.Equal(59.727500915527344, wrapper.FPS);
            Assert.Equal(32768, wrapper.SampleRate);
            Assert.Equal(retro_pixel_format.RETRO_PIXEL_FORMAT_RGB565, wrapper.PixelFormat);
        }

        [Fact]
        public void Should_call_iteration_events()
        {
            var wrapper = new RetroWrapper();
            wrapper.LoadCore(_corePath);
            wrapper.LoadGame(_gamePath);
            wrapper.Run();

            bool sentFrame = false;
            wrapper.OnFrame = (_, _, _) => sentFrame = true;

            bool sentSample = false;
            wrapper.OnSample = (_) => sentSample = true;

            bool askedInput = false;
            wrapper.OnCheckInput = (_, _, _, _) => askedInput = true;

            wrapper.Run();

            Assert.True(sentFrame);
            Assert.True(sentSample);
            Assert.True(askedInput);
        }
    }
}
