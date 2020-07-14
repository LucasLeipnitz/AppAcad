using System;
using System.Collections.Generic;
using System.Text;

namespace AppAcad
{
    [Serializable()]
    public class Exercise
    {
        public string Name { get; set; }
        public int Kg { get; set; }
        public int Sets { get; set; }
        public int MinRepeat { get; set; }
        public int MaxRepeat { get; set; }

        public Exercise(string name, int kg, int sets, int minRepeat, int maxRepeat)
        {
            this.Name = name;
            this.Kg = kg;
            this.Sets = sets;
            this.MinRepeat = minRepeat;
            this.MaxRepeat = maxRepeat;
        }
    }
}
