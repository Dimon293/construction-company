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
    /// Логика взаимодействия для OrderBrigadeWork.xaml
    /// </summary>
    public partial class OrderBrigadeWorkW : Window
    {
        public OrderBrigadeWorkW()
        {
            InitializeComponent();
        }

        class WorkArea
        {
            public double Area { get; set; }
            public WorkArea()
            {
                Area = 0;
            }
        }
        
        private void AddBrigadeInOrder_Click(object sender, RoutedEventArgs e)
        {
            WorkArea wa = new WorkArea();
            if (BrigadeLeftDG.SelectedItem != null)
            {
                AddAreaOB AW = new AddAreaOB();
                
                AW.DataContext = wa;
                AW.Owner = this;
                AW.ShowDialog();

                if (AW.DialogResult == true)
                {
                    //Добавление бригады в коллекцию бригады заказа
                    (this.DataContext as OrderBrigadeWorkViewModel).Order.BrigadesCollection.Add(BrigadeLeftDG.SelectedItem as Brigade);

                    //Добавление заказа в коллекцию заказов бригад
                    (BrigadeLeftDG.SelectedItem as Brigade).OrdersCollection.Add((this.DataContext as OrderBrigadeWorkViewModel).Order);

                    //Добавление связи заказ-бригада
                    DataModel.OrderBrigades.Add(new OrderBrigade(DataModel.OrderBrigades.Count, (int)(this.DataContext as OrderBrigadeWorkViewModel).Order.Id, (int)(BrigadeLeftDG.SelectedItem as Brigade).Id, (int)Math.Round((AW.DataContext as WorkArea).Area)));
                }
            }
        }

        private void DelBrigadeFromOrder_Click(object sender, RoutedEventArgs e)
        {
            //Удаление заказа из коллекции заказов бригады
            (BrigadeInOrderDG.SelectedItem as Brigade).OrdersCollection.Remove((this.DataContext as OrderBrigadeWorkViewModel).Order);

            //Удаление связи заказ-бригада
            DataModel.OrderBrigades.Remove(GetBrigadesInOrder((int)(this.DataContext as OrderBrigadeWorkViewModel).Order.Id, (int)(BrigadeInOrderDG.SelectedItem as Brigade).Id));

            //Удаление бригады из коллекции работ бригады
            (this.DataContext as OrderBrigadeWorkViewModel).Order.BrigadesCollection.Remove(BrigadeInOrderDG.SelectedItem as Brigade);
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

        private void button_ExpertClass_Click(object sender, RoutedEventArgs e)
        {
            RuleMaterialW ruleMaterialW = new RuleMaterialW();
            ruleMaterialW.Owner = this;
            ExpertMaterialCountViewModel evm = new ExpertMaterialCountViewModel();

            foreach (Brigade b in (this.DataContext as OrderBrigadeWorkViewModel).BrigadesCollection)
            {
                ExpertClass ec = new ExpertClass(GetWorkByName(b.WorkName), GetBrigadesInOrder((int)(this.DataContext as OrderBrigadeWorkViewModel).Order.Id, (int)b.Id).Area);
                evm.AddWorkWithMaterialCount((this.DataContext as OrderBrigadeWorkViewModel).Order, GetWorkByName(b.WorkName), b, ec.GetMaterialCount());
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
    }
}
