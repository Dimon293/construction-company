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

namespace ConstructionCompany.ViewModels
{
    /// <summary>
    /// Логика взаимодействия для RulesW.xaml
    /// </summary>
    public partial class AddRule : Window
    {
        public AddRule()
        {
            InitializeComponent();
            Loaded += AddRule_Loaded;
        }

        private void AddRule_Loaded(object sender, RoutedEventArgs e)
        {
           foreach(Work w in DataModel.Works)
            {
                comboBox_WorkName.Items.Add(w.WorkName);
            }
            foreach (Material m in DataModel.Materials)
            {
                comboBox_MaterialName.Items.Add(m.Name);
            }
            foreach (MachineryType mt in DataModel.MachineryTypes)
            {
                comboBox_MachineryName.Items.Add(mt.TypeName);
            }
        }

        private void button_AddMaterial_Click(object sender, RoutedEventArgs e)
        {

            listBox_Materials.Items.Add(comboBox_MaterialName.SelectedItem.ToString());
        }

        private void button_DelMaterial_Click(object sender, RoutedEventArgs e)
        {
            listBox_Materials.Items.Remove(listBox_Materials.SelectedItem.ToString());
        }

        private void button_AddRule_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (string name in listBox_Materials.Items)
            {
                DataModel.Rules.Add(new Rule(DataModel.Rules.Count, comboBox_WorkName.SelectedItem.ToString(), "Материал", (int)GetIdMaterialByName(name)));
            }
            foreach (string name in listBox_Machinery.Items)
            {
                DataModel.Rules.Add(new Rule(DataModel.Rules.Count, comboBox_WorkName.SelectedItem.ToString(), "Техника", (int)GetIdMachineryTypeByName(name)));
            }
            this.Close();
        }

        private void button_AddMachinery_Click(object sender, RoutedEventArgs e)
        {
            listBox_Machinery.Items.Add(comboBox_MachineryName.SelectedItem.ToString());
        }

        private void button_DelMachinery_Click(object sender, RoutedEventArgs e)
        {
            listBox_Machinery.Items.Remove(listBox_Machinery.SelectedItem.ToString());
        }

        long GetIdMachineryTypeByName(string name)
        {
            foreach (MachineryType mt in DataModel.MachineryTypes)
            {
                if (mt.TypeName == name)
                    return mt.Id;
            }
            return 0;
        }

        long GetIdMaterialByName(string name)
        {
            foreach (Material m in DataModel.Materials)
            {
                if (m.Name == name)
                    return m.Id;
            }
            return 0;
        }
    }
}
