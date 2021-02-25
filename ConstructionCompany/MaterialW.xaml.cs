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
using ConstructionCompany.ViewModels;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для MaterialW.xaml
    /// </summary>
    public partial class MaterialW : Window
    {
        public MaterialW()
        {
            InitializeComponent();
            Loaded += MaterialW_Loaded;
        }

        private void MaterialW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MaterialsViewModel();
        }
        
        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            AddMaterial AM = new AddMaterial();
            AM.DataContext = new Material();
            AM.Owner = this;
            AM.ShowDialog();
            if (AM.DataContext != null && AM.DialogResult == true)
            {
                DataModel.Materials.Add(AM.DataContext as Material);
            }
        }

        private void EditMaterial_Click(object sender, RoutedEventArgs e)
        {
            if (MaterialDG.SelectedItem != null)
            {
                AddMaterial AM = new AddMaterial();
                AM.DataContext = (MaterialDG.SelectedItem as Material);
                AM.Owner = this;
                AM.ShowDialog();
            }
            else MessageBox.Show("Выберите материал для редактирования.");
        }

        private void DeleteMaterial_Click(object sender, RoutedEventArgs e)
        {
            DataModel.Materials.Remove(MaterialDG.SelectedItem as Material);
        }
    }
}
