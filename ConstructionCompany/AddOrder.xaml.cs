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
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        public AddOrder()
        {
            InitializeComponent();
            Loaded += AddOrder_Loaded;
        }

        void UpdateObject()
        {
            comboBox_ObjectName.Items.Clear();
            foreach (Models.Object o in DataModel.Objects)
            {
                comboBox_ObjectName.Items.Add(o.Address);
            }
            comboBox_ObjectName.SelectedItem = (DataContext as Order).ObjectAddress;
        }

        private void AddOrder_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateObject();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddObject AO = new AddObject();
            AO.DataContext = new Models.Object();
            AO.Owner = this;
            AO.ShowDialog();
            if (AO.DataContext != null && AO.DialogResult == true)
            {
                DataModel.Objects.Add(AO.DataContext as Models.Object);
            }
            UpdateObject();
        }

        private void button_addorder_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
