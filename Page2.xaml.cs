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
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private Global global;
        public Page2()
        {
            InitializeComponent();
            global = Global.getInstance();
        }

        private void button1_page2_Click(object sender, RoutedEventArgs e)
        {
            global.Name = "Коля";

        }

        private void button2_page2_Click(object sender, RoutedEventArgs e)
        {
            label_page2.Content = global.Name;
        }
    }
}
