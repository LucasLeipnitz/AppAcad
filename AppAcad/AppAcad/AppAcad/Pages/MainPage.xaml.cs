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
            }
            else
            {
                WarningLabel.IsVisible = true;
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Control.User.Name = NameEntry.Text;
            Control.SaveUser();
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExercisePage());
        }
    }
}
