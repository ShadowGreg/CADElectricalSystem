using System;
using WpfApp.ViewModelEntity;

namespace WpfApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public TextualHistory text;
        public MainWindow() {
            InitializeComponent();
            text = new TextualHistory();
            text.SetText(DoThomthing());
        }

        private string DoThomthing() {
            string output = "";
            for (int i = 0; i < 10; i++) {
                output += "новая операция \n";
            }
            return output;
        }
    }
}