using Policlinic.Administrator.AdminClass;
using Policlinic.AdminPage.AddClass;
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

namespace Policlinic.AdminPage.AcauntDoctor
{
    /// <summary>
    /// Логика взаимодействия для ChangeDoctorPage.xaml
    /// </summary>
    public partial class ChangeDoctorPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        Doctors doctors = new Doctors();
        public string pasport;
        public string seria;
        public string nomer;
        public ChangeDoctorPage()
        {
            InitializeComponent();
            DoctorBox.ItemsSource = context.Specialty.Select(i => i.Specialty1).ToList();
            DoctorBox.SelectedItem = context.Specialty.Where(i => i.Specialty_id == doctors.Specialty_id).Select(i => i.Specialty1).FirstOrDefault();
            FilialBox.ItemsSource = context.Polyclinic.Select(i => i.Name).ToList();
            FilialBox.SelectedItem = context.Polyclinic.Where(i => i.Polyclinic_id == doctors.Polyclinic_id).Select(i => i.Name).FirstOrDefault();

            var qwery = context.Doctors.Where(i => i.Doctor_id == IDAdminClasss.IDClass).FirstOrDefault();

            NameTxt.Text = qwery.Name;
            LastnameTxt.Text = qwery.Lastname;
            PatronymicTxt.Text = qwery.Patronymic;
            DoctorBox.Text = qwery.Specialty.Specialty1;
            CabinetText.Text = qwery.Cabinet.ToString();

            pasport = qwery.Passport;
            seria = pasport.Substring(0, pasport.Length - 7);
            nomer = pasport.Substring(5);

            SeriaText.Text = seria;
            NomerText.Text = nomer;
            AddressText.Text = qwery.Address;
            PhoneTxt.Text = qwery.Phone;
            FilialBox.Text = qwery.Polyclinic.Name;
            LoginTxt.Text = qwery.Login;
            PasswordTxt.Text = qwery.Password;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            var doctor = context.Doctors.Where(i => i.Doctor_id == IDAdminClasss.IDClass).FirstOrDefault();
            doctor.Name = NameTxt.Text;
            doctor.Lastname = LastnameTxt.Text;
            doctor.Patronymic = PatronymicTxt.Text;
            doctor.Doctor_id = context.Specialty.Where(i => i.Specialty1 == DoctorBox.SelectedItem.ToString()).
                Select(i => i.Specialty_id).FirstOrDefault();
            doctor.Cabinet = Int32.Parse(CabinetText.Text);

            pasport = SeriaText.Text + " " + NomerText.Text;

            doctor.Passport = pasport;
            doctor.Address = AddressText.Text;
            doctor.Phone = PhoneTxt.Text;
            doctor.Polyclinic_id = context.Polyclinic.Where(i => i.Name == FilialBox.SelectedItem.ToString()).
                Select(i => i.Polyclinic_id).FirstOrDefault();
            doctor.Login = LoginTxt.Text;
            doctor.Password = PasswordTxt.Text;
        }
    }
}
