using System;
using EventToCommandPattern.Views;
using Xamarin.Forms;

namespace EventToCommandPattern
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //if (Device.RuntimePlatform == Device.iOS)
                //MainPage = new MyPage();
            //else
                MainPage = new NavigationPage(new MyPage());
        }
    }
}
