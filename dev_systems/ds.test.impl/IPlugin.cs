namespace ds.test.impl
{
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        System.Drawing.Image Image { get; }
        string Description { get; }

        /// <summary>
        /// This method peforms plagin action.
        /// </summary>
        int Run(int input1, int input2);
    }

}
