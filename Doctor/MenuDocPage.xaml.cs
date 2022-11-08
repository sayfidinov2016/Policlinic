using Policlinic.Doctor.Act;
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

namespace Policlinic.Doctor
{
    /// <summary>
    /// Логика взаимодействия для MenuDocPage.xaml
    /// </summary>
    public partial class MenuDocPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public void VisitUpdata()
        {
            VisitList.ItemsSource = context.Visits.Where(i => i.Comment == null).ToList();
        }
        public MenuDocPage()
        {
            InitializeComponent();
            VisitUpdata();
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            if (VisitList.SelectedItem is Visits visits)
            {
                IDpatient.id_patient = visits.Visit_id;
            }
            DoctorsFrame.DocFrame.Navigate(new OpenVisitPage());
            VisitUpdata();
        }
    }
}
