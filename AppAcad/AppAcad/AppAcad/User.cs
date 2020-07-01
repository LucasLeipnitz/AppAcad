using System;
using System.Collections.Generic;
using System.Text;

namespace AppAcad
{
    class User
    {
        private string name;
        private float height;
        private float weight;
        private float waist;

        public User(string name, float height, float weight, float waist)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.waist = waist;
        }

        public string getName()
        {
            return name;
        }

        public float getHeight()
        {
            return height;
        }

        public float getWeight()
        {
            return weight;
        }

        public float getWaist()
        {
            return waist;
        }
    }
}
