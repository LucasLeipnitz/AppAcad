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
        public ExercisePage2()
        {
            InitializeComponent();
        }

        public Exercise GetExercise(int index)
        {
            Exercise ex = new Exercise("Exercício", 0, 0, 0, 0);
            switch (index)
            {
                case 0:
                    ex = new Exercise(Ex1.Text, int.Parse(We1.Text), int.Parse(Se1.Text), int.Parse(Re1.Text), int.Parse(Re1.Text));
                    return ex;
                case 1:
                    ex = new Exercise(Ex2.Text, int.Parse(We2.Text), int.Parse(Se2.Text), int.Parse(Re2.Text), int.Parse(Re2.Text));
                    return ex;
                case 2:
                    ex = new Exercise(Ex3.Text, int.Parse(We3.Text), int.Parse(Se3.Text), int.Parse(Re3.Text), int.Parse(Re3.Text));
                    return ex;
                case 3:
                    ex = new Exercise(Ex4.Text, int.Parse(We4.Text), int.Parse(Se4.Text), int.Parse(Re4.Text), int.Parse(Re4.Text));
                    return ex;
                case 4:
                    ex = new Exercise(Ex5.Text, int.Parse(We5.Text), int.Parse(Se5.Text), int.Parse(Re5.Text), int.Parse(Re5.Text));
                    return ex;
                case 5:
                    ex = new Exercise(Ex6.Text, int.Parse(We6.Text), int.Parse(Se6.Text), int.Parse(Re6.Text), int.Parse(Re6.Text));
                    return ex;
                default:
                    return ex;
            }
        }
    }
}