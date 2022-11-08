using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Policlinic.Registr
{
    static class Proverka
    {
        internal static bool Check(TextBox txtName, TextBox txtLastName, TextBox txtPatronymic, TextBox txtPolicy, TextBox txtAddress,
                TextBox txtPhone, TextBox txtPassw, TextBox txtLogin)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            string patronymic = txtPatronymic.Text;
            string policy = txtPolicy.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string password = txtPassw.Text;
            string login = txtLogin.Text;

            int[] num = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поле Имя пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Focus();

                return false;
            }
            else if (name.IndexOf('1') >= 0 || name.IndexOf('2') >= 0 || name.IndexOf('3') >= 0 ||
               name.IndexOf('4') >= 0 || name.IndexOf('5') >= 0 || name.IndexOf('6') >= 0 ||
               name.IndexOf('7') >= 0 || name.IndexOf('8') >= 0 ||
               name.IndexOf('9') >= 0 || name.IndexOf('0') >= 0)
            {
                MessageBox.Show("В поле Имя имеются цифры!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Text = "";
                txtName.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Поле Фамилия пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLastName.Focus();

                return false;
            }
            else if (lastName.IndexOf('1') >= 0 || lastName.IndexOf('2') >= 0 || lastName.IndexOf('3') >= 0 ||
               lastName.IndexOf('4') >= 0 || lastName.IndexOf('5') >= 0 || lastName.IndexOf('6') >= 0 ||
               lastName.IndexOf('7') >= 0 || lastName.IndexOf('8') >= 0 ||
               lastName.IndexOf('9') >= 0 || lastName.IndexOf('0') >= 0)
            {
                MessageBox.Show("В поле Фамилия имеются цифры!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLastName.Text = "";
                txtLastName.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(patronymic))
            {
                MessageBox.Show("Поле Пароль пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPatronymic.Focus();

                return false;
            }
            else if (patronymic.IndexOf('1') >= 0 || patronymic.IndexOf('2') >= 0 || patronymic.IndexOf('3') >= 0 ||
               patronymic.IndexOf('4') >= 0 || patronymic.IndexOf('5') >= 0 || patronymic.IndexOf('6') >= 0 ||
               patronymic.IndexOf('7') >= 0 || patronymic.IndexOf('8') >= 0 ||
               patronymic.IndexOf('9') >= 0 || patronymic.IndexOf('0') >= 0)
            {
                MessageBox.Show("В поле Отчество имеются цифры!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPatronymic.Text = "";
                txtPatronymic.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(policy) || !policy.All(Char.IsDigit) || policy.Length < 16)
            {
                MessageBox.Show("Неправильный формат страхового полиса!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPolicy.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Поле Адрес пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtAddress.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(phone) || !phone.All(Char.IsDigit) || phone.Length < 11)
            {
                MessageBox.Show("Неправильный формат телефона!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPhone.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Поле Логин пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLogin.Focus();

                return false;
            }
            else if (login.Length < 8)
            {
                MessageBox.Show("Логин не меньше 8 символов!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLogin.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле Пароль пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPassw.Focus();

                return false;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Пароль не меньше 8 символов!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPassw.Focus();

                return false;
            }

            return true;
        }
    }
}
