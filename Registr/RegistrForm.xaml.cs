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

namespace Policlinic.Registr
{
    /// <summary>
    /// Логика взаимодействия для RegistrForm.xaml
    /// </summary>
    public partial class RegistrForm : Window
    {
        Polyclinicdb context = new Polyclinicdb();
        Patients patient = new Patients();
        public RegistrForm()
        {
            InitializeComponent();
            FloorBox.ItemsSource = context.Floor.Select(i => i.Floor1).ToList();

            FloorBox.SelectedItem = context.Floor.Where(i => i.Floor_id == patient.Floor_id).Select(i => i.Floor1).FirstOrDefault();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void RegistrBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Proverka.Check(NameTxt, LastnameTxt, PatronymicTxt, PolicyTxt, AddressText, PhoneTxt,
                PasswordTxt, LoginTxt))
            {
                return;
            }


            context.Patients.Add(new Patients
            {
                Name = NameTxt.Text,
                Lastname = LastnameTxt.Text,
                Patronymic = PatronymicTxt.Text,
                DateOfBirth = DateOfBirthTxt.SelectedDate,
                Policy = Int64.Parse(PolicyTxt.Text),
                Address = AddressText.Text,
                Phone = PhoneTxt.Text,
                Login = LoginTxt.Text,
                Password = PasswordTxt.Text,
                Floor_id = context.Floor.Where(i => i.Floor1 == FloorBox.SelectedItem.ToString())
                .Select(i => i.Floor_id).FirstOrDefault()
            });
            context.SaveChanges();
            MessageBox.Show($"Пользователь {NameTxt.Text} добавлени!");
            this.Close();
        }
    }
}
