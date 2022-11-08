using Policlinic.Class;
using Policlinic.Patient.MenuPatient;
using Policlinic.Patient.PatientsClass;
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

namespace Policlinic.Patient.SingUp
{
    /// <summary>
    /// Логика взаимодействия для SingUpVisit.xaml
    /// </summary>
    public partial class SingUpVisit : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        Visits visits = new Visits();
        public SingUpVisit()
        {
            InitializeComponent();
            SpecList.ItemsSource = context.Specialty.Where(i => i.Specialty_id <=6).ToList();
        }

        private void SingUp_Click(object sender, RoutedEventArgs e)
        {
            if (SpecList.SelectedItem is Specialty specialty)
            {
                Class_id.Spec = specialty.Specialty_id;
            }
            PatientClass.PatientFrame.Navigate(new DateVisitPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            PatientClass.PatientFrame.GoBack();
        }
    }
}
