using System.Drawing;

namespace ds.test.impl.FunctionPlugins
{
    internal class AdditionPlagin : BasePlagin, IPlugin
    {
        public string PluginName { get{ return nameof(AdditionPlagin); } }

        public string Version { get { return "1.0.0.0"; } }

        public Image Image { get; }

        public string Description { get { return "Number addition plugin."; } }

        public int Run(int input1, int input2)
        {
            return input1 + input2;
        }

        public AdditionPlagin()
        {
            Image = base.AddPlaginImage("AdditionPlagin_Image");
        }
    }
}
