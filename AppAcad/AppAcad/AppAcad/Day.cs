using System;
using System.Collections.Generic;
using System.Text;

namespace AppAcad
{
    class Day
    {
        private List<Exercise> exerciseList = new List<Exercise>();
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
