using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using SQLitePCL;

namespace Assignment1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {

        public RegisterPage()
        {
            InitializeComponent();
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var email = RegEmailEntry.Text;
            var pswrd = RegPswrd.Text;

            var docs1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename1 = Path.Combine(docs1, "email.txt");
            File.WriteAllText(filename1, email);

            var docs2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename2 = Path.Combine(docs2, "password.txt");
            File.WriteAllText(filename2, pswrd);

            Navigation.PushModalAsync(new MainPage());
        }
    }
}