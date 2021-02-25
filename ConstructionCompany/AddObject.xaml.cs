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
using ConstructionCompany.Models;
using System.ComponentModel;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для AddObject.xaml
    /// </summary>
    public partial class AddObject : Window
    {
        public AddObject()
        {
            InitializeComponent();
            Loaded += AddObject_Loaded;

        }

        void UpdateCustomer()
        {
            comboBox_CustomerName.Items.Clear();
            foreach (Customer c in DataModel.Customers)
            {
                comboBox_CustomerName.Items.Add(c.LastName);
            }
            comboBox_CustomerName.SelectedItem = (DataContext as Models.Object).CustomerName;
        }

        private void AddObject_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (ObjectType o in DataModel.ObjectTypes)
            {
                comboBox_ObjectTypeName.Items.Add(o.TypeName);
            }
            comboBox_ObjectTypeName.SelectedItem = (DataContext as Models.Object).ObjectTypeName;
            UpdateCustomer();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddCustomer AC = new AddCustomer();
            AC.DataContext = new Customer();
            AC.Owner = this;
            AC.ShowDialog();
            if (AC.DataContext != null && AC.DialogResult == true)
            {
                DataModel.Customers.Add(AC.DataContext as Customer);
            }
            UpdateCustomer();
        }

        private void button_addobject_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
