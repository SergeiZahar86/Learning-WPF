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

namespace Learning_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void page1_click(object sender, MouseButtonEventArgs e)
        {
            Page1 p = new Page1();
            MainFrame.Navigate(p);
        }
        private void page2_click(object sender, MouseButtonEventArgs e)
        {
            Page2 p = new Page2();
            MainFrame.Navigate(p);
        }
    }
}
