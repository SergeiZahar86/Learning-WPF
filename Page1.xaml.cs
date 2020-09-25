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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private Global global;
        public Page1()
        {
            InitializeComponent();
            global = Global.getInstance();
        }

        private void button1_page1_Click(object sender, RoutedEventArgs e)
        {
            global.Name = "Ренат";
        }

        private void button2_page1_Click(object sender, RoutedEventArgs e)
        {
            label_page1.Content = global.Name;
        }
    }
}
