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
using ConstructionCompany.ExpertPart;
using ConstructionCompany.Models;
using ConstructionCompany.ViewModels;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для RulesW.xaml
    /// </summary>
    public partial class RulesW : Window
    {
        public RulesW()
        {
            InitializeComponent();
            Loaded += RulesW_Loaded;
        }

        private void RulesW_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new RulesWorksViewModel();

        }

        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            if(WorksDG.SelectedItem != null)
            {
                AddMaterialInRule AMIR = new AddMaterialInRule((WorksDG.SelectedItem as WorkWithMaterialAndMachinery).MaterialsCollection);
                AMIR.DataContext = new Material();
                AMIR.Owner = this;
                AMIR.ShowDialog();
                if (AMIR.DialogResult == true)
                {
                    (WorksDG.SelectedItem as WorkWithMaterialAndMachinery).MaterialsCollection.Add(AMIR.DataContext as Material);
                    DataModel.Rules.Add(new Rule(DataModel.Rules.Count, (WorksDG.SelectedItem as WorkWithMaterialAndMachinery).WorkName, "Материал", (int)(AMIR.DataContext as Material).Id));
                }
            }
        }

        private void DeleteMaterial_Click(object sender, RoutedEventArgs e)
        {
            if (WorksDG.SelectedItem != null)
            {
                DataModel.Rules.Remove(FindRule((WorksDG.SelectedItem as WorkWithMaterialAndMachinery).WorkName, "Материал", (int)(MaterialsCountDG.SelectedItem as Material).Id));
                (WorksDG.SelectedItem as WorkWithMaterialAndMachinery).MaterialsCollection.Remove((MaterialsCountDG.SelectedItem as Material));
            }
        }

        private void AddMachinery_Click(object sender, RoutedEventArgs e)
        {
            if (WorksDG.SelectedItem != null)
            {
                AddMachineryInRule AMIR = new AddMachineryInRule((WorksDG.SelectedItem as WorkWithMaterialAndMachinery).MachineryTypeCollection);
                AMIR.DataContext = new MachineryType();
                AMIR.Owner = this;
                AMIR.ShowDialog();
                if (AMIR.DialogResult == true)
                {
                    (WorksDG.SelectedItem as WorkWithMaterialAndMachinery).MachineryTypeCollection.Add(AMIR.DataContext as MachineryType);
                    DataModel.Rules.Add(new Rule(DataModel.Rules.Count, (WorksDG.SelectedItem as WorkWithMaterialAndMachinery).WorkName, "Техника", (int)(AMIR.DataContext as MachineryType).Id));
                }
            }
        }

        private void DeleteMachinery_Click(object sender, RoutedEventArgs e)
        {
            if (WorksDG.SelectedItem != null)
            {
                DataModel.Rules.Remove(FindRule((WorksDG.SelectedItem as WorkWithMaterialAndMachinery).WorkName, "Техника", (int)(MachineryDG.SelectedItem as MachineryType).Id));
                (WorksDG.SelectedItem as WorkWithMaterialAndMachinery).MachineryTypeCollection.Remove((MachineryDG.SelectedItem as MachineryType));
            }
        }

        

        Work GetWorkByName(string name)
        {
            foreach (Work w in DataModel.Works)
            {
                if (w.WorkName == name)
                    return w;
            }
            throw new ArgumentNullException("Вид работы не существует");
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

        Rule FindRule(string workName, string attributeName, int attributeValue)
        {
            foreach (Rule r in DataModel.Rules)
            {
                if (r.WorkName == workName && r.AttributeName == attributeName && r.AttributeValue == attributeValue)
                    return r;
            }
            throw new ArgumentNullException("Правило не существует");
        }
    }
}
