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
    public class OrderWork : INotifyPropertyChanged
    {
        private long idOrder, idWork;
        
        public long Id { get; set; }
        
        public long IdOrder
        {
            get { return idOrder; }
            set { idOrder = value; OnPropertyChanged("IdOrder"); }
        }
        public long IdWork
        {
            get { return idWork; }
            set { idWork = value; OnPropertyChanged("IdWork"); }
        }
        public OrderWork()
        {
            this.IdOrder = 1;
            this.IdWork = 1;

        }
        public OrderWork(long id, long idOrder, long idWork)
        {
            this.Id = id;
            this.IdOrder = idOrder;
            this.IdWork = idWork;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
