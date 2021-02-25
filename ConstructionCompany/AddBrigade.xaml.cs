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
    /// Логика взаимодействия для AddBrigade.xaml
    /// </summary>
    public partial class AddBrigade : Window
    {
        public AddBrigade()
        {
            InitializeComponent();
            Loaded += AddBrigade_Loaded;
        }

        void UpdateWork()
        {
            comboBox_WorkName.Items.Clear();
            foreach (Work w in DataModel.Works)
            {
                comboBox_WorkName.Items.Add(w.WorkName);
            }
            comboBox_WorkName.SelectedItem = (DataContext as Brigade).WorkName;
        }

        void UpdateWorker()
        {
            comboBox_BrigadierName.Items.Clear();
            foreach (Worker w in DataModel.Workers)
            {
                comboBox_BrigadierName.Items.Add(w.LastName);
            }
            comboBox_BrigadierName.SelectedItem = (DataContext as Brigade).BrigadierName;
        }

        private void AddBrigade_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateWorker();
            UpdateWork();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWorker AW = new AddWorker();
            AW.DataContext = new Worker();
            AW.Owner = this;
            AW.ShowDialog();
            if (AW.DataContext != null && AW.DialogResult == true)
            {
                DataModel.Workers.Add(AW.DataContext as Worker);
            }
            UpdateWorker();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddWork AW = new AddWork();
            AW.DataContext = new Work();
            AW.Owner = this;
            AW.ShowDialog();
            if (AW.DataContext != null && AW.DialogResult == true)
            {
                DataModel.Works.Add(AW.DataContext as Work);
            }
            UpdateWork();
        }
        
        private void button_addbrigade_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
