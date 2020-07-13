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

        public MainPage()
        {
            InitializeComponent();
            NextButton.Clicked += NextButton_Clicked;
            SaveButton.Clicked += SaveButton_Clicked;
            LoadButton.Clicked += LoadButton_Clicked;
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
            Control.SaveUser();
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExercisePage1());
        }
    }
}
