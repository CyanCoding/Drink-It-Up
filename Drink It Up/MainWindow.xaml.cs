using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drink_It_Up {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Application.Current.MainWindow.Width = 450;
            Application.Current.MainWindow.Height = 600;
            
        }

        /// <summary>
        /// Takes the user to the GitHub page on click
        /// </summary>
        private void GitHub_Link(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/CyanCoding/Drink-It-Up");
        }

        /// <summary>
        /// Takes the user to a help page on click
        /// </summary>
        private void HowTo_Link(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/CyanCoding/Drink-It-Up");
        }
    }
}
