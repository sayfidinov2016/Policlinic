using Policlinic.Administrator.AdminClass;
using Policlinic.AdminPage.AddClass;
using Policlinic.Registr;
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

namespace Policlinic.AdminPage.AcauntPatient
{
    /// <summary>
    /// Логика взаимодействия для ChangePatientPage.xaml
    /// </summary>
    public partial class ChangePatientPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public ChangePatientPage()
        {
            
            InitializeComponent();
            var qwery = context.Patients.Where(i => i.Patient_id == IDAdminClasss.IDClass).FirstOrDefault();

            NameTxt.Text = qwery.Name;
            LastnameTxt.Text = qwery.Lastname;
            PatronymicTxt.Text = qwery.Patronymic;
            DateOfBirthTxt.SelectedDate = qwery.DateOfBirth;
            PolicyTxt.Text = qwery.Policy.ToString();
            AddressText.Text = qwery.Address;
            PhoneTxt.Text = qwery.Phone;
            LoginTxt.Text = qwery.Login;
            PasswordTxt.Text = qwery.Password;
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Proverka.Check(NameTxt, LastnameTxt, PatronymicTxt, PolicyTxt, AddressText, PhoneTxt, PasswordTxt, LoginTxt))
            {
                return;
            }

            var result = MessageBox.Show("Изменить данные?", "Изменние данных пациента", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var patient = context.Patients.Where(i => i.Patient_id == IDAdminClasss.IDClass).FirstOrDefault();
                patient.Name = NameTxt.Text;
                patient.Lastname = LastnameTxt.Text;
                patient.Patronymic = PatronymicTxt.Text;
                patient.DateOfBirth = DateOfBirthTxt.SelectedDate;
                patient.Policy = Int64.Parse(PolicyTxt.Text);
                patient.Address = AddressText.Text;
                patient.Phone = PhoneTxt.Text;
                patient.Login = LoginTxt.Text;
                patient.Password = PasswordTxt.Text;
                context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!");
                MenuFrameClass.AdminFrame.GoBack();
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }
    }
}
