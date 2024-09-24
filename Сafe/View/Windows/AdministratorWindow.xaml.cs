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
using Сafe.View.Windows.Administrator;

namespace Сafe.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdministratorWindow.xaml
    /// </summary>
    public partial class AdministratorWindow : Window
    {
        public AdministratorWindow()
        {
            InitializeComponent();
        }

        private void EmployeeListBTN_Click(object sender, RoutedEventArgs e)
        {
            // открываем страницу сотрудников
            // обращаемся к фрэйму по имени, вызываем метод Navigate(), в скобках создаем экземпляр страницы
            MainFrame.Navigate(new EmployeesPage());
        }

        private void OrderListBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShiftListBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
