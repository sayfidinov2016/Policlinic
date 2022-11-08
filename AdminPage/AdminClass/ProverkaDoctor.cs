using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Policlinic.AdminPage.AdminClass
{
    static class ProverkaDoctor
    {
        internal static bool Doc(TextBox nameTxt, TextBox lastnameTxt, TextBox patronymicTxt, TextBox cabinetTxt, TextBox seriaTxt,
                TextBox nomerTxt, TextBox adresTxt, TextBox phoneTxt, TextBox loginTxt, TextBox passwordTxt)
        {
            string name = nameTxt.Text;
            string lastname = lastnameTxt.Text;
            string patronymic = patronymicTxt.Text;
            string cabinet = cabinetTxt.Text;
            string seria = seriaTxt.Text;
            string nomer = nomerTxt.Text;
            string adres = adresTxt.Text;
            string phone = phoneTxt.Text;
            string login = loginTxt.Text;
            string password = passwordTxt.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поле Имя пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                nameTxt.Focus();

                return false;
            } else if (name.IndexOf('0') >= 0 || name.IndexOf('1') >= 0 || name.IndexOf('2') >= 0 || name.IndexOf('3') >= 0
                    || name.IndexOf('4') >= 0 || name.IndexOf('5') >= 0 || name.IndexOf('6') >= 0 || name.IndexOf('7') >= 0
                    || name.IndexOf('8') >= 0 || name.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Имя имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                nameTxt.Text = "";
                nameTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Поле Фамилия пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                lastnameTxt.Focus();

                return false;
            }
            else if (lastname.IndexOf('0') >= 0 || lastname.IndexOf('1') >= 0 || lastname.IndexOf('2') >= 0 || lastname.IndexOf('3') >= 0
                  || lastname.IndexOf('4') >= 0 || lastname.IndexOf('5') >= 0 || lastname.IndexOf('6') >= 0 || lastname.IndexOf('7') >= 0
                  || lastname.IndexOf('8') >= 0 || lastname.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Фамилия имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                lastnameTxt.Text = "";
                lastnameTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(patronymic))
            {
                MessageBox.Show("Поле Отчество пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                patronymicTxt.Focus();

                return false;
            }
            else if (patronymic.IndexOf('0') >= 0 || patronymic.IndexOf('1') >= 0 || patronymic.IndexOf('2') >= 0 
                  || patronymic.IndexOf('3') >= 0 || patronymic.IndexOf('4') >= 0 || patronymic.IndexOf('5') >= 0 
                  || patronymic.IndexOf('6') >= 0 || patronymic.IndexOf('7') >= 0
                  || patronymic.IndexOf('8') >= 0 || patronymic.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Отчество имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                patronymicTxt.Text = "";
                patronymicTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(cabinet) || !cabinet.All(Char.IsDigit))
            {
                MessageBox.Show("Неправильный номер кабинета!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                cabinetTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(seria) || !seria.All(Char.IsDigit) || seria.Length < 4)
            {
                MessageBox.Show("Неправильный формат серии паспота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                seriaTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(nomer) || !nomer.All(Char.IsDigit) || nomer.Length < 6)
            {
                MessageBox.Show("Неправильный формат номера паспота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                nomerTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(adres))
            {
                MessageBox.Show("Поле Адрес пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                adresTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(phone) || !phone.All(Char.IsDigit) || phone.Length < 11)
            {
                MessageBox.Show("Неправильный формат телефона!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                phoneTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Поле Логин пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                loginTxt.Focus();

                return false;
            }
            else if (login.Length < 8)
            {
                MessageBox.Show("Логин не меньше 8 символов!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                loginTxt.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле Пароль пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                passwordTxt.Focus();

                return false;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Пароль не меньше 8 символов!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                passwordTxt.Focus();

                return false;
            }

            return true;
        }
    }
}
