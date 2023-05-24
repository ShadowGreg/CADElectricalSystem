using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp.ViewModelEntity {
    public class TextualHistory:INotifyPropertyChanged {
        public string Text { get; set; }

        public TextualHistory()
        {
            Text = "Начало нового сеанса работы.";
        }

        public string SetText(string text)
        {
            Text = text;
            OnPropertyChanged(nameof(Text));
            return Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}