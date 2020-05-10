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
            switch (pluginName)
            {
                case nameof(AdditionPlagin):
                    return new AdditionPlagin();
                case nameof(SubtractionPlagin):
                    return new SubtractionPlagin();
                case nameof(MultiplicationPlugin):
                    return new MultiplicationPlugin();
                case nameof(DivisionPlugin):
                    return new DivisionPlugin();
                default:
                    throw new ArgumentException("Plugin with this name not found.");
            }
        }
    }
}
