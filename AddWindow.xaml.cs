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
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow newWindow = new ProfileWindow();
            newWindow.Show();
            Hide();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string nameprescription = NamePrescription1.Text;
            string ingridients =Ingridients1.Text;
            string textprescription = TextPrescription1.Text;
            int userrid = Convert.ToInt32(Userid.Text);
            User uuser = null;
            using (MyDbContext db = new MyDbContext())
            {
                uuser = db.Users.Where(b => b.id == userrid).FirstOrDefault();
                Prescription ff = new Prescription
                {
                    NamePrescription = nameprescription,
                    Ingridients = ingridients,
                    TextPrescription = textprescription,
                    User = uuser,
                };
                db.Recipes.Add(ff);
                db.SaveChanges();
                
            }
            ProfileWindow newWindow = new ProfileWindow();
            newWindow.Show();
            Hide();
        }
    }
}
