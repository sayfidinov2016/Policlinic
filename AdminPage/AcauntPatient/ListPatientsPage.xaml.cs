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
    /// Логика взаимодействия для ListPatientsPage.xaml
    /// </summary>
    public partial class ListPatientsPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        private void PatientUpdate()
        {
            PatientsList.ItemsSource = context.Patients.ToList();
        }
        public ListPatientsPage()
        {
            InitializeComponent();
            PatientUpdate();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new AddPatiensPage());
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PatientsList.SelectedItem is Patients patients)
            {
                IDAdminClasss.IDClass = patients.Patient_id;
            }
            MenuFrameClass.AdminFrame.Navigate(new ChangePatientPage());
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Удалить данные?", "Удаление филиала", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (PatientsList.SelectedItem is Patients patients)
                {
                    var patient = context.Patients.Remove(context.Patients.
                        Where(i => i.Patient_id == patients.Patient_id).FirstOrDefault());
                    context.SaveChanges();
                    PatientUpdate();
                }
            }
        }

        private void MoreDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PatientsList.SelectedItem is Patients patients)
            {
                IDAdminClasss.IDClass = patients.Patient_id;
            }
            var qwery = context.Patients.Where(i => i.Patient_id == IDAdminClasss.IDClass);
            MenuFrameClass.AdminFrame.Navigate(new DataPatientPage());
        }
    }
}

