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
    /// Логика взаимодействия для Works.xaml
    /// </summary>
    public partial class WorkW : Window
    {
        public WorkW()
        {
            InitializeComponent();
            Loaded += WorkW_Loaded;
        }

        private void WorkW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new WorksViewModel();
        }
        
        private void AddWork_Click(object sender, RoutedEventArgs e)
        {
            AddWork AW = new AddWork();
            AW.DataContext = new Work();
            AW.Owner = this;
            AW.ShowDialog();
            if (AW.DataContext != null && AW.DialogResult == true)
            {
                DataModel.Works.Add(AW.DataContext as Work);
            }
        }

        private void EditWork_Click(object sender, RoutedEventArgs e)
        {
            if (WorkDG.SelectedItem != null)
            {
                AddWork AW = new AddWork();
                AW.DataContext = (WorkDG.SelectedItem as Work);
                AW.Owner = this;
                AW.ShowDialog();
            }
            else MessageBox.Show("Выберите работу для редактирования.");
        }

        private void DeleteWork_Click(object sender, RoutedEventArgs e)
        {
            DataModel.Works.Remove(WorkDG.SelectedItem as Work);
        }
    }
}
