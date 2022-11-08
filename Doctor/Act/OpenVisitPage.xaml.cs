using Policlinic.Doctor.DoctorClass;
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

namespace Policlinic.Doctor.Act
{
    /// <summary>
    /// Логика взаимодействия для OpenVisitPage.xaml
    /// </summary>
    public partial class OpenVisitPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public OpenVisitPage()
        {
            InitializeComponent();
            var qwery = context.Visits.Where(i => i.Visit_id == IDpatient.id_patient).FirstOrDefault();

            NameTxt.Text = qwery.Patients.Name;
            LastnameTxt.Text = qwery.Patients.Lastname;
            PatronymicTxt.Text = qwery.Patients.Patronymic;
            DateOfBirthTxt.Text = qwery.Patients.DateOfBirth.ToString();
            Polis.Text = qwery.Patients.Policy.ToString();

            IDpatient.user = qwery.Patient_id;

            WriteBtn.Visibility = Visibility.Hidden;
            DirectionBtn.Visibility = Visibility.Hidden;
            string spec = IDpatient.spec;
            if (spec == "Дежурный врач")
            {
                WriteBtn.Visibility = Visibility.Visible;
                DirectionBtn.Visibility = Visibility.Visible;
            }
            
        }

        private void WriteBtn_Click(object sender, RoutedEventArgs e)
        {
                DoctorsFrame.DocFrame.Navigate(new SickLeavePage());
        }

        private void Exitbtn_Click(object sender, RoutedEventArgs e)
        {
            var visit = context.Visits.Where(i => i.Visit_id == IDpatient.id_patient).FirstOrDefault();
            visit.Comment = ComentTxt.Text;
            context.SaveChanges();

            DoctorsFrame.DocFrame.GoBack();
        }

        private void DirectionBtn_Click(object sender, RoutedEventArgs e)
        {
            DoctorsFrame.DocFrame.Navigate(new DirectionPage());
        }
    }
}
