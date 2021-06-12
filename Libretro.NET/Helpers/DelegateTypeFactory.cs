using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Libretro.NET
{
    /// <summary>
    /// Allows to generate a non-generic <see cref="Delegate"/> from a <see cref="MethodInfo"/>.
    /// </summary>
    public static class DelegateTypeFactory
    {
        private static readonly AssemblyBuilder _assembly = AssemblyBuilder.DefineDynamicAssembly(
            new AssemblyName("DelegateTypeFactory"),
            AssemblyBuilderAccess.RunAndCollect
        );

        private static readonly ModuleBuilder _module = _assembly.DefineDynamicModule("DelegateTypeFactory");

        private static readonly Dictionary<string, Type> _cache = new();


        /// <summary>
        /// Emit a non-generic <see cref="Delegate"/> from a <see cref="MehtodInfo"/>.
        /// Non-genericity is required when using native delegate bindings.
        /// Reworked from here: https://stackoverflow.com/a/9507589.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static Type ToDelegate(this MethodInfo method)
        {
            string name = string.Format("{0}{1}", method.DeclaringType.Name, method.Name);
            if (_cache.ContainsKey(name)) return _cache[name];

            var typeBuilder = _module.DefineType(
                name, TypeAttributes.Sealed | TypeAttributes.Public, typeof(MulticastDelegate));

            var constructor = typeBuilder.DefineConstructor(
                MethodAttributes.RTSpecialName | MethodAttributes.HideBySig | MethodAttributes.Public,
                CallingConventions.Standard, new[] { typeof(object), typeof(IntPtr) });
            constructor.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);

            var parameters = method.GetParameters();

            var invokeMethod = typeBuilder.DefineMethod(
                "Invoke", MethodAttributes.HideBySig | MethodAttributes.Virtual | MethodAttributes.Public,
                method.ReturnType, parameters.Select(p => p.ParameterType).ToArray());
            invokeMethod.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);

            for (int i = 0; i < parameters.Length; i++)
            {
                var parameter = parameters[i];
                invokeMethod.DefineParameter(i + 1, ParameterAttributes.None, parameter.Name);
            }

            return _cache[name] = typeBuilder.CreateTypeInfo();
        }
    }
}