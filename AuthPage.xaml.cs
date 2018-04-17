using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
           
        }
        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            passwordEntry.IsPassword = !(switcher.IsToggled);
        }

        private void Reg_user(object sender, System.EventArgs e)
        {
            //await Navigation.PushAsync(new Registration());
        }

    }
}