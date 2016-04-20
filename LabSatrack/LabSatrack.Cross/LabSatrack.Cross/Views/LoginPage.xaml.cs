using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LabSatrack.Cross.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            btnIngresar.Clicked += BtnIngresar_Clicked;

        }

        async private void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Regard", "Hi everyone :) ", "Ok");
        }
    }
}
