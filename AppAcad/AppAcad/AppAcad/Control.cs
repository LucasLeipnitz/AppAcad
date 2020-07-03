using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AppAcad
{
    class Control
    {
        public User User { get; set; }
        private const string FileName = "save.bin";

        public bool CheckIfFileExists()
        {
            return File.Exists(FileName);
        }

        public void SaveUser()
        {
            Stream SaveFileStream = File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, this.User);
            SaveFileStream.Close();
        }

        public void LoadUser()
        {
            Stream openFileStream = File.OpenRead(FileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            this.User = (User)deserializer.Deserialize(openFileStream);
            openFileStream.Close();
        }
    }
}
