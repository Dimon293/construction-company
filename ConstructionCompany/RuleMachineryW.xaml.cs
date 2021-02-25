using System;
using System.Windows;
using ConstructionCompany.ViewModels;
using ConstructionCompany.Models;
using ConstructionCompany.ExpertPart;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для RuleMachineryW.xaml
    /// </summary>
    public partial class RuleMachineryW : Window
    {
        public RuleMachineryW()
        {
            InitializeComponent();
        }

        private void button_Success_Click(object sender, RoutedEventArgs e)
        {
            int brigadeId, count;
            string machineryName, startDate, endDate;
            int orderId = (int)(Owner.DataContext as MachineryInBrigadesByOrderViewModel).Order.Id;

            foreach (BrigadeWithMachinery wwm in (this.DataContext as ExpertMachineryViewModel).WorkWithMachineryCollection)
            {
                foreach (Machinery m in wwm.MachineryCollection)
                {
                    count = DataModel.MachineryUsing.Count;
                    machineryName = m.Name;
                    brigadeId = (int)wwm.Brigade.Id;
                    startDate = (Owner.DataContext as MachineryInBrigadesByOrderViewModel).Order.StartDate;
                    endDate = (Owner.DataContext as MachineryInBrigadesByOrderViewModel).Order.EndDate;
                    
                    if (machineryName != null)
                        DataModel.MachineryUsing.Add(new MachineryUsing(count, machineryName, orderId, brigadeId, Convert.ToDateTime(startDate), Convert.ToDateTime(endDate)));
                }
            }
            this.Close(); 
        }
        
        private void button_AddMachinery_Click(object sender, RoutedEventArgs e)
        {
            AddMachineryUsing AMU = new AddMachineryUsing();
            AMU.DataContext = new MachineryUsing();
            AMU.ShowDialog();
            if (AMU.DialogResult == true && AMU.DataContext != null)
            {
                FindElement().MachineryCollection.Add(new Machinery((AMU.DataContext as MachineryUsing).MachineryName, (AMU.DataContext as MachineryUsing).MachineryTypeName));
            }
        }

        private void button_DelMachinery_Click(object sender, RoutedEventArgs e)
        {
            FindElement().MachineryCollection.Remove(MachineryDG.SelectedItem as Machinery);
        }

        BrigadeWithMachinery FindElement()
        {
            foreach (BrigadeWithMachinery wwm in (this.DataContext as ExpertMachineryViewModel).WorkWithMachineryCollection)
            {
                Brigade b = (WorksDG.SelectedItem as BrigadeWithMachinery).Brigade;
                Work w = (WorksDG.SelectedItem as BrigadeWithMachinery).Work;
                if (wwm.Brigade.Name == b.Name && wwm.Work.WorkName == w.WorkName)
                {
                    return wwm;
                }
            }
            return null;
        }
    }
}
