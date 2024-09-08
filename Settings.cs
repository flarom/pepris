using System.Xml.Linq;

namespace Pepris {
    internal class Settings {
        public string[] validBackgroundExtensions = { ".bmp", ".gif", ".jpeg", ".jpg", ".png", ".tiff", ".tif", ".wmf", ".emf" };
        static string defaultDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        static string settingsFilePath = Path.Combine(defaultDirectory, "settings.xml");

        public void SaveSetting(string key, string value) {
            try {
                XDocument doc = LoadOrCreateSettingsFile();
                XElement root = doc.Element("Settings");

                XElement settingElement = root.Element(key);
                if (settingElement != null) {
                    settingElement.Value = value;
                }
                else {
                    root.Add(new XElement(key, value));
                }

                doc.Save(settingsFilePath);
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to save setting: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveSetting(string key, string[] values) {
            try {
                XDocument doc = LoadOrCreateSettingsFile();
                XElement root = doc.Element("Settings");

                XElement settingElement = root.Element(key);
                if (settingElement != null) {
                    settingElement.RemoveAll();
                    foreach (var value in values) {
                        settingElement.Add(new XElement("Item", value));
                    }
                }
                else {
                    XElement newElement = new XElement(key);
                    foreach (var value in values) {
                        newElement.Add(new XElement("Item", value));
                    }
                    root.Add(newElement);
                }

                doc.Save(settingsFilePath);
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to save setting: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetSettingString(string key) {
            try {
                XDocument doc = LoadOrCreateSettingsFile();
                XElement settingElement = doc.Element("Settings").Element(key);
                return settingElement != null ? settingElement.Value : "false";
            }
            catch {
                return "false";
            }
        }

        public string[] GetSettingStringArray(string key) {
            try {
                XDocument doc = LoadOrCreateSettingsFile();
                XElement settingElement = doc.Element("Settings").Element(key);
                return settingElement != null ? settingElement.Elements("Item").Select(e => e.Value).ToArray() : new string[0];
            }
            catch {
                return new string[0];
            }
        }

        public bool GetSettingBool(string key) {
            try {
                return bool.Parse(GetSettingString(key));
            }
            catch {
                return false;
            }
        }

        public int GetSettingInt(string key) {
            try {
                return int.Parse(GetSettingString(key));
            }
            catch {
                return 0;
            }
        }

        public double GetSettingDouble(string key) {
            try {
                return double.Parse(GetSettingString(key));
            }
            catch {
                return 0;
            }
        }

        public ConsoleKey GetSettingKey(string key) {
            try {
                string keyString = GetSettingString(key);
                return (ConsoleKey)Enum.Parse(typeof(ConsoleKey), keyString, true);
            }
            catch {
                return ConsoleKey.NoName;
            }
        }

        public Keys ParseKey(string key) {
            try {
                return (Keys)Enum.Parse(typeof(Keys), key, true);
            }
            catch (ArgumentException) {
                throw new ArgumentException($"The key '{key}' is not valid.");
            }
        }

        private XDocument LoadOrCreateSettingsFile() {
            if (File.Exists(settingsFilePath)) {
                return XDocument.Load(settingsFilePath);
            }
            else {
                XDocument doc = new XDocument(new XElement("Settings"));
                doc.Save(settingsFilePath);
                return doc;
            }
        }
    }
}
