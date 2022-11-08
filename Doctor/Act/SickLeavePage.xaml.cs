using Policlinic.Class;
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
    /// Логика взаимодействия для SickLeavePage.xaml
    /// </summary>
    public partial class SickLeavePage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public SickLeavePage()


        {
            InitializeComponent();

            
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            context.SickLeave.Add(new SickLeave
            {
                Patient_id = IDpatient.id_patient,
                OpeningData = (DateTime)DateOpen.SelectedDate,
                ClosingData = (DateTime)DateClose.SelectedDate,
                Comment = Coment.Text
            });
            context.SaveChanges();
            MessageBox.Show("Больничный сформирован!");
            DoctorsFrame.DocFrame.GoBack();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            DoctorsFrame.DocFrame.GoBack();
        }
    }
}
