using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using NativeLibraryLoader;

namespace Libretro.NET
{
    /// <summary>
    /// Generates a type from the provided interface to call native methods.
    /// Native calls are performed on-the-fly from the method name.
    /// </summary>
    public class NativeDispatchProxy : DispatchProxy
    {
        private static List<Delegate> _delegates = new();
        private NativeLibrary _library;
        private string _prefix;

        /// <summary>
        /// Dynamically call native method from its definition.
        /// Delegates are cached to avoid their garbage collection.
        /// </summary>
        /// <param name="targetMethod"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            _delegates.AddRange(args.OfType<Delegate>());

            var method = _library.GetType().GetMethods()
                .Where(x => x.Name == nameof(NativeLibrary.LoadFunction))
                .First(x => x.IsGenericMethod);

            var generic = method.MakeGenericMethod(targetMethod.ToDelegate());

            var load = (Delegate)generic.Invoke(_library, new[] { $"{_prefix}{targetMethod.Name}" });

            return load.DynamicInvoke(args);
        }

        /// <summary>
        /// Generates a <see cref="NativeDispatchProxy"/> from the provided interface type.
        /// Don't forget to call <see cref="Dispose{TInterface}(TInterface)"/> to properly release resources.
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <param name="path"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static TInterface Create<TInterface>(string path, string prefix)
        {
            var proxy = Create<TInterface, NativeDispatchProxy>();
            (proxy as NativeDispatchProxy)._library = new NativeLibrary(path);
            (proxy as NativeDispatchProxy)._prefix = prefix;
            return proxy;
        }

        /// <summary>
        /// Manually register a <see cref="Delegate"/> for use as native function callback.
        /// </summary>
        /// <typeparam name="TDelegate"></typeparam>
        /// <param name="del"></param>
        /// <returns></returns>
        public static IntPtr Register<TDelegate>(TDelegate del)
            where TDelegate : Delegate
        {
            _delegates.Add(del);
            return Marshal.GetFunctionPointerForDelegate(del);
        }

        /// <summary>
        /// Dispose a previously created native interface.
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <param name="obj"></param>
        public static void Dispose<TInterface>(TInterface obj)
        {
            (obj as NativeDispatchProxy)._library.Dispose();
        }
    }
}
