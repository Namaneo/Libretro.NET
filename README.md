# Libretro.NET

Libretro.NET provides native bindings to the famous [`libretro.h`](https://github.com/libretro/RetroArch/blob/master/libretro-common/include/libretro.h) header. Targeting .NET Standard 2.0, it allows to quickly setup a Libretro emulator for a wide range of platforms.

This project is at its early days: only basic features and non-OpenGL cores are supported. That said, if you come by and want to contribute, don't hesitate suggest/implement improvements or report issues!

# Installation

This library is available as a [NuGet package](https://www.nuget.org/packages/Libretro.NET/) and can be installed using the dotnet CLI:

```bash
dotnet add package Libretro.NET
```

# Sample usage

```csharp
// Create a new wrapper
var retro = new RetroWrapper();

// Load the core and the game
retro.LoadCore("core/path/here");
retro.LoadGame("game/path/here");

// The wrapper exposes some specifications
var width = retro.Width;
var height = retro.Height;
var fps = retro.FPS;
var sampleRate = retro.SampleRate;
var pixelFormat = retro.PixelFormat;

// Register emulation events
retro.OnFrame = (frame, width, height) =>
{
    // Display or store the frame here
};
retro.OnSample = (sample) =>
{
    // Play or store the audio sample here
};
retro.OnCheckInput = (port, device, index, id) =>
{
    // Check if a key is pressed here
};

// Run a game iteration (one iteration = one frame)
retro.Run();

// Dispose wrapper when done
retro.Dispose();
```

# Example project

The first parameter is the path to the core, and the second parameter is the path to the game.

For users on Linux x86_64, you can quickly test it as follows:

```
dotnet run --project Libretro.NET.Example/ -- \
    Libretro.NET.Tests/Resources/mgba_libretro.so \
    Libretro.NET.Tests/Resources/celeste_classic.gba
```

For users on other platforms, just replace the mGBA core with the correct one from the [buildbot](https://buildbot.libretro.com/) of Libretro.

# References

* The [MonoGame](https://www.monogame.net/) framework is used for the example project.
* The [ClangSharp](https://github.com/microsoft/ClangSharp) library was used to generate the initial `libretro.h` bindings.
* The [NativeLibraryLoader](https://www.nuget.org/packages/NativeLibraryLoader) is used for the native interopability mechanisms.
* The [mGBA core](https://github.com/libretro/mgba) and [Celeste Classic](https://github.com/JeffRuLz/Celeste-Classic-GBA) are used for unit testing.
* ... Do I really have to talk about the fantastic [Libretro](https://www.libretro.com/) initiative and the inspiration that represents its famous [RetroArch](https://github.com/libretro/RetroArch) front-end? 
