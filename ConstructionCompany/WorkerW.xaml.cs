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
    /// Логика взаимодействия для Worker.xaml
    /// </summary>
    public partial class WorkerW : Window
    {
        public WorkerW()
        {
            InitializeComponent();
            Loaded += WorkerW_Loaded;
        }

        private void WorkerW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new WorkersViewModel();
        }

        private void AddWorker_Click(object sender, RoutedEventArgs e)
        {
            AddWorker AW = new AddWorker();
            AW.DataContext = new Worker();
            AW.Owner = this;
            AW.ShowDialog();
            if (AW.DataContext != null && AW.DialogResult == true)
            {
                string error = "";
                if ((AW.DataContext as Worker).BrigadeName == null)
                    error += "Не выбрана бригада.\n";
                if ((AW.DataContext as Worker).Phone.ToString().Length != 6)
                    error += "Некорректно введен номер телефона.\n";
                if ((AW.DataContext as Worker).PassportNumber == 0)
                    error += "Не введен номер паспорта.\n";
                
                if (error == null)
                    MessageBox.Show(error, "Ошибка!");
                else
                    DataModel.Workers.Add(AW.DataContext as Worker);
            }
        }

        private void EditWorker_Click(object sender, RoutedEventArgs e)
        {
            if (WorkersDG.SelectedItem != null)
            {
                AddWorker AW = new AddWorker();
                AW.DataContext = (WorkersDG.SelectedItem as Worker);
                AW.Owner = this;
                AW.ShowDialog();
            }
            else MessageBox.Show("Выберите работника для изменения.");
        }

        private void DeleteWorker_Click(object sender, RoutedEventArgs e)
        {
            DataModel.Workers.Remove(WorkersDG.SelectedItem as Worker);
        }
    }
}
