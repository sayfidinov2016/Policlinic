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
    /// Логика взаимодействия для DirectionPage.xaml
    /// </summary>
    public partial class DirectionPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        Direction direction = new Direction();
        public DirectionPage()
        {
            Polyclinicdb context = new Polyclinicdb();
            InitializeComponent();
            var qwery = context.Patients.Where(i => i.Patient_id == IDpatient.user).FirstOrDefault();
            Patient.Text = qwery.FIO;

            DoctorBox.ItemsSource = context.Specialty.Where(i => i.Specialty_id > 9).Select(i => i.Specialty1).ToList();
            DoctorBox.SelectedItem = context.Specialty.Where(i => i.Specialty_id == direction.Specialty_id).Select(i => i.Specialty1).FirstOrDefault();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            DoctorsFrame.DocFrame.GoBack();
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            int _Specialty_id = context.Specialty.Where(i => i.Specialty1 == DoctorBox.SelectedItem)
                .Select(i => i.Specialty_id).FirstOrDefault();
            int _Patient_id = IDpatient.user;
            context.Direction.Add(new Direction
            {
                Specialty_id = _Specialty_id,
                Patient_id = _Patient_id
            });
            context.SaveChanges();
            MessageBox.Show("Направление создано!");
            DoctorsFrame.DocFrame.GoBack();
        }
    }
}
