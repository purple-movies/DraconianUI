using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DraconianMarshmallows.UI.Localization
{
    public class Localizer
    {
        public static Localizer GetInstance(string defaultStringsPath, string localizedStringsPath)
        {
            Localizer localizer;
            string key = getKey(defaultStringsPath, localizedStringsPath);

            if ( ! instanceMap.ContainsKey(key))
            {
                instanceMap.Add(key, localizer = new Localizer(defaultStringsPath, localizedStringsPath));
                return localizer;
            }
            else if (instanceMap.TryGetValue(key, out localizer))
                return localizer;

            Debug.LogErrorFormat("Couldn't get Localizer: %s", key); 
            return null; 
        }

        public static Dictionary<string, Localizer> instanceMap 
            = new Dictionary<string, Localizer>();

        // TODO: add event callbacks for changing localization. 

        private Dictionary<string, string> defaultStrings = new Dictionary<string, string>();
        private Dictionary<string, string> localizedStrings = new Dictionary<string, string>();

        private Localizer(string defaultStringsPath, string localizedStringsPath)
        {
            defaultStrings = loadStrings(defaultStringsPath);
            localizedStrings = loadStrings(localizedStringsPath);
        }

        public string GetLocalized(string key)
        {
            string value;
            if (localizedStrings.TryGetValue(key, out value))
                return value;

            Debug.LogWarningFormat("Failed to find localized: %s", key); 
            if (defaultStrings.TryGetValue(key, out value))
                return value; // Fallback to default strings. 

            Debug.LogWarningFormat("Failed to find default string: %s", key); 
            return key; // Finally fallback to key so you can see it failed. 
        }

        private Dictionary<string, string> loadStrings(string jsonFilePath)
        {
            var jsonText = Resources.Load<TextAsset>(jsonFilePath);
            var data = JsonConvert.DeserializeObject<LocalizationData>(jsonText.text);
            return data.translation;
        }

        private static string getKey(string defaultPath, string desiredPath)
        {
            return defaultPath + "::" + desiredPath;
        }
    }
}
