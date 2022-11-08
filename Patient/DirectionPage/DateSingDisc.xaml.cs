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

namespace Policlinic.Patient.DirectionPage
{
    /// <summary>
    /// Логика взаимодействия для DateSingDisc.xaml
    /// </summary>
    public partial class DateSingDisc : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public DateSingDisc()
        {
            InitializeComponent();
            DoctorList.ItemsSource = context.Doctors.Where(i => i.Specialty_id == Class_id.Spec).ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            PatientClass.PatientFrame.GoBack();
        }

        private void SingBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DoctorList.SelectedItem is Doctors doctors)
            {
                Class_id.Doc = doctors.Doctor_id;
            }
            int _doctor_id = Class_id.Doc;
            int _patinent_id = Class_id.User;

            context.Visits.Add(new Visits
            {
                Doctor_id = _doctor_id,
                Patient_id = _patinent_id,
                Data = DateSing.SelectedDate
            }) ;
            context.SaveChanges();

            context.Direction.Remove(context.Direction.Where(i => i.Direction_id == Class_id.Visit).FirstOrDefault());
            context.SaveChanges();
            MessageBox.Show("Запись успешна!");

            PatientClass.PatientFrame.Navigate(new PatientMenu());
        }
    }
}
