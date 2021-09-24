using System;
using System.IO;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace Libretro.NET.Generator
{
    public class LibretroLibrary : ILibrary
    {
        public override void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;
            options.Modules.Clear();
            var module = options.AddModule("Libretro");
            module.IncludeDirs.Add(".");
            module.Headers.Add("libretro.h");
        }

        public override void SetupPasses(Driver driver)
        {
        }

        public override void Preprocess(Driver driver, ASTContext ctx)
        {
        }

        public override void Postprocess(Driver driver, ASTContext ctx)
        {
        }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
            ConsoleDriver.Run(new LibretroLibrary());
        }
    }
}
