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
using System.Windows.Shapes;

namespace WpfProject
{
    public partial class Log_in : Window
    {
        public string log;
        public string pas;
        public Log_in()
        {
            InitializeComponent();
        }
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            string login = UserLogin1.Text;
            string password = UserPassword1.Password;
            if (login != null && password != null)
            {
                log = login;
                pas = password;
            }
            User uuser = null;
            using (MyDbContext db = new MyDbContext())
            {
                uuser = db.Users.Where(b => b.dblogin == login && b.dbpassword == password).FirstOrDefault();
            }
            if (uuser != null)
            {
                MessageBox.Show($"Your id - {uuser.id}");
                ProfileWindow newWindow = new ProfileWindow();
                newWindow.Show();
                Hide();
            }
            else
                MessageBox.Show("This user does not exist");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
            Hide();
        }
    }
}
