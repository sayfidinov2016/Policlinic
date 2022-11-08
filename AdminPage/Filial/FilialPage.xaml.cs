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
    /// Логика взаимодействия для Filial.xaml
    /// </summary>
    public partial class FilialPage : Page
    {
        Polyclinicdb context = new Polyclinicdb();
        
        private void FilialUpdate()
        {
            FilialList.ItemsSource = context.Polyclinic.ToList();
        }
        public FilialPage()
        {
            InitializeComponent();
            FilialUpdate();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.Navigate(new AddFilial());
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Удалить данные?", "Удаление филиала", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (FilialList.SelectedItem is Polyclinic polyclinic)
                {
                    context.Polyclinic.Remove(context.Polyclinic.Where(i => i.Polyclinic_id == polyclinic.Polyclinic_id).FirstOrDefault());
                    context.SaveChanges();
                    FilialUpdate();
                }
            }
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FilialList.SelectedItem is Polyclinic polyclinic)
            {
                IDAdminClasss.IDClass = polyclinic.Polyclinic_id;
            }
            MenuFrameClass.AdminFrame.Navigate(new ChangeFilialPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrameClass.AdminFrame.GoBack();
        }
    }
}
