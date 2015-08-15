using Alchemy4Tridion.Plugins.GUI.Configuration;
using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;

namespace MyCleverPlugin.Assets
{
    public class MyResourceGroup : Alchemy4Tridion.Plugins.GUI.Configuration.ResourceGroup
    {
        public MyResourceGroup()
        {
            AddFile("GetSchemaName.js");
            AddFile<MyCommands>();
            Dependencies.AddAlchemyCore();
        }
    }
}
