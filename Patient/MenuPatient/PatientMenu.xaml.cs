using Policlinic.Patient.DirectionPage;
using Policlinic.Patient.PatientsClass;
using Policlinic.Patient.SingUp;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

namespace Policlinic.Patient.MenuPatient

{
    /// <summary>
    /// Логика взаимодействия для PatientMenu.xaml
    /// </summary>
    public partial class PatientMenu : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public void VisitUpdate()
        {
            VisitsList.ItemsSource = context.Visits.Where(i => i.Comment == null).ToList();
        }
        public void HistoryUpdate()
        {
            HistoryList.ItemsSource = context.Visits.Where(i => i.Comment != null).ToList();
        }
        public PatientMenu()
        {
            InitializeComponent();
            VisitUpdate();
            HistoryUpdate();
        }

        private void SingUpBtn_Click(object sender, RoutedEventArgs e)
        {
            PatientClass.PatientFrame.Navigate(new SingUpVisit());
            VisitUpdate();
            HistoryUpdate();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Удалить доктора?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Error);
            if (result == MessageBoxResult.Yes)
            {
                if (VisitsList.SelectedItem is Visits visit)
                {
                    context.Visits.Remove(context.Visits.Where(i => i.Visit_id == visit.Visit_id).FirstOrDefault());
                    context.SaveChanges();
                    MessageBox.Show("Запись удален!");
                    VisitUpdate();
                }

                if (HistoryList.SelectedItem is Visits visits)
                {
                    context.Visits.Remove(context.Visits.Where(i => i.Visit_id == visits.Visit_id).FirstOrDefault());
                    context.SaveChanges();
                    MessageBox.Show("Архив удален!");
                    VisitUpdate();
                }
            }
        }

        private void DirectionsBtn_Click(object sender, RoutedEventArgs e)
        {
            PatientClass.PatientFrame.Navigate(new SingUpDisc());
            VisitUpdate();
            HistoryUpdate();
        }
    }
}
