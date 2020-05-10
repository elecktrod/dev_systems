using System.Drawing;

namespace ds.test.impl.FunctionPlugins
{
    internal class SubtractionPlagin : BasePlagin, IPlugin
    {
        public string PluginName { get { return nameof(SubtractionPlagin); } }

        public string Version { get { return "1.0.0.0"; } }

        public Image Image { get; }

        public string Description { get { return "Number subtraction plugin."; } }

        public int Run(int input1, int input2)
        {
            return input1 - input2;
        }

        public SubtractionPlagin()
        {
            Image = base.AddPlaginImage("SubtractionPlagin_Image");
        }
    }
}
