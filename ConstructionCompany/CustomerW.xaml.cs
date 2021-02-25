using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using ConstructionCompany.Models;
using ConstructionCompany.ViewModels;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для Customer.xaml
    /// </summary>
    public partial class CustomerW : Window
    {
        public CustomerW()
        {
            InitializeComponent();
            Loaded += CustomerW_Loaded;
        }

        private void CustomerW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new CustomersViewModel();
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer AC = new AddCustomer();
            AC.DataContext = new Customer();
            AC.Owner = this;
            AC.ShowDialog();
            if (AC.DataContext != null && AC.DialogResult == true)
            {
                if ((AC.DataContext as Customer).Phone.ToString().Length != 6)
                {
                    MessageBox.Show("Неверно введен номер телефона.");
                }
                else
                    DataModel.Customers.Add(AC.DataContext as Customer);
            }
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            DataModel.Customers.Remove(CustomersDG.SelectedItem as Customer);
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (CustomersDG.SelectedItem != null)
            {
                AddCustomer AC = new AddCustomer();
                AC.DataContext = (CustomersDG.SelectedItem as Customer);
                AC.Owner = this;
                AC.ShowDialog();
            }
            else MessageBox.Show("Выберите клиента для редактирования.");
        }

        //void ApplyConditions()
        //{
        //    string filter = searchTB.Text.ToLower();
        //    ICollectionView cv = CollectionViewSource.GetDefaultView(CustomersDG.ItemsSource);
        //    cv.Filter = null;
        //    cv.Filter = o =>
        //    {
        //        Customer p = o as Customer;
        //        if (conditionsCB.Text == "Фамилия")
        //        {
        //            if (!p.LastName.ToLower().Contains(filter))
        //                return false;
        //        }
        //        else if (conditionsCB.Text == "Имя")
        //        {
        //            if (!p.FirstName.ToLower().Contains(filter))
        //                return false;
        //        }
        //        else if (conditionsCB.Text == "Отчество")
        //        {
        //            if (!p.Patronymic.ToLower().Contains(filter))
        //                return false;
        //        }
        //        else if (conditionsCB.Text == "Телефон")
        //        {
        //            if (!p.Phone.Contains(filter))
        //                return false;
        //        }
        //        return true;
        //    };
        //}
        
    }
}
