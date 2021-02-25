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
using ConstructionCompany.ViewModels;
using ConstructionCompany.Models;
using ConstructionCompany.ExpertPart;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для MachineryUsingW.xaml
    /// </summary>
    public partial class MachineryUsingW : Window
    {
        public MachineryUsingW()
        {
            InitializeComponent();
        }

        class Date
        {
            public string StartDate { get; set; }
            public string EndDate { get; set; }

            public Date()
            {
                StartDate = DateTime.Now.ToString("yyyy-MM-dd");
                EndDate = DateTime.Now.ToString("yyyy-MM-dd");
            }
            public DateTime GetStartDateOrderById(int id)
            {
                foreach (Order o in DataModel.Orders)
                {
                    if (id == o.Id)
                        return Convert.ToDateTime(o.StartDate);
                }
                throw new ArgumentNullException();
            }
            public DateTime GetEndDateOrderById(int id)
            {
                foreach (Order o in DataModel.Orders)
                {
                    if (id == o.Id)
                        return Convert.ToDateTime(o.EndDate);
                }
                throw new ArgumentNullException();
            }
        }

        private void AddMachineryInOrderBrigade_Click(object sender, RoutedEventArgs e)
        {
            Date d = new Date();
            if (MachineryLeftDG.SelectedItem != null)
            {
                AddDateMU AW = new AddDateMU();

                AW.DataContext = d;
                AW.Owner = this;
                AW.ShowDialog();

                if (AW.DialogResult == true)
                {
                    DataModel.MachineryUsing.Add(new MachineryUsing(DataModel.Machinery.Count, (MachineryLeftDG.SelectedItem as Machinery).Name, (this.DataContext as MachineryInBrigadesByOrderViewModel).Order.Id, (BrigadesDG.SelectedItem as BrigadeMachinery).Brigade.Id, Convert.ToDateTime((AW.DataContext as Date).StartDate), Convert.ToDateTime((AW.DataContext as Date).EndDate)));

                    (BrigadesDG.SelectedItem as BrigadeMachinery).MachineryUsingCollection.Add(MachineryLeftDG.SelectedItem as Machinery);

                    (this.DataContext as MachineryInBrigadesByOrderViewModel).MachineryCollection.Remove(MachineryLeftDG.SelectedItem as Machinery);
                }
            }
        }

        private void DelMachineryFromOrderBrigade_Click(object sender, RoutedEventArgs e)
        {
            DataModel.MachineryUsing.Remove(GetMachineryUsing((MachineryDG.SelectedItem as Machinery).Name, (this.DataContext as MachineryInBrigadesByOrderViewModel).Order.Id, (BrigadesDG.SelectedItem as BrigadeMachinery).Brigade.Id));

            (this.DataContext as MachineryInBrigadesByOrderViewModel).MachineryCollection.Add(MachineryDG.SelectedItem as Machinery);

            (BrigadesDG.SelectedItem as BrigadeMachinery).MachineryUsingCollection.Remove(MachineryDG.SelectedItem as Machinery);
        }

        MachineryUsing GetMachineryUsing(string machineryName, long idOrder, long idBrigade)
        {
            foreach(MachineryUsing mu in DataModel.MachineryUsing)
            {
                if (mu.MachineryName == machineryName && mu.IdOrder == idOrder && mu.IdBrigade == idBrigade)
                    return mu;
            }
            return null;
        }

        private void button_ExpertClass_Click(object sender, RoutedEventArgs e)
        {
            RuleMachineryW ruleMachineryW = new RuleMachineryW();
            ruleMachineryW.Owner = this;
            ExpertMachineryViewModel evm = new ExpertMachineryViewModel();
            foreach (BrigadeMachinery bm in (this.DataContext as MachineryInBrigadesByOrderViewModel).BrigadeMachineryCollection)
            {
                ExpertClass ec = new ExpertClass(GetWorkByName(bm.WorkName), GetBrigadesInOrder((int)(this.DataContext as MachineryInBrigadesByOrderViewModel).Order.Id, (int)bm.Brigade.Id).Area);
                evm.AddWorkWithMachinery((this.DataContext as MachineryInBrigadesByOrderViewModel).Order, GetWorkByName(bm.WorkName), bm.Brigade, ec.GetMachinery());
            }
            ruleMachineryW.DataContext = evm;
            ruleMachineryW.ShowDialog();
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
