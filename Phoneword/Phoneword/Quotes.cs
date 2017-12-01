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
    public class Quotes : INotifyPropertyChanged
    {
        private int _currentQuoteIndex;
        public int CurrentQuoteIndex
        {
            get { return _currentQuoteIndex; }
            set
            {
                _currentQuoteIndex = value;
                CurrentQuote = QuoteList[CurrentQuoteIndex];
                OnPropertyChanged(nameof(CurrentQuoteIndex));
            }
        }
        public List<string> QuoteList { get; } = GenerateQuoteList();

        private string _currentQuote;
        public string CurrentQuote
        {
            get { return _currentQuote; }
            set
            {
                _currentQuote = value;
                OnPropertyChanged(nameof(CurrentQuote));
            }
        } 

        private static List<string> GenerateQuoteList()
        {
            return new List<string>()
            {
                "1. ‘To be, or not to be: that is the question’",
                "2. ‘All the world ‘s a stage, and all the men and women merely players. They have their exits and their entrances; And one man in his time plays many parts.’",
                "3. ‘Romeo, Romeo! wherefore art thou Romeo?’",
                "4. ‘Now is the winter of our discontent’",
                "5. ‘Is this a dagger which I see before me, the handle toward my hand?’",
                "6. ‘Some are born great, some achieve greatness, and some have greatness thrust upon them.’",
                "7. ‘Cowards die many times before their deaths; the valiant never taste of death but once.’",
                "8. ‘Full fathom five thy father lies, of his bones are coral made. Those are pearls that were his eyes. Nothing of him that doth fade, but doth suffer a sea-change into something rich and strange.’",
                "9. ‘A man can die but once.’",
                "10. ‘How sharper than a serpent’s tooth it is to have a thankless child!’",
                "11. ‘Frailty, thy name is woman.’",
                "12. ‘If you prick us, do we not bleed? If you tickle us, do we not laugh? If you poison us, do we not die? And if you wrong us, shall we not revenge?’",
                "13. ‘I am one who loved not wisely but too well.’"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
