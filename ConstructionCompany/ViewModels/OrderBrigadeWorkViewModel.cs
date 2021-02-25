using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ConstructionCompany.ViewModels
{
    class OrderBrigadeWorkViewModel
    {
        public ObservableCollection<Brigade> BrigadesCollection { get; set; }
        public ObservableCollection<WorkWithBrigades> WorkWithBrigadesCollection { get; set; }
        public Order Order { get; set; }

        public OrderBrigadeWorkViewModel(Order order)
        {
            Order = order;
            BrigadesCollection = new ObservableCollection<Brigade>();
            FillBrigades(order);
            WorkWithBrigadesCollection = new ObservableCollection<WorkWithBrigades>();
            FillWorkWithBrigadesCollection();
            RemoveExcistingBrigades();
            order.BrigadesCollection.CollectionChanged += BrigadesCollection_CollectionChanged;
        }

        private void BrigadesCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            BrigadesCollection.Clear();
            FillBrigades(Order);
        }

        void FillBrigades(Order order)
        {
            foreach (Brigade b in order.BrigadesCollection)
            {
                BrigadesCollection.Add(b);
            }
        }
        void FillWorkWithBrigadesCollection()
        {
            foreach (Work w in DataModel.Works)
            {
                WorkWithBrigadesCollection.Add(new WorkWithBrigades(w));
            }
        }
        void RemoveExcistingBrigades()
        {
            foreach(WorkWithBrigades wwb in WorkWithBrigadesCollection)
            {
                foreach(Brigade b in wwb.BrigadesCollection.ToArray())
                {
                    foreach (Brigade br in BrigadesCollection)
                    {
                        if (b.Id == br.Id) wwb.BrigadesCollection.Remove(b);
                    }
                }
            }
        }
    }

    class WorkWithBrigades
    {
        public Work Work { get; set; }
        public string WorkName { get { return Work.WorkName; } }
        public int Tariff { get { return Work.Tariff; } }
        public ObservableCollection<Brigade> BrigadesCollection { get; set; }

        public WorkWithBrigades(Work work)
        {
            Work = work;
            BrigadesCollection = new ObservableCollection<Brigade>();
            FillBrigadesCollection();
        }
        
        void FillBrigadesCollection()
        {
            foreach(Brigade b in DataModel.Brigades)
            {
                if (b.WorkName == Work.WorkName) BrigadesCollection.Add(b);
            }
        }
    }
}
