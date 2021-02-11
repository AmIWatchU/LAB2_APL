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

namespace _02._WpfExercise_v._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            // get the name of the drink
            string login = txtLog.Text;
            string password = txtPass.Password;
            if (login.Length <= 1)
            {
                MessageBox.Show("ENTER LOGIN!");
            }
            else if (password.Length <= 1)
            {
                MessageBox.Show("ENTER PASSWORD!");
            }
            else
            {
                if (login == "admin")
                {
                    if (password == "admin")
                    {
                        MessageBox.Show("Welcome back! ");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password! Try again! ", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Login! Try again! ", "Error");
                }
            }
        }
    }
}
