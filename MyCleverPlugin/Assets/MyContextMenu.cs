using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace MyCleverPlugin.Assets
{
    public class MyContextMenu : Alchemy4Tridion.Plugins.GUI.Configuration.ContextMenuExtension
    {
        public MyContextMenu()
        {
            // Use this property to specify where in the context menu your items will go
            AssignId = "MyContextMenuId";
            InsertBefore = "cm_refresh";
            Name = "CleverContextMenu";
            AddItem("cm_my_context", "Schema Name", "GetSchemaName");

            // Use AddItem() or AddSubMenu() to add items for this context menu

            // Add a dependency to the resource group that contains the files/commands that this toolbar extension will use.
            Dependencies.Add<MyResourceGroup>();

            // apply the extension to a specific view.
            
            Apply.ToView(Constants.Views.DashboardView);
        }
    }
}
