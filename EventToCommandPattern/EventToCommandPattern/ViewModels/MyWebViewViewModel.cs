using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EventToCommandPattern.ViewModels
{
    public class MyWebViewViewModel: BaseViewModel
    {
        private string _authUrl;



        public ICommand NavigateCommand => new Command(async (url) => await NavigateAsync(url));

        public MyWebViewViewModel()
        {
        }

        private async Task NavigateAsync(object url)
        {
            Console.WriteLine("URL:" + url.ToString());
            //stop activity indicator 
            // Now we can await if needed. 
            //Comment out is IsBusy to see the spinner. The page loads too fast to see the spinner. 
            await Task.Delay(500);
            Console.WriteLine("ISBUSY:" + IsBusy.ToString());
            IsBusy = false;

            Console.WriteLine("ISBUSY:" + IsBusy.ToString());

        }

        public string LoginUrl
        {
            get
            {
                return _authUrl;
            }
            set
            {
                _authUrl = value;
                OnPropertyChanged("LoginUrl");
            }
        }
        private bool busy = true;

        public bool IsBusy 
        {
            get
            {
                return busy;
            }
            set
            {
                busy= value;
                OnPropertyChanged("IsBusy");
            }
        }
    }

}
