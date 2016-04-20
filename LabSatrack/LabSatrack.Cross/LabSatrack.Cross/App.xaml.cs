using LabSatrack.Cross.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LabSatrack.Cross
{
    public partial class App : Application
    {
        public static MasterDetailPage masterDetailPage;
        public static NavigationPage navigationPage;

        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }

        public static void SetMasterPage() {


            masterDetailPage = new MasterDetailPage();
            var page = new TabPage();

            navigationPage = new NavigationPage(page)
            {
                BarBackgroundColor = (Color)App.Current.Resources["ThemeColor"],
                BarTextColor = (Color)App.Current.Resources["FontSecondaryColor"],
                
            };
            NavigationPage.SetBackButtonTitle(page, "Atrás");
            //NavigationPage.SetTitleIcon(page, "icon.png");

            masterDetailPage.Master = new MenuPage();
            masterDetailPage.Detail = navigationPage;
            App.Current.MainPage = masterDetailPage;

        }

        public void SetSettingPage() {
            var page = new MainPage();

            navigationPage = new NavigationPage(page)
            {
                BarBackgroundColor = Color.Red,
                BarTextColor = Color.Green,

            };
            NavigationPage.SetBackButtonTitle(page, "Atrás");
            //NavigationPage.SetTitleIcon(page, "icon.png");
            masterDetailPage.Detail = navigationPage;
        }


        protected override void OnStart()
        {
            // Handle when your app starts

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
