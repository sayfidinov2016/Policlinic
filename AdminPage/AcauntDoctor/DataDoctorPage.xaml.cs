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
    /// Логика взаимодействия для DataDoctorPage.xaml
    /// </summary>
    public partial class DataDoctorPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public DataDoctorPage()
        {
            InitializeComponent();
            var qwery = context.Doctors.Where(i => i.Doctor_id == IDAdminClasss.IDClass).FirstOrDefault();

            NameTxt.Text = qwery.Name;
            LastnameTxt.Text = qwery.Lastname;
            PatronymicTxt.Text = qwery.Patronymic;
            DateOfBirthTxt.Text = qwery.DataOfBirth.ToString();
            FloorTxt.Text = qwery.Floor.Floor1;
            DoctorTxt.Text = qwery.Specialty.Specialty1;
            CabinetText.Text = qwery.Cabinet.ToString();
            PasportText.Text = qwery.Passport;
            AddressText.Text = qwery.Address;
            PhoneTxt.Text = qwery.Address;
            FilialTxt.Text = qwery.Polyclinic.Name;
            LoginTxt.Text = qwery.Login;
            PasswordTxt.Text = qwery.Password;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }
    }
}
