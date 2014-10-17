package com.telerik.iceplug;

import org.apache.cordova.CordovaPlugin;
import org.apache.cordova.CallbackContext;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * This class echoes a string called from JavaScript.
 */
public class TestPlugin extends CordovaPlugin {

    @Override
    public boolean execute(String action, JSONArray args, CallbackContext callbackContext) throws JSONException {
        if (action.equals("getPluginValue")) {
            this.getPluginValue(callbackContext);
            return true;
        }
        return false;
    }

    private void getPluginValue(CallbackContext callbackContext) throws JSONException {

        int appResId = cordova.getActivity().getResources().getIdentifier("plugin_variable", "string", cordova.getActivity().getPackageName());
        String pluginVariable = cordova.getActivity().getString(appResId);

        JSONObject data = new JSONObject();

        data.put("pluginVariable", pluginVariable);
        
        callbackContext.success(data);
    }
}
