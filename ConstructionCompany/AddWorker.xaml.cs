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
    /// Логика взаимодействия для AddWorker.xaml
    /// </summary>
    public partial class AddWorker : Window
    {
        public AddWorker()
        {
            InitializeComponent();
            Loaded += AddWorker_Loaded;
        }

        private void AddWorker_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Brigade b in DataModel.Brigades)
            {
                comboBox_BrigadeName.Items.Add(b.Name);
            }
            comboBox_BrigadeName.SelectedItem = (DataContext as Worker).BrigadeName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddBrigade AB = new AddBrigade();
            AB.DataContext = new Brigade();
            AB.Owner = this;
            AB.ShowDialog();
            if (AB.DataContext != null && AB.DialogResult == true)
            {
                DataModel.Brigades.Add(AB.DataContext as Brigade);
            }
        }

        private void button_addworker_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
