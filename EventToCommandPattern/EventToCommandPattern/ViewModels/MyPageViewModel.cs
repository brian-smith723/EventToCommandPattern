using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using EventToCommandPattern.Views;

namespace EventToCommandPattern.ViewModels
{
    public class MyPageViewModel: BaseViewModel
    {
        public ICommand GoToPageCommand => new Command(async () => await (GoToWebViewAsync()));

        private async Task GoToWebViewAsync()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MyWebViewPage());
        }

        public MyPageViewModel()
        {
        }
    }
}
