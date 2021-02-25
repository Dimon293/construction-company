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
    /// Логика взаимодействия для MaterialsUsing.xaml
    /// </summary>
    public partial class AddMachineryUsing : Window
    {
        public AddMachineryUsing()
        {
            InitializeComponent();
            Loaded += AddMaterialUsing_Loaded;
        }

        void UpdateMachineryType()
        {
            comboBox_TypeName.Items.Clear();
            foreach (MachineryType m in DataModel.MachineryTypes)
            {
                comboBox_TypeName.Items.Add(m.TypeName);
            }
            //comboBox_TypeName.SelectedIndex = 0;
            // comboBox_TypeName.SelectedItem = (DataContext as MachineryUsing).MachineryName;
        }

        void UpdateMachinery()
        {
            comboBox_MachineryName.Items.Clear();
            foreach (Machinery m in DataModel.Machinery)
            {
                if (!m.InUse && m.MachineryTypeName == comboBox_TypeName.SelectedItem.ToString())
                    comboBox_MachineryName.Items.Add(m.Name);
            }
            // comboBox_MachineryName.SelectedItem = (DataContext as MachineryUsing).MachineryName;
        }

        private void AddMaterialUsing_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (MachineryType m in DataModel.MachineryTypes)
            {
                comboBox_TypeName.Items.Add(m.TypeName);
            }

            comboBox_TypeName.SelectedIndex = 0;

            foreach (Machinery m in DataModel.Machinery)
            {
                if (!m.InUse && m.MachineryTypeName == comboBox_TypeName.SelectedItem.ToString())
                    comboBox_MachineryName.Items.Add(m.Name);
            }
        }
        

        private void comboBox_TypeName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateMachinery();
        }

        private void button_addmachineryusing_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
