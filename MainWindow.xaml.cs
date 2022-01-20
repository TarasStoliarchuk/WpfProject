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

namespace WpfProject
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

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            string login = UserLogin.Text;
            string password = UserPassword.Password;
            string password_2 = UserPassword_2.Password;
            if(login.Length < 5)
            {
                UserLogin.ToolTip = "Short login";
                UserLogin.Background = Brushes.DarkRed;
            }
            else if (password.Length < 5)
            {
                UserLogin.ToolTip = "";
                UserLogin.Background = Brushes.Transparent;
                UserPassword.ToolTip = "Short password";
                UserPassword.Background = Brushes.DarkRed;
            }
            else if (password_2 != password)
            {
                UserLogin.ToolTip = "";
                UserLogin.Background = Brushes.Transparent;
                UserPassword.ToolTip = "";
                UserPassword.Background = Brushes.Transparent;
                UserPassword_2.ToolTip = "Passwords do not match";
                UserPassword_2.Background = Brushes.DarkRed;
            }
            else
            {
                UserLogin.ToolTip = "";
                UserLogin.Background = Brushes.Transparent;
                UserPassword.ToolTip = "";
                UserPassword.Background = Brushes.Transparent;
                UserPassword_2.ToolTip = "";
                UserPassword_2.Background = Brushes.Transparent;


                using (MyDbContext db = new MyDbContext())
                {
                    User ff = new User
                    {
                        dblogin = login,
                        dbpassword = password,
                    };
                    db.Users.Add(ff);
                    db.SaveChanges();
                }
                Log_in newWindow = new Log_in();
                newWindow.Show();
                Hide();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Log_in newWindow = new Log_in();
            newWindow.Show();
            Hide();
        }
    }
}
