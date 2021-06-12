using System;

namespace Libretro.NET.Example
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using var game = new RetroGame(args[0], args[1]);

            game.Run();
        }
    }
}
