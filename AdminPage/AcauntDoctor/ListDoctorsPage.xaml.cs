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

namespace Policlinic.AdminPage.AcauntDoctor
{
    /// <summary>
    /// Логика взаимодействия для ListDoctorsPage.xaml
    /// </summary>
    public partial class ListDoctorsPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        private void DoctorUpdate()
        {
            DoctorsList.ItemsSource = context.Doctors.ToList();
        }
        public ListDoctorsPage()
        {
            InitializeComponent();
            DoctorUpdate();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new AddDoctorPage());
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Удалить доктора?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Error);
            if (result == MessageBoxResult.Yes)
            {
                if (DoctorsList.SelectedItem is Doctors doctors)
                {
                    context.Doctors.Remove(context.Doctors.Where(i => i.Doctor_id == doctors.Doctor_id).FirstOrDefault());
                    context.SaveChanges();
                    MessageBox.Show("Акаунт доктора удален");
                    DoctorUpdate();
                }
            }
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DoctorsList.SelectedItem is Doctors doctors)
            {
                IDAdminClasss.IDClass = doctors.Doctor_id;
            }
            MenuFrameClass.AdminFrame.Navigate(new ChangeDoctorPage());
        }

        private void MoreDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DoctorsList.SelectedItem is Doctors doctors)
            {
                IDAdminClasss.IDClass = doctors.Doctor_id;
            }
            var qwery = context.Doctors.Where(i => i.Doctor_id == IDAdminClasss.IDClass);
            MenuFrameClass.AdminFrame.Navigate(new DataDoctorPage());
        }
    }
}
