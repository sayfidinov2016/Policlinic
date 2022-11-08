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

namespace Policlinic.AdminPage.AcauntPatient
{
    /// <summary>
    /// Логика взаимодействия для DataPatientPage.xaml
    /// </summary>
    public partial class DataPatientPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        private Patients SelectPatient = new Patients();
        public DataPatientPage()
        {
            InitializeComponent();
            var qwery = context.Patients.Where(i => i.Patient_id == IDAdminClasss.IDClass).FirstOrDefault();

            NameTxt.Text = qwery.Name;
            LastnameTxt.Text = qwery.Lastname;
            PatronymicTxt.Text = qwery.Patronymic;
            DateOfBirthTxt.Text = qwery.DateOfBirth.ToString();
            FloorTxt.Text = qwery.Floor.Floor1;
            PolicyTxt.Text = qwery.Policy.ToString();
            AddressText.Text = qwery.Address;
            PhoneTxt.Text = qwery.Address;
            LoginTxt.Text = qwery.Login;
            PasswordTxt.Text = qwery.Password;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }
    }
}
