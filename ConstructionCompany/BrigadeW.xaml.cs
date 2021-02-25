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
using System.ComponentModel;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для Brigade.xaml
    /// </summary>
    public partial class BrigadeW : Window
    {
        public BrigadeW()
        {
            InitializeComponent();
            Loaded += BrigadeW_Loaded;
        }

        private void BrigadeW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new BrigadesViewModel();
        }

        private void Button_AddClick(object sender, RoutedEventArgs e)
        {
            AddBrigade AB = new AddBrigade();
            AB.DataContext = new Brigade();
            AB.Owner = this;
            AB.ShowDialog();
            if (AB.DataContext != null && AB.DialogResult == true)
            {
                string error = "";
                if ((AB.DataContext as Brigade).BrigadierName == null)
                    error += "Вы не выбрали бригадира.\n";
                if ((AB.DataContext as Brigade).WorkName == null)
                    error += "Вы не выбрали вид работ.\n";
                if (error == null)
                    MessageBox.Show(error, "Ошибка!");
                else
                {
                    DataModel.Brigades.Add(AB.DataContext as Brigade);
                }
            }
        }

        private void EditMaterial_Click(object sender, RoutedEventArgs e)
        {
            if (BrigadeDG.SelectedItem != null)
            {
                AddBrigade AB = new AddBrigade();
                AB.DataContext = (BrigadeDG.SelectedItem as Brigade);
                AB.Owner = this;
                AB.ShowDialog();
            }
            else MessageBox.Show("Вы не выбрали бригаду для редактирования.");
        }
    
        private void DeleteMaterial_Click(object sender, RoutedEventArgs e)
        {
            DataModel.Brigades.Remove(BrigadeDG.SelectedItem as Brigade);
        }
    }
}
