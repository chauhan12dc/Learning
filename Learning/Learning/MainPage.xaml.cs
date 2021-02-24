using Learning.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learning
{
    public partial class MainPage : ContentPage
    {
        current c = new current();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = c;
            //Device.StartTimer(TimeSpan.FromSeconds(1), c.ct);
           
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            var page = new Page1();
            Navigation.PushAsync(new Page1());
            
        }
        bool cts()
        {
            //lbldate.Text = DateTime.Now.ToString("hh:mm:ss");
            return true;
        }
    }
}
