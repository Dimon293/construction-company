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
    public partial class AddMaterialUsing : Window
    {
        public AddMaterialUsing()
        {
            InitializeComponent();
            Loaded += AddMaterialUsing_Loaded;
        }

        void UpdateMaterial()
        {
            comboBox_MaterialName.Items.Clear();
            foreach (Material m in DataModel.Materials)
            {
                comboBox_MaterialName.Items.Add(m.Name);
            }
            comboBox_MaterialName.SelectedItem = (DataContext as MaterialUsing).MaterialName;
        }

        private void AddMaterialUsing_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateMaterial();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddMaterial AM = new AddMaterial();
            AM.DataContext = new Material();
            AM.Owner = this;
            AM.ShowDialog();
            if (AM.DataContext != null && AM.DialogResult == true)
            {
                DataModel.Materials.Add(AM.DataContext as Material);
            }
            UpdateMaterial();
        }
        
        private void button_addmaterialusing_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int result;
            if (int.TryParse((sender as TextBox).Text, out result))
                countingPrice.Content = SetCountingPriceValue(comboBox_MaterialName.Text, int.Parse((sender as TextBox).Text));
            else
                MessageBox.Show("Неверно задано значение");
        }

        private int SetCountingPriceValue(string materialName, int count)
        {
            foreach (Material m in DataModel.Materials)
            {
                if (materialName == m.Name)
                    return m.Price * count;
            }
            throw new Exception("Материала не существует");
        }

        private void comboBox_MaterialName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            countingPrice.Content = SetCountingPriceValue((sender as ComboBox).SelectedItem.ToString(), int.Parse(textBox_Count.Text));
        }
    }
}
