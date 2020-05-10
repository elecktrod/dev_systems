using System;
using System.Drawing;

namespace ds.test.impl.FunctionPlugins
{
    internal class DivisionPlugin : BasePlagin, IPlugin
    {
        public string PluginName { get { return nameof(DivisionPlugin); } }

        public string Version { get { return "1.0.0.0"; } }

        public Image Image { get; }

        public string Description { get { return "Number division plugin."; } }

        public int Run(int input1, int input2)
        {
            try
            {
                return input1 / input2;
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        public DivisionPlugin()
        {
            Image = base.AddPlaginImage("DivisionPlugin_Image");
        }
    }
}
