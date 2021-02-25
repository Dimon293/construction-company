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

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для AddMachinery.xaml
    /// </summary>
    public partial class AddMachinery : Window
    {
        public AddMachinery()
        {
            InitializeComponent();
            Loaded += AddMachinery_Loaded;

        }

        private void AddMachinery_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (MachineryType mt in DataModel.MachineryTypes)
            {
                comboBox_MachineryTypeName.Items.Add(mt.TypeName);
            }
            comboBox_MachineryTypeName.SelectedItem = (DataContext as Machinery).MachineryTypeName;
        }

        private void button_AddMachinery_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
