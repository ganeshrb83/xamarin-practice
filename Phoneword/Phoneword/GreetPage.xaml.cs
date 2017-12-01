using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            //switch (Device.RuntimePlatform)
            //{
            //    case Device.Android:
            //        Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case Device.iOS:
            //        Padding = new Thickness(10, 20, 0, 0);
            //        break;
            //}
        }
        
    }
}