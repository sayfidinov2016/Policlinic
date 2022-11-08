using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Policlinic.AdminPage.AddClass
{
    static class ProverkaFilialClass
    {
        internal static bool AddFilial(TextBox NameTxt, TextBox AdresTxt)
        {
            string name = NameTxt.Text;
            string adres = AdresTxt.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поле Имя пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                NameTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(adres))
            {
                MessageBox.Show("Поле Имя пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                AdresTxt.Focus();

                return false;
            }

            return true;
        }
    }
}
