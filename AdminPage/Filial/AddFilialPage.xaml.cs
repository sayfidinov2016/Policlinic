using Policlinic.AdminPage.AddClass;
using Policlinic.AdminPage.MenuAdmin;
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
    /// Логика взаимодействия для AddFilial.xaml
    /// </summary>
    public partial class AddFilial : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        public AddFilial()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(Object sender, RoutedEventArgs e)
        {

            MenuFrameClass.AdminFrame.GoBack();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!ProverkaFilialClass.AddFilial(NameTxt, AdresTxt))
            {
                return;
            }

            context.Polyclinic.Add(new Polyclinic
            {
                Name = NameTxt.Text,
                Address = AdresTxt.Text
            });
            context.SaveChanges();
            MessageBox.Show("Данные успешно доваблены", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
            MenuFrameClass.AdminFrame.Navigate(new MenuPage());
        }
    }
}
