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
    public partial class QuotesPage : ContentPage
    {
        
        public QuotesPage()
        {
            InitializeComponent();
            this.BindingContext = new Quotes();
            var vm = ((Quotes)this.BindingContext);
            vm.CurrentQuoteIndex = 0;
        }

        private void BtnNext_OnClicked(object sender, EventArgs e)
        {
            var vm = ((Quotes) this.BindingContext);
            if (vm.CurrentQuoteIndex + 1 == vm.QuoteList.Count)
            {
                vm.CurrentQuoteIndex = 0;
            }
            else
            {
                vm.CurrentQuoteIndex++;
            }
                
        }
    }
}