
using System.Threading.Tasks;
using Xamarin.Forms;
using login2version2.ViewModel;

namespace login2version2
{
    public partial class MainPage : ContentPage
    {
        MainPageVM vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new MainPageVM();
            BindingContext = vm;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            loginbutton.IsEnabled = false;
        }
    }
}

