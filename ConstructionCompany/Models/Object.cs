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
    public class Object : INotifyPropertyChanged
    {

        private string address, objectTypeName, customerName;
        private int area;
        
        public long Id { get; set; }
        
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; OnPropertyChanged("CustomerName"); }
        }
        
        public string ObjectTypeName
        {
            get { return objectTypeName; }
            set { objectTypeName = value; OnPropertyChanged("ObjectTypeName"); }
        }
        
        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged("Address"); }
        }

        public int Area
        {
            get { return area; }
            set { area = value; OnPropertyChanged("Area"); }
        }

        public Object()
        {
            this.Address = "";
            this.Area = 0;
            this.ObjectTypeName = "";
            this.CustomerName = "";
        }

        public Object(long id, string address, int area, string objectTypeName, string customerName)
        {
            this.Id = id;
            this.Address = address;
            this.Area = area;
            this.ObjectTypeName = objectTypeName;
            this.CustomerName = customerName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
