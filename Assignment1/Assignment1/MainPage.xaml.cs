using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Assignment1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new
            {
                Image = "img3.png"
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var docs1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename1 = Path.Combine(docs1, "email.txt");
            var text1 = File.ReadAllText(filename1);

            var docs2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename2 = Path.Combine(docs2, "password.txt");
            var text2 = File.ReadAllText(filename2);

            string[] emails = text1.Split(' ');
            string[] passwords = text2.Split(' ');



            var email = EmailEntry.Text;
            var pswrd = pswrdEntry.Text;

            if(emails.Contains(email) & passwords.Contains(pswrd))
            {
                DisplayAlert("Success", "You shall pass", "OK");
                Navigation.PushModalAsync(new TabbedPage1());
            }
            else
            {
                DisplayAlert("Failed", "No accounts yet? Sign up below!", "OK");
            }




           /* var pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(email,pattern )& pswrd !=null)
            {
               DisplayAlert("Success!", "You shall pass", "OK");
               Navigation.PushModalAsync(new TabbedPage1());
                
            }else  {DisplayAlert("Sorry!", "Username doesn't match", "OK");}*/


            
        }
        void ForgotPassword(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
