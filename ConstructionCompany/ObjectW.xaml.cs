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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class ObjectW : Window
    {
        public ObjectW()
        {
            InitializeComponent();
            Loaded += ObjectW_Loaded;
        }

        private void ObjectW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new ObjectsViewModel();
        }

        private void AddObject_Click(object sender, RoutedEventArgs e)
        {
            AddObject AO = new AddObject();
            AO.DataContext = new Models.Object();
            AO.Owner = this;
            AO.ShowDialog();
            if (AO.DataContext != null && AO.DialogResult == true)
            {
                DataModel.Objects.Add(AO.DataContext as Models.Object);
            }
        }

        private void EditObject_Click(object sender, RoutedEventArgs e)
        {
            if (ObjectDG.SelectedItem != null)
            {
                AddObject AO = new AddObject();
                AO.DataContext = (ObjectDG.SelectedItem as Models.Object);
                AO.Owner = this;
                AO.ShowDialog();
            }
            else MessageBox.Show("Выберите объект для редактирования.");
        }

        private void DeleteObject_Click(object sender, RoutedEventArgs e)
        {
            DataModel.Objects.Remove(ObjectDG.SelectedItem as Models.Object);
        }
    }
}
