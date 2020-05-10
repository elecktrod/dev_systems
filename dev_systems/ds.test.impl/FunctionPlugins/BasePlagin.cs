using System.Drawing;

namespace ds.test.impl.FunctionPlugins
{
    internal abstract class BasePlagin
    {
        public Image AddPlaginImage(string filename)
        {
            Image image;
            try
            {
                image = Image.FromFile(filename);
            }
            catch
            {
                image = null;
            }
            return image;
        }
    }
}
