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

        private void button3_page1_Click(object sender, RoutedEventArgs e)
        {
            
            var cmd = global.getCmd();
            cmd.CommandText = "create table user(id int, name text);";
              try{
                  cmd.ExecuteNonQuery();
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            /*
            cmd.CommandText = "insert into user values(1,'Jone')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "insert into user values(2,'Smitt')";
            cmd.ExecuteNonQuery();
            */

            cmd.CommandText = "select * from RegistrationUsers";
            var ret = cmd.ExecuteReader();
            textbox1.Text = "";
            while (ret.Read())
            {
                int id = ret.GetInt32(0);
                String name = ret.GetString(1);
                textbox1.Text = textbox1.Text + id + " " + name+"\n";
                      }

        }
    }
}
