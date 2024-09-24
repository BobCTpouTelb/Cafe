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
using Сafe.Model;

namespace Сafe.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else if (string.IsNullOrEmpty(LoginTb.Text) || string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                // Проверка данных, поиск пользователя в таблице БД
                Employee newEmployee = App.context.Employee.FirstOrDefault(employee => employee.Login == LoginTb.Text && employee.Password == PasswordPb.Password);
                
                if(newEmployee != null)
                {
                    MainWindow mainWindow = new MainWindow();

                    // Сотрудник найден
                    switch (newEmployee.RoleId)
                    {
                        case 1:
                            // Открываем страницу администратора
                            new AdministratorWindow().Show();
                            break;
                        case 2:
                            // Открываем страницу официанта
                            mainWindow.Show();
                            break;
                        case 3:
                            // Открываем страницу повара
                            mainWindow.Show();
                            break;
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }
        }
    }
}
