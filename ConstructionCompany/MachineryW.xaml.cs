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
using ConstructionCompany.ViewModels;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для MachineryW.xaml
    /// </summary>
    public partial class MachineryW : Window
    {
        public MachineryW()
        {
            InitializeComponent();
            Loaded += MachineryW_Loaded;
        }

        private void MachineryW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MachineryViewModel();
        }

        private void AddMachinery_Click(object sender, RoutedEventArgs e)
        {
            AddMachinery AM = new AddMachinery();
            AM.DataContext = new Machinery();
            AM.Owner = this;
            AM.ShowDialog();
            if (AM.DataContext != null && AM.DialogResult == true)
            {
                DataModel.Machinery.Add(AM.DataContext as Machinery);
            }
        }

        private void EditMachinery_Click(object sender, RoutedEventArgs e)
        {
            if (MachineryDG.SelectedItem != null)
            {
                AddMachinery AM = new AddMachinery();
                AM.DataContext = (MachineryDG.SelectedItem as Machinery);
                AM.Owner = this;
                AM.ShowDialog();
            }
            else MessageBox.Show("Выберите технику для редактирования.");
        }

        private void DeleteMachinery_Click(object sender, RoutedEventArgs e)
        {
            DataModel.Machinery.Remove(MachineryDG.SelectedItem as Machinery);
        }
    }
}
