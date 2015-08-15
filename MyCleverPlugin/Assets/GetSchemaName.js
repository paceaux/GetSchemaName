Type.registerNamespace("Alchemy.Plugins.MyCleverPlugin.Commands");

// Constructor
Alchemy.Plugins["MyCleverPlugin"].Commands.GetSchemaName = function () {
    Type.enableInterface(this, "Alchemy.Plugins.MyCleverPlugin.Commands.GetSchemaName");

    // ATTENTION: Modify "YourCommandName" to the name of your actual command
    this.addInterface("Tridion.Cme.Command", ["GetSchemaName"]);
};

// Command Prototype Members
Alchemy.Plugins["MyCleverPlugin"].Commands.GetSchemaName.prototype = {

    /**
     * Whether or not the item the command is attached to is available.
     */
    isAvailable: function (selection) {
        return true;
    },

    /**
     * Whether or not the item the command is attached to is enabled (if available and not enabled, will show as disabled state).
     */
    isEnabled: function (selection) {
        return true;
    },

    /**
     * The action that is performed when someone clicks on the item the command is attached to.
     */
    _execute: function (selection) {
        var item = $models.getItem(selection.getItem(0)),
            schema = item.getSchema(),
            schemaInfo = schema.getInfo(),
            TridionWindow;
        console.log(schemaInfo);
        for (var i = 0; i < frames.length; i++) {
            if (frames[i].$messages) TridionWindow = frames[i];
        }
        function schemaLoaded() {
            $messages.registerGoal("Schema Name:  " + schema.getTitle() );

        }
        $evt.addEventHandler(item, 'load', function (e) {

        });
        $evt.addEventHandler(schema, "load", schemaLoaded);
        item.load(true);
        schema.load(true);
        
    }
};