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

namespace Policlinic.AdminPage.Filial
{
    /// <summary>
    /// Логика взаимодействия для ChangeFilialPage.xaml
    /// </summary>
    public partial class ChangeFilialPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public ChangeFilialPage()
        {
            InitializeComponent();
            var qwery = context.Polyclinic.Where(i => i.Polyclinic_id == IDAdminClasss.IDClass).FirstOrDefault();

            NameTxt.Text = qwery.Name;
            AdresTxt.Text = qwery.Address;
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            var filial = context.Polyclinic.Where(i => i.Polyclinic_id == IDAdminClasss.IDClass).FirstOrDefault();
            filial.Name = NameTxt.Text;
            filial.Address = AdresTxt.Text;
            context.SaveChanges();
            MessageBox.Show("Данные успешно сохраненны!");
            MenuFrameClass.AdminFrame.GoBack();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }
    }
}
