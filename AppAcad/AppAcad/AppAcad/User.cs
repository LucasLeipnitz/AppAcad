using System;
using System.Collections.Generic;
using System.Text;

namespace AppAcad
{
    [Serializable()]
    class User
    {
        public string Name { get; set; }
        public float Height { get;set; }
        public float Weight { get; set; }
        public float Waist { get; set; }

        public User(string name, float height, float weight, float waist)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Waist = waist;
        }
    }
}
