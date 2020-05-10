using System.Drawing;

namespace ds.test.impl.FunctionPlugins
{
    internal class MultiplicationPlugin : BasePlagin, IPlugin
    {
        public string PluginName { get { return nameof(MultiplicationPlugin); } }

        public string Version { get { return "1.0.0.0"; } }

        public Image Image { get; }

        public string Description { get { return "Number multiplication plugin."; } }

        public int Run(int input1, int input2)
        {
            return input1 * input2;
        }

        public MultiplicationPlugin()
        {
            Image = base.AddPlaginImage("MultiplicationPlugin_Image");
        }
    }
}
