using ds.test.impl.FunctionPlugins;
using System;

namespace ds.test.impl
{
    public static class Plugins
    {
        /// <summary>
        /// Number of plugins available.
        /// </summary>
        public static int PluginsCount { get { return GetPluginNames.Length; } }

        /// <summary>
        /// Array of names of available plugins.
        /// </summary>
        public static string[] GetPluginNames { get { return new []{ 
            nameof(AdditionPlagin), nameof(SubtractionPlagin), nameof(MultiplicationPlugin), nameof(DivisionPlugin)  };  } }

        /// <summary>
        /// Method returns a plugin by its name.
        /// </summary>
        public static IPlugin GetPlugin(string pluginName)
        {
            try
            {
                Type t = Type.GetType(typeof(BasePlagin).Namespace + "." + pluginName, true);
                return (IPlugin)Activator.CreateInstance(t);
            }
            catch
            {
                throw new ArgumentException("Plugin with this name not found.");
            }
        }
    }
}
