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
using System.Collections.ObjectModel;
using ConstructionCompany.Models;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для AddMaterialInRule.xaml
    /// </summary>
    public partial class AddMaterialInRule : Window
    {
        private ObservableCollection<Material> ExistingMaterialsCollection { get; set; }
        public AddMaterialInRule(ObservableCollection<Material> existingMaterialsCollection)
        {
            this.ExistingMaterialsCollection = existingMaterialsCollection;
            InitializeComponent();
            Loaded += AddMaterialInRule_Loaded;
        }

        private void AddMaterialInRule_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(Material m in DataModel.Materials)
            {
                if (!IsExistInMaterialsCollection(m))
                    comboBox_Material.Items.Add(m.Name);
            }
        }

        bool IsExistInMaterialsCollection(Material m)
        {
            foreach (Material em in ExistingMaterialsCollection)
            {
                if (em.Id == m.Id)
                    return true;
            }
            return false;
        }

        Material GetMaterialByName(string name)
        {
            foreach (Material m in DataModel.Materials)
            {
                if (m.Name == name)
                    return m;
            }
            throw new ArgumentNullException("Материал не существует");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = GetMaterialByName(comboBox_Material.SelectedItem.ToString());
            this.DialogResult = true;
            this.Close();
        }
    }
}
