using System.Windows;
using System.Windows.Controls;

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
