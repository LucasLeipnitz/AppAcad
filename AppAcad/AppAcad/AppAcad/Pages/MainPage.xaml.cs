using AppAcad.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAcad
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private Control Control = new Control("Nome",0,0,0);
        private ExercisePage1 ExPage1 = new ExercisePage1();

        public MainPage()
        {
            InitializeComponent();
            InitializeDays();
            InitializeExercises();
            NextButton.Clicked += NextButton_Clicked;
            SaveButton.Clicked += SaveButton_Clicked;
            LoadButton.Clicked += LoadButton_Clicked;
        }

        private void InitializeDays()
        {
            //Dia1 e Dia2
            Control.User.NewDay();
            Control.User.NewDay();
        }

        private void InitializeExercises()
        {
            for(int i = 0; i < 6; i++)
            {
                Control.User.AddExercise(ExPage1.GetExercise(i), 0);
            }
        }

        private void LoadButton_Clicked(object sender, EventArgs e)
        {
            if (Control.CheckIfFileExists())
            {
                Control.LoadUser();
                NameEntry.Text = Control.User.Name;
                HeightEntry.Text = Control.User.Height.ToString();
                WeightEntry.Text = Control.User.Weight.ToString();
                WaistEntry.Text = Control.User.Waist.ToString();
                for (int i = 0; i < 6; i++)
                {
                    ExPage1.SetExercise(Control.User.GetDay(0).GetExercise(i),i);
                }
            }
            else
            {
                WarningLabel.IsVisible = true;
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Control.User.Name = NameEntry.Text;
            Control.User.Height = float.Parse(HeightEntry.Text);
            Control.User.Weight = float.Parse(WeightEntry.Text);
            Control.User.Waist = float.Parse(WaistEntry.Text);
            for (int i = 0; i < 6; i++)
            {
                Control.User.GetDay(0).SetExercise(ExPage1.GetExercise(i),i);
            }
            Control.SaveUser();
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(ExPage1);
        }
    }
}
