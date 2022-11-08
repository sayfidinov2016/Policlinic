using Policlinic.AdminPage.AcauntDoctor;
using Policlinic.AdminPage.AcauntPatient;
using Policlinic.AdminPage.AddClass;
using Policlinic.AdminPage.Filial;
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

namespace Policlinic.AdminPage.MenuAdmin
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void AddFilialBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new AddFilial());
        }

        private void FilealBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new FilialPage());
        }

        private void AddPatientBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new AddPatiensPage());
        }

        private void PatietsBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new ListPatientsPage());
        }

        private void AddDoctorBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new AddDoctorPage());
        }

        private void DoctorsBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new ListDoctorsPage());
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new DataPolic());
        }
    }
}
