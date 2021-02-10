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
            string password = txtPass.Text;
            if (login.Length <= 2)
            {
                MessageBox.Show("Введіть логін(більше 2 букв)");
            }
            else if (password.Length <= 2)
            {
                MessageBox.Show("Введіть пароль(більше 2 букв)");
            }
            else
            {
                if (login == "admin")
                {
                    if (password == "admin")
                    {
                        MessageBox.Show("Ви успішно увійшли");
                    }
                    else
                    {
                        MessageBox.Show("Неправильний пароль", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильний логін", "Error");
                }
            }

            MessageBox.Show("Welcome " + Login.ToUpper() + "  " + password.ToString() + " Password", "Order confirmation");
        }
    }
}
