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
    public class Material : INotifyPropertyChanged
    {
        private string name, unitOfMeasurement;
        private int area, price;

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
        public string UnitOfMeasurement
        {
            get { return unitOfMeasurement; }
            set { unitOfMeasurement = value; OnPropertyChanged("UnitOfMeasurement"); }
        }
        public int Area
        {
            get { return area; }
            set { area = value; OnPropertyChanged("Area"); }
        }
        public int Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
        }

        public Material()
        {
            this.Name = "";
            this.UnitOfMeasurement = "";
            this.Area = 0;
            this.Price = 0;
            this.OrderBrigadesCollection = new ObservableCollection<OrderBrigade>();
        }

        public Material(long id, string name, string unitOfMeasurement, int area, int price)
        {
            this.Id = id;
            this.Name = name;
            this.UnitOfMeasurement = unitOfMeasurement;
            this.Area = area;
            this.Price = price;
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
