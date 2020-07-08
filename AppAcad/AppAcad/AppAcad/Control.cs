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
        private string FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "save.bin");

        public Control(string Name, float Height, float Weight, float Weist)
        {
            this.User = new User(Name, Height, Weight, Weist);
        }

        public bool CheckIfFileExists()
        {
            return File.Exists(FileName);
        }

        public void SaveUser()
        {
            Stream SaveFileStream = File.Create(this.FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, this.User);
            SaveFileStream.Close();
        }

        public void LoadUser()
        {
            Stream openFileStream = File.OpenRead(this.FileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            this.User = (User)deserializer.Deserialize(openFileStream);
            openFileStream.Close();
        }
    }
}
