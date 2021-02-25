using ConstructionCompany.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для AddMachineryInRule.xaml
    /// </summary>
    public partial class AddMachineryInRule : Window
    {
        private ObservableCollection<MachineryType> ExistingMachineryTypesCollection { get; set; }
        public AddMachineryInRule(ObservableCollection<MachineryType> existingMachineryTypesCollection)
        {
            this.ExistingMachineryTypesCollection = existingMachineryTypesCollection;
            InitializeComponent();
            Loaded += AddMachineryInRule_Loaded;
        }

        private void AddMachineryInRule_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (MachineryType m in DataModel.MachineryTypes)
            {
                if (!IsExistInMachineryTypesCollection(m))
                    comboBox_MachineryType.Items.Add(m.TypeName);
            }
        }

        bool IsExistInMachineryTypesCollection(MachineryType m)
        {
            foreach (MachineryType mt in ExistingMachineryTypesCollection)
            {
                if (mt.Id == m.Id)
                    return true;
            }
            return false;
        }

        MachineryType GetMachineryTypeByName(string name)
        {
            foreach (MachineryType m in DataModel.MachineryTypes)
            {
                if (m.TypeName == name)
                    return m;
            }
            throw new ArgumentNullException("Материал не существует");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = GetMachineryTypeByName(comboBox_MachineryType.SelectedItem.ToString());
            this.DialogResult = true;
            this.Close();
        }
    }
}
