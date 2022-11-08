using Policlinic.AdminPage.AddClass;
using Policlinic.AdminPage.AdminClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для AddDoctorForm.xaml
    /// </summary>
    public partial class AddDoctorPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        Doctors doctors = new Doctors();
        private string pasport;
        public AddDoctorPage()
        {
            InitializeComponent();
            FloorBox.ItemsSource = context.Floor.Select(i => i.Floor1).ToList();
            FloorBox.SelectedItem = context.Floor.Where(i => i.Floor_id == doctors.Flor_id).Select(i => i.Floor1).FirstOrDefault();
            DoctorBox.ItemsSource = context.Specialty.Select(i => i.Specialty1).ToList();
            DoctorBox.SelectedItem = context.Specialty.Where(i => i.Specialty_id == doctors.Specialty_id).Select(i => i.Specialty1).FirstOrDefault();
            FilialBox.ItemsSource = context.Polyclinic.Select(i => i.Name).ToList();
            FilialBox.SelectedItem = context.Polyclinic.Where(i => i.Polyclinic_id == doctors.Polyclinic_id).Select(i => i.Name).FirstOrDefault();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }

        private void RegistrBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!ProverkaDoctor.Doc(NameTxt, LastnameTxt, PatronymicTxt, CabinetText, SeriaText, NomerText, AddressText,
                    PhoneTxt, LoginTxt, PasswordTxt))
            {
                return;
            }

            pasport = SeriaText.Text + " " + NomerText.Text;



            int _Flor_id = context.Floor.Where(i => i.Floor1 == FloorBox.SelectedItem.ToString())
                   .Select(i => i.Floor_id).FirstOrDefault();
            int _Specialty_id = context.Specialty.Where(i => i.Specialty1 == DoctorBox.SelectedItem.ToString())
                    .Select(i => i.Specialty_id).FirstOrDefault();
            int _Polyclinic_id = context.Polyclinic.Where(i => i.Name == FilialBox.SelectedItem.ToString())
                    .Select(i => i.Polyclinic_id).FirstOrDefault();

            Doctors doctor = new Doctors()
            {
                Name = NameTxt.Text,
                Lastname = LastnameTxt.Text,
                Patronymic = PatronymicTxt.Text,
                DataOfBirth = (DateTime)DateOfBirthTxt.SelectedDate,
                Flor_id = _Flor_id,
                Specialty_id = _Specialty_id,
                Cabinet = Int32.Parse(CabinetText.Text),
                Passport = pasport,
                Address = AddressText.Text,
                Phone = PhoneTxt.Text,
                Polyclinic_id = _Polyclinic_id,
                Login = LoginTxt.Text,
                Password = PasswordTxt.Text
            };

            context.Doctors.Add(doctor); 
            context.SaveChanges();
            MessageBox.Show($"Акаун {NameTxt.Text} добавлен!");
            MenuFrameClass.AdminFrame.GoBack();
        }
    }
}
