var exec = require('cordova/exec');
var channel = require('cordova/channel');

var utils = require('cordova/utils');

channel.onCordovaReady.subscribe(function() {
	exec(function(plugin){
		console.log("Value of the plugin variable is: " + plugin.pluginVariable.toString());
		if (plugin.pluginVariable.toString().indexOf("AUTOMATION") == -1){
		utils.alert(plugin.pluginVariable.toString());
		}
	}, function(e) {
		utils.alert("[ERROR] Error initializing Cordova: " + e);
    }, "ICETEST", "getPluginValue", []);
});

