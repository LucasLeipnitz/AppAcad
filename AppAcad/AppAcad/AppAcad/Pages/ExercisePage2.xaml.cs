using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAcad.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExercisePage2 : ContentPage
    {

        private bool warning = false;

        public ExercisePage2()
        {
            InitializeComponent();
        }

        public bool GetWarning()
        {
            return warning;
        }

        public void DeactivateWarning()
        {
            warning = false;
            //WarningLabel.IsVisible = false;
        }

        public Exercise GetExercise(int index)
        {
            switch (index)
            {
                case 0:
                    return ExerciseConstructor(Ex1.Text, We1.Text, Se1.Text, Re1.Text);
                case 1:
                    return ExerciseConstructor(Ex2.Text, We2.Text, Se2.Text, Re2.Text);
                case 2:
                    return ExerciseConstructor(Ex3.Text, We3.Text, Se3.Text, Re3.Text);
                case 3:
                    return ExerciseConstructor(Ex4.Text, We4.Text, Se4.Text, Re4.Text);
                case 4:
                    return ExerciseConstructor(Ex5.Text, We5.Text, Se5.Text, Re5.Text);
                case 5:
                    return ExerciseConstructor(Ex6.Text, We6.Text, Se6.Text, Re6.Text);
                default:
                    return new Exercise("Exercício", 0, 0, 0, 0);
            }
        }

        public void SetExercise(Exercise exercise, int index)
        {
            switch (index)
            {
                case 0:
                    Ex1.Text = exercise.Name;
                    We1.Text = exercise.Kg.ToString();
                    Se1.Text = exercise.Sets.ToString();
                    Re1.Text = exercise.MinRepeat.ToString();
                    break;
                case 1:
                    Ex2.Text = exercise.Name;
                    We2.Text = exercise.Kg.ToString();
                    Se2.Text = exercise.Sets.ToString();
                    Re2.Text = exercise.MinRepeat.ToString();
                    break;
                case 2:
                    Ex3.Text = exercise.Name;
                    We3.Text = exercise.Kg.ToString();
                    Se3.Text = exercise.Sets.ToString();
                    Re3.Text = exercise.MinRepeat.ToString();
                    break;
                case 3:
                    Ex4.Text = exercise.Name;
                    We4.Text = exercise.Kg.ToString();
                    Se4.Text = exercise.Sets.ToString();
                    Re4.Text = exercise.MinRepeat.ToString();
                    break;
                case 4:
                    Ex5.Text = exercise.Name;
                    We5.Text = exercise.Kg.ToString();
                    Se5.Text = exercise.Sets.ToString();
                    Re5.Text = exercise.MinRepeat.ToString();
                    break;
                case 5:
                    Ex6.Text = exercise.Name;
                    We6.Text = exercise.Kg.ToString();
                    Se6.Text = exercise.Sets.ToString();
                    Re6.Text = exercise.MinRepeat.ToString();
                    break;
                default:
                    break;
            }
        }

        private Exercise ExerciseConstructor(string name, string weight, string sets, string rep)
        {
            try
            {
                return new Exercise(name, int.Parse(weight), int.Parse(sets), int.Parse(rep), int.Parse(rep));
            }
            catch (FormatException)
            {
                warning = true;
                return new Exercise(name, 0, 0, 0, 0);
            }
        }
    }
}