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
        private List<Exercise> exerciseList = new List<Exercise>();

        public User(string name, float height, float weight, float waist)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Waist = waist;
        }

        public void NewExercise(string name, int kg, int sets, int minRepeat, int maxRepeat)
        {
            Exercise exercise = new Exercise(name, kg, sets, minRepeat, maxRepeat);
            exerciseList.Add(exercise);
        }

        public void DeleteExercise(int index)
        {
            exerciseList.RemoveAt(index);
        }

        public Exercise GetExercise(int index)
        {
            return exerciseList[index];
        }
    }
}
