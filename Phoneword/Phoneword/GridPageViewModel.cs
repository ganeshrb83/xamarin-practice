using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Phoneword.Annotations;

namespace Phoneword
{
    public class GridPageViewModel: INotifyPropertyChanged
    {
        private string _dialedNumber;

        public string DialedNumber
        {
            get { return _dialedNumber; }
            set
            {
                _dialedNumber = value; 
                OnPropertyChanged(nameof(DialedNumber));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
