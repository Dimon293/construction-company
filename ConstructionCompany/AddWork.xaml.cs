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
    /// Логика взаимодействия для AddWork.xaml
    /// </summary>
    public partial class AddWork : Window
    {
        public AddWork()
        {
            InitializeComponent();
            Loaded += AddWork_Loaded;
        }

        private void AddWork_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (WorkType wt in DataModel.WorkTypes)
            {
                comboBox_WorkTypeName.Items.Add(wt.TypeName);
            }
            comboBox_WorkTypeName.SelectedItem = (DataContext as Work).WorkTypeName;
        }

        private void button_addwork_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
