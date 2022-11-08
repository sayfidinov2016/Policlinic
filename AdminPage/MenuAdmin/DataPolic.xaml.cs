using Policlinic.AdminPage.AddClass;
using Policlinic.AdminPage.DataPolic;
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
    /// Логика взаимодействия для DataPolic.xaml
    /// </summary>
    public partial class DataPolic : Page
    {
        public DataPolic()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }

        private void SpecialtyBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new SpecialtyPage());
        }

        private void VisitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new VisitPage());
        }

        private void SickLeaveBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new SickLeavePage());
        }

        private void DirectionBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new DirectionsPage());
        }
    }
}
