using System.Windows;
using System.Windows.Input;

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
        private void dialogWindow_click(object sender, RoutedEventArgs e)
        {
            DialogWindoW dialogWindoW = new DialogWindoW();
            dialogWindoW.ShowDialog();
        }
    }
}
