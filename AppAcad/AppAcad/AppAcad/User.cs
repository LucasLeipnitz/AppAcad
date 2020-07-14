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
        private List<Day> dayList = new List<Day>();

        public User(string name, float height, float weight, float waist)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Waist = waist;
        }

        public void NewDay()
        {
            Day day = new Day();
            dayList.Add(day);
        }

        public void DeleteDay(int index)
        {
            dayList.RemoveAt(index);
        }

        public Day GetDay(int index)
        {
            return dayList[index];
        }

        public void AddExercise(Exercise exercise, int index)
        {
            dayList[index].NewExercise(exercise);   
        }
    }
}
