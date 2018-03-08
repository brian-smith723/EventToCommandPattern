using System;
using System.Collections.Generic;
using  EventToCommandPattern.ViewModels;

using Xamarin.Forms;

namespace EventToCommandPattern.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            BindingContext = new MyPageViewModel();
        }
    }
}
