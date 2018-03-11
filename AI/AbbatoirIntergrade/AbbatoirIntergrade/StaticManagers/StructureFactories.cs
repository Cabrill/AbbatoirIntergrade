using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Performance;
using FlatRedBall.Graphics;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class StructureFactories
    {
        private static IEnumerable<IEntityFactory> factoriesInThisAssembly;

        public static object GetNewObject(Type t)
        {
            try
            {
                return t.GetConstructor(new Type[] { })?.Invoke(new object[] { });
            }
            catch
            {
                return null;
            }
        }

        
        public static IEntityFactory GetFactory(string entityType)
        {
            if (factoriesInThisAssembly == null)
            {

#if WINDOWS_8 || UWP
                var assembly = typeof(TileEntityInstantiator).GetTypeInfo().Assembly;
                var typesInThisAssembly = assembly.DefinedTypes.Select(item=>item.AsType()).ToArray();

#else
                var assembly = Assembly.GetExecutingAssembly();
                var typesInThisAssembly = assembly.GetTypes();
#endif


#if WINDOWS_8 || UWP
                var filteredTypes = typesInThisAssembly.Where(t => t.GetInterfaces().Contains(typeof(IEntityFactory))
                            && t.GetConstructors().Any(c=>c.GetParameters().Count() == 0));
#else
                var filteredTypes = typesInThisAssembly.Where(t => t.GetInterfaces().Contains(typeof(IEntityFactory))
                                                                   && t.GetConstructor(Type.EmptyTypes) != null);
#endif

                factoriesInThisAssembly = filteredTypes
                    .Select(
                        t =>
                        {
#if WINDOWS_8 || UWP
                        var propertyInfo = t.GetProperty("Self");
#else
                            var propertyInfo = t.GetProperty("Self");
#endif
                            var value = propertyInfo.GetValue(null, null);
                            return value as IEntityFactory;
                        }).ToList();

            }

            var factory = factoriesInThisAssembly.FirstOrDefault(item =>
            {
                var type = item.GetType();
                var methodInfo = type.GetMethod("CreateNew", new[] { typeof(Layer), typeof(float), typeof(float) });
                var returntypeString = methodInfo.ReturnType.Name;

                return entityType == returntypeString || entityType.EndsWith("\\" + returntypeString);
            });
            return factory;
        }
    }
}
