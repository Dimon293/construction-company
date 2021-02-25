using System;
using System.Windows;
using ConstructionCompany.Models;
using ConstructionCompany.ViewModels;
using System.Collections.ObjectModel;
using ConstructionCompany.ExpertPart;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для OrderBrigade.xaml
    /// </summary>
    public partial class MaterialUsingW : Window
    {
        public MaterialUsingW()
        {
            InitializeComponent();
        }
        
        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            AddMaterialUsing AMU = new AddMaterialUsing();
            AMU.DataContext = new MaterialUsing();
            AMU.Owner = this;
            AMU.ShowDialog();
            if (AMU.DataContext != null && AMU.DialogResult == true)
            {
                MaterialUsing mu = AMU.DataContext as MaterialUsing;
                mu.IdBrigade = (BrigadesInOrderDG.SelectedItem as BrigadeMaterials).Brigade.Id;
                mu.IdOrder = (this.DataContext as MaterialsInBrigadesByOrderViewModel).Order.Id;
                DataModel.MaterialsUsing.Add(mu);
                BrigadeMaterials bm = FindBrigadeMaterials((this.DataContext as MaterialsInBrigadesByOrderViewModel).BrigadeMaterialsCollection, (BrigadesInOrderDG.SelectedItem as BrigadeMaterials).Brigade);
                bm.MaterialsCountCollection.Add(new MaterialCountVM(FindMaterialByName(mu.MaterialName), mu.Count));
            }
        }

        BrigadeMaterials FindBrigadeMaterials(ObservableCollection<BrigadeMaterials> brigadeMaterials, Brigade brigade)
        {
            foreach(BrigadeMaterials bm in brigadeMaterials)
            {
                if (bm.Brigade.Id == brigade.Id)
                    return bm;
            }
            throw new ArgumentNullException("Бригада с материалами не найдена");
        }

        Material FindMaterialByName(string name)
        {
            foreach (Material m in DataModel.Materials)
            {
                if (m.Name == name)
                {
                    return m;
                }
            }
            throw new ArgumentNullException("Данный материал не существует");
        }

        private OrderWork GetWorksInOrder(int idOrder, int idWork)
        {
            foreach (OrderWork ow in DataModel.OrderWorks)
            {
                if (ow.IdOrder == idOrder && ow.IdWork == idWork)
                    return ow;
            }
            return null;
        }

        private void button_ExpertClass_Click(object sender, RoutedEventArgs e)
        {
            RuleMaterialW ruleMaterialW = new RuleMaterialW();
            ruleMaterialW.Owner = this;
            ExpertMaterialCountViewModel evm = new ExpertMaterialCountViewModel();
            //заполняется evm (VM для окна RuleMaterial) с пом. ExpCl
            foreach (BrigadeMaterials b in (this.DataContext as MaterialsInBrigadesByOrderViewModel).BrigadeMaterialsCollection)
            {
                ExpertClass ec = new ExpertClass(GetWorkByName(b.WorkName), GetBrigadesInOrder((int)(this.DataContext as MaterialsInBrigadesByOrderViewModel).Order.Id, (int)b.Brigade.Id).Area);
                evm.AddWorkWithMaterialCount((this.DataContext as MaterialsInBrigadesByOrderViewModel).Order, GetWorkByName(b.WorkName), b.Brigade, ec.GetMaterialCount());
            }

            ruleMaterialW.DataContext = evm;
            ruleMaterialW.ShowDialog();


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
        private OrderBrigade GetBrigadesInOrder(int idOrder, int idBrigade)
        {
            foreach (OrderBrigade ob in DataModel.OrderBrigades)
            {
                if (ob.IdOrder == idOrder && ob.IdBrigade == idBrigade)
                    return ob;
            }
            return null;
        }
    }
}
