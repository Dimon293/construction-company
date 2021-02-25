using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ConstructionCompany.Models
{
    public class Brigade : INotifyPropertyChanged
    {
        private string name, brigadierName, workName;
        private ObservableCollection<Order> ordersCollection;

        public long Id { get; set; }

        public ObservableCollection<Order> OrdersCollection
        {
            get { return ordersCollection; }
            set { ordersCollection = value; OnPropertyChanged("OrdersCollection"); }
        }

        //public long Brigadier
        //{
        //    get { return brigadier; }
        //    set
        //    {
        //        brigadier = value;
        //        for (int i = 0; i < DataModel.Workers.Count; i++)
        //        {
        //            if (DataModel.Workers[i].Id == brigadier)
        //                brigadierName = DataModel.Workers[i].LName;
        //        }
        //        OnPropertyChanged("Brigadier");
        //    }
        //}

        public string BrigadierName
        {
            get { return brigadierName; }
            set { brigadierName = value; OnPropertyChanged("BrigadierName"); }
        }

        public string WorkName
        {
            get { return workName; }
            set { workName = value; OnPropertyChanged("WorkName"); }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }


        public Brigade()
        {
            this.Name = "";
            this.BrigadierName = "";
            this.WorkName = "";
            OrdersCollection = new ObservableCollection<Order>();
        }

        public Brigade(long id, string name, string brigadierName, string workName)
        {
            this.Id = id;
            this.Name = name;
            this.BrigadierName = brigadierName;
            this.WorkName = workName;
            OrdersCollection = new ObservableCollection<Order>();
        }
        
        public bool IsActive
        {
            get
            {
                if (OrdersCollection.Count != 0)
                {
                    foreach(Order o in OrdersCollection)
                    {
                        if(o.EndDateTime.CompareTo(DateTime.Now) >= 0 && o.StartDateTime.CompareTo(DateTime.Now) <= 0) return true;
                    }
                }
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        //public int GetOrderBrigadeCount()
        //{
        //    int count = 0;
        //    foreach (Order o in DataModel.Orders)
        //    {
        //        foreach (Brigade b in o.BrigadesCollection)
        //        {
        //            if (b == this)
        //                count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
