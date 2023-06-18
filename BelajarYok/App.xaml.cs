using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BelajarYok
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Color WarnaItemGajelas = Color.FromHex("#2b2c30");

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = WarnaItemGajelas,
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
