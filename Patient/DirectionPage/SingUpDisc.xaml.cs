using Policlinic.AdminPage.AcauntPatient;
using Policlinic.Class;
using Policlinic.Patient.PatientsClass;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для SingUpDisc.xaml
    /// </summary>
    public partial class SingUpDisc : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public SingUpDisc()
        {
            InitializeComponent();
            DescList.ItemsSource = context.Direction.ToList();
            
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            PatientClass.PatientFrame.GoBack();
        }

        private void SingBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DescList.SelectedItem is Direction direction)
            {
                Class_id.Spec = direction.Specialty_id;
                Class_id.Visit = direction.Direction_id;
            }
            PatientClass.PatientFrame.Navigate(new DateSingDisc());
        }
    }
}
