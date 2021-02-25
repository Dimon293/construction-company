using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ConstructionCompany.Models;
using System.Collections.Specialized;

namespace ConstructionCompany.ViewModels
{
    class MachineryInBrigadesByOrderViewModel
    {
        /// <summary>
        /// Коллекция для отображения бригад, учавствующих в заказе
        /// </summary>
        public ObservableCollection<BrigadeMachinery> BrigadeMachineryCollection { get; set; }
        /// <summary>
        /// Коллекция для отображения неиспользуемой техники
        /// </summary>
        public ObservableCollection<Machinery> MachineryCollection { get; set; }
        public Order Order { get; set; }

        public MachineryInBrigadesByOrderViewModel(Order order)
        {
            Order = order;
            BrigadeMachineryCollection = new ObservableCollection<BrigadeMachinery>();
            MachineryCollection = new ObservableCollection<Machinery>();
            FillBrigadeMachinery(order);
            FillMachineryCollection();
        }

        void FillBrigadeMachinery(Order order)
        {
            foreach (Brigade b in order.BrigadesCollection)
            {
                BrigadeMachineryCollection.Add(new BrigadeMachinery(b));
            }
        }

        void FillMachineryCollection()
        {
            foreach(Machinery m in DataModel.Machinery)
            {
                if (!m.InUse)
                    MachineryCollection.Add(m);
            }
        }
    }
    class BrigadeMachinery
    {
        public Brigade Brigade { get; set; }
        public Machinery Machinery { get; set; }
        /// <summary>
        /// Коллекция для отображения используемой бригадой техники
        /// </summary>
        public ObservableCollection<Machinery> MachineryUsingCollection { get; set; }

        public string BrigadeName { get { return Brigade.Name; } }
        public string WorkName { get { return Brigade.WorkName; } }

        public BrigadeMachinery(Brigade brigade)
        {
            Brigade = brigade;
            FillMachinery();
        }

       

        void FillMachinery()
        {
            MachineryUsingCollection = new ObservableCollection<Machinery>();

            foreach (MachineryUsing mu in DataModel.MachineryUsing)
            {
                if (mu.IdBrigade == Brigade.Id)
                {
                    MachineryUsingCollection.Add(FindMachineryByName(mu.MachineryName));

                }
            }
        }
        Machinery FindMachineryByName(string name)
        {
            foreach (Machinery m in DataModel.Machinery)
            {
                if (m.Name == name)
                {
                    return m;
                }
            }
            throw new ArgumentNullException("Данный вид техники не существует");
        }
    }
}
