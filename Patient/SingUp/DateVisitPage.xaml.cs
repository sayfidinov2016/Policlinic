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
    /// Логика взаимодействия для DateVisitPage.xaml
    /// </summary>
    public partial class DateVisitPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public DateVisitPage()
        {
            InitializeComponent();
            DoctorList.ItemsSource = context.Doctors.Where(i => i.Specialty_id == Class_id.Spec).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientClass.PatientFrame.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Doctors doctor = (Doctors)DoctorList.SelectedItem; 
            if(doctor == null) throw new NullReferenceException("SelectedItem != Doctors");

            context.Visits.Add(new Visits
            {
                Doctor_id = doctor.Doctor_id,
                Patient_id = Class_id.User,
                Data = TimeVisit.SelectedDate
            });
            context.SaveChanges();
            MessageBox.Show("Запись успешна!");
            PatientClass.PatientFrame.Navigate(new PatientMenu());
        }
    }
}
