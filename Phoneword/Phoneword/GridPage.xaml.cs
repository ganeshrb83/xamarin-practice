using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
            this.BindingContext = new GridPageViewModel();
            var vm = ((GridPageViewModel)this.BindingContext);
            vm.DialedNumber = " ";
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var vm = ((GridPageViewModel) this.BindingContext);
            vm.DialedNumber += ((Button) sender).Text;
        }
    }
}