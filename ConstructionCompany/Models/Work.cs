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
    public class Work : INotifyPropertyChanged
    {
        private string workName, workTypeName;
        private int tariff;

        private ObservableCollection<Order> ordersCollection;
        public long Id { get; set; }
        public ObservableCollection<Order> OrdersCollection
        {
            get { return ordersCollection; }
            set { ordersCollection = value; OnPropertyChanged("OrdersCollection"); }
        }

        public string WorkTypeName
        {
            get { return workTypeName; }
            set { workTypeName = value; OnPropertyChanged("WorkTypeName"); }
        }
        public string WorkName
        {
            get { return workName; }
            set { workName = value; OnPropertyChanged("WorkName"); }
        }
        public int Tariff
        {
            get { return tariff; }
            set { tariff = value; OnPropertyChanged("Tariff"); }
        }

        public Work()
        {
            this.WorkTypeName = "";
            this.WorkName = "";
            this.Tariff = 0;
            OrdersCollection = new ObservableCollection<Order>();
        }
        public Work(long id, string workTypeName, string workName, int tariff)
        {
            this.Id = id;
            this.WorkTypeName = workTypeName;
            this.WorkName = workName;
            this.Tariff = tariff;
            OrdersCollection = new ObservableCollection<Order>();
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
