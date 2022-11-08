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

namespace Policlinic.AdminPage.DataPolic
{
    /// <summary>
    /// Логика взаимодействия для SpecialtyPage.xaml
    /// </summary>
    public partial class SpecialtyPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public SpecialtyPage()
        {
            InitializeComponent();
            SpecList.ItemsSource = context.Specialty.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }
    }
}
