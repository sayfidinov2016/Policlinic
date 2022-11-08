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
using System.Windows.Shapes;

namespace Policlinic.Doctor
{
    /// <summary>
    /// Логика взаимодействия для MenuDocForm.xaml
    /// </summary>
    public partial class MenuDocForm : Window
    {
        private Doctors Selectdoc = new Doctors();
        public MenuDocForm(Doctors _Selectetdoc)
        {
            InitializeComponent();

            if (_Selectetdoc != null)
            {
                Selectdoc = _Selectetdoc;
            }
            LastnameTxt.Text = Selectdoc.Lastname;
            NameTxt.Text = Selectdoc.Name;
            PatronymicTxt.Text = Selectdoc.Patronymic;
            SpecialtyTxt.Text = Selectdoc.Specialty.Specialty1;

            DoctorFrame.Navigate(new MenuDocPage());
            DoctorsFrame.DocFrame = DoctorFrame;

            IDpatient.spec = Selectdoc.Specialty.Specialty1;
        }

        private void ExitForm_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
