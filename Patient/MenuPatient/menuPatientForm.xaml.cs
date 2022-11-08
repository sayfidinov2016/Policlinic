using Policlinic.Class;
using Policlinic.Patient.PatientsClass;
using Policlinic.Patient.SingUp;
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

namespace Policlinic.Patient.MenuPatient
{
    /// <summary>
    /// Логика взаимодействия для menuPatientForm.xaml
    /// </summary>
    public partial class menuPatientForm : Window
    {
        private Patients SelectPatien = new Patients();
        public menuPatientForm(Patients _SelectPatient)
        {
            InitializeComponent();

            if (_SelectPatient != null)
            {
                SelectPatien = _SelectPatient;
            }
            LastnameTxt.Text = SelectPatien.Lastname;
            NameTxt.Text = SelectPatien.Name;
            PatronymicTxt.Text = SelectPatien.Patronymic;
            DateOfBirthTxt.Text = SelectPatien.DateOfBirth.ToString();

            PatientClass.PatientFrame = PatientFrame;
            PatientFrame.Navigate(new PatientMenu());

            Class_id.User = SelectPatien.Patient_id;
        }

        private void ExitForm_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
