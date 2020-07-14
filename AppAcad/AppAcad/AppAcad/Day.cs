using System;
using System.Collections.Generic;
using System.Text;

namespace AppAcad
{
    [Serializable()]
    class Day
    {
        private List<Exercise> exerciseList = new List<Exercise>();
        public void NewExercise(Exercise exercise)
        {
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

        public Exercise SetExercise(Exercise exercise, int index)
        {
            return exerciseList[index] = exercise;
        }
    }
}
