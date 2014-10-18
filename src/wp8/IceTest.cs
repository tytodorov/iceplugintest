using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using System.Collections.Generic;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using Windows.ApplicationModel;
using System.Xml.Linq;
using System.Linq;

namespace Cordova.Extension.Commands
{
    public class ICETEST : BaseCommand
    {
        public void getPluginValue(string empty)
        {
            string rawResult = "";
            XDocument document = XDocument.Load("config.xml");
            IEnumerable<XElement> eme = document.Descendants();
            var preferences = from preference in document.Descendants()
                              where preference.Name.LocalName == "preference" && (string)preference.Attribute("name") == "plugin_var"
                              select preference;

            foreach (var pref in preferences)
            {
                rawResult = pref.Value;
                
            }

        var result = String.Format("\"pluginVariable\":\"{0}\"",rawResult);
        DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "{" + result + "}"));
        }
    }
}