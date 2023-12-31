using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime;
using System.Xml;
using System.Xml.Serialization;

namespace SSMSConnect
{
    public struct ServerSettings
    {
        public string serverPath;
        public string serverDescription;
        public string userDomain;
        public bool serverIsEnabled;
    }

    [Serializable]
    public class Settings
    {
        public List<ServerSettings> servers;
        public bool connectAtStartup;

        public Settings()
        {
            servers = new List<ServerSettings>();
            connectAtStartup = true;
        }

        public void Load(ref Settings settings)
        {
            var serializer = new XmlSerializer(typeof(Settings));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SSMSConnect\\SSMSConnect.xml";
            if (File.Exists(path))
                using (var reader = XmlReader.Create(path))
                {
                    settings = (Settings)serializer.Deserialize(reader);
                }
        }

        public void Save()
        {
            var serializer = new XmlSerializer(typeof(Settings));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SSMSConnect";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            path = path + "\\SSMSConnect.xml";

            using (var writer = XmlWriter.Create(path))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
