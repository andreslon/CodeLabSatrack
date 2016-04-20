using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LabSatrack.Cross.Views
{
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();


            this.Title = "TabbedPage";

            this.Children.Add(new ContentPage
            {
                Title = "Ubicaciones",
                BackgroundColor = (Color)App.Current.Resources["BackgroundColor"],
                Content = new Label
                {
                    Text = "Ubicaciones"
                },
            });
            this.Children.Add(new ContentPage
            {
                Title = "Alarmas",
                BackgroundColor = (Color)App.Current.Resources["BackgroundColor"],
                Content = new Label
                {
                    Text = "Alarmas"
                },
            });
            this.Children.Add(new ContentPage
            {
                Title = "Noticias",
                BackgroundColor = (Color)App.Current.Resources["BackgroundColor"],
                Content = new Label
                {
                    Text = "Noticias"
                },
            });

        }
    }
}
