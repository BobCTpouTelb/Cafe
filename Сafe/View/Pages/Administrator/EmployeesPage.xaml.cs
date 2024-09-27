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
using Сafe.Model;

namespace Сafe.View.Windows.Administrator
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        List<Employee> employees = App.context.Employee.ToList();
        public EmployeesPage()
        {
            InitializeComponent();

            EmployeesLV.ItemsSource = employees;
        }

        private void EmployeesLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void saveEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
