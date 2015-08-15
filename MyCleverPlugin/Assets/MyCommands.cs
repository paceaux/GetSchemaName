using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace MyCleverPlugin.Assets
{
    public class MyCommands : Alchemy4Tridion.Plugins.GUI.Configuration.CommandSet
    {
        public MyCommands()
        {
            AddCommand("GetSchemaName");
        }
    }
}
