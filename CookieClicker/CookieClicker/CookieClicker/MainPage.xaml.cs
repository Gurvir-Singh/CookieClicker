using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CookieClicker
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            PressCookie();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            PressCookie();
        }

        private async void PressCookie()
        {
            count++;
            switch (count % 4)
            {
                case 0:
                    MyLabel.Text = "Oh look I'm here now!";
                    break;
                case 1:
                    MyLabel.Text = "Now I'm over here!";
                    break;
                case 2:
                    MyLabel.Text = "And now I'm here!";
                    break;
                case 3:
                    MyLabel.Text = "Can you catch up to me?";
                    break;
                default:
                    MyLabel.Text = "Oh look I'm here now";
                    break;
            }
            var rand = new Random();
            await Cookie.TranslateTo(rand.Next(-200, 201), rand.Next(-200, 151), easing: Easing.Linear);
            //Cookie.TranslationX = Cookie.X + rand.Next(-75, 0);
            //Cookie.TranslationY = Cookie.Y + rand.Next(-75, 0);
            await Cookie.ScaleTo(1.2, 125U, Easing.CubicInOut);
            await Cookie.ScaleTo(1.0, 125U, Easing.CubicInOut);
        }
    }
}
