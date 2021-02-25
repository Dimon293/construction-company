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
    public class Machinery : INotifyPropertyChanged
    {
        private string name, machineryTypeName;

        private ObservableCollection<OrderBrigade> orderBrigadesCollection;
        public long Id { get; set; }

        public ObservableCollection<OrderBrigade> OrderBrigadesCollection
        {
            get { return orderBrigadesCollection; }
            set { orderBrigadesCollection = value; OnPropertyChanged("OrderBrigadesCollection"); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public bool InUse
        {
            get
            {
                foreach (MachineryUsing mu in DataModel.MachineryUsing)
                {
                    if (this.Id == GetMachineryIdByName(mu.MachineryName) && mu.EndDate.CompareTo(DateTime.Now.ToString("yyyy-MM-dd")) > 0)
                        return true;
                }
                return false;
            }
        }

        long GetMachineryIdByName(string name)
        {
            foreach (Machinery m in DataModel.Machinery)
            {
                if (m.Name == name)
                    return m.Id;
            }
            return 0;
        }

        public string MachineryTypeName
        {
            get { return machineryTypeName; }
            set { machineryTypeName = value; OnPropertyChanged("MachineryTypeName"); }
        }

        public Machinery()
        {
            this.Name = "";
            this.MachineryTypeName = "";
            this.OrderBrigadesCollection = new ObservableCollection<OrderBrigade>();
        }

        public Machinery(string name, string machineryTypeName)
        {
            this.Name = name;
            this.MachineryTypeName = machineryTypeName;
            this.OrderBrigadesCollection = new ObservableCollection<OrderBrigade>();
        }

        public Machinery(long id, string name, string machineryTypeName)
        {
            this.Id = id;
            this.Name = name;
            this.MachineryTypeName = machineryTypeName;
            this.OrderBrigadesCollection = new ObservableCollection<OrderBrigade>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
