using FarmaciaApp.Views;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FarmaciaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Home_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}