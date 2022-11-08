using Policlinic.AdminPage;
using Policlinic.AdminPage.MenuAdmin;
using Policlinic.Class;
using Policlinic.Doctor;
using Policlinic.Patient;
using Policlinic.Patient.MenuPatient;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Policlinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Polyclinicdb context = new Polyclinicdb();
        
        public string login { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            login = LoginTxt.Text;
        }

        private void VhodBtn_Click(object sender, RoutedEventArgs e)
        {
            var doctor = context.Doctors.Where(i => LoginTxt.Text == i.Login && PasswordTxt.Text == i.Password);
            var patient = context.Patients.Where(i => LoginTxt.Text == i.Login && PasswordTxt.Text == i.Password);
            var admin = context.Admin.Where(i => LoginTxt.Text == i.Login && PasswordTxt.Text == i.Password);

            if (doctor.Count() > 0)
            {
                
                MenuDocForm menuDocForm = new MenuDocForm(doctor.FirstOrDefault());
                menuDocForm.Show();
                this.Close();
            }
            else if (patient.Count() > 0)
            {
                menuPatientForm mPatientForm = new menuPatientForm(patient.FirstOrDefault());
                mPatientForm.Show();
                this.Close();
            }
            else if (admin.Count() > 0)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Неправильный логин или пароль");
                LoginTxt.Text = "";
                PasswordTxt.Text = "";
            }
        }

        private void RegistrBtn_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrForm registrForm = new RegistrForm();
            registrForm.ShowDialog();
        }

        private void LoginTxt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Enter)
            {
                PasswordTxt.Focus();
            }
        }
    }
}
