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
    public class MachineryUsing : INotifyPropertyChanged
    {
        private long idOrderBrigade, idOrder, idBrigade;
        private string machineryName, brigadeName, machineryTypeName;
        private DateTime startDate, endDate;

        public long Id { get; set; }

        public long IdOrder
        {
            get { return idOrder; }
            set { idOrder = value; OnPropertyChanged("IdOrder"); }
        }

        public string BrigadeName
        {
            get
            {
                foreach (Brigade b in DataModel.Brigades)
                {
                    if (b.Id == this.IdBrigade) return b.Name;
                }
                return null;
            }
        }

        public string MachineryTypeName
        {
            get
            {
                foreach(Machinery m in DataModel.Machinery)
                {
                    if (this.MachineryName == m.Name)
                        return m.MachineryTypeName;
                }
                return null;
            }
            set { machineryTypeName = value; OnPropertyChanged("MachineryTypeName"); }
        }

        public long IdBrigade
        {
            get { return idBrigade; }
            set { idBrigade = value; OnPropertyChanged("IdBrigade"); }
        }
        
        public string MachineryName
        {
            get { return machineryName; }
            set { machineryName = value; OnPropertyChanged("MachineryName"); }
        }

        public string StartDate
        {
            get { return startDate.ToString("yyyy-MM-dd"); }
            set
            {
                startDate = Convert.ToDateTime(value);
                OnPropertyChanged("StartDate");
            }
        }

        public string EndDate
        {
            get { return endDate.ToString("yyyy-MM-dd"); }
            set
            {
                endDate = Convert.ToDateTime(value);
                OnPropertyChanged("EndDate");
            }
        }

        public string GetStartDateOrderById(int id)
        {
            foreach(Order o in DataModel.Orders)
            {
                if (id == o.Id)
                    return o.StartDate;
            }
            return null;
        }
        public string GetEndDateOrderById(int id)
        {
            foreach (Order o in DataModel.Orders)
            {
                if (id == o.Id)
                    return o.EndDate;
            }
            return null;
        }

        public DateTime EndDateTime { get { return endDate; } }

        public DateTime StartDateTime { get { return startDate; } }

        public MachineryUsing()
        {
            this.MachineryName = "";
            this.IdOrder = 1;
            this.IdBrigade = 0;
            this.StartDate = GetStartDateOrderById((int)IdOrder);
            this.EndDate = GetEndDateOrderById((int)IdOrder);
        }

        public MachineryUsing(long id, string machineryName, long idOrder, long idBrigade, DateTime startDate, DateTime endDate)
        {
            this.Id = id;
            this.MachineryName = machineryName;
            this.IdOrder = idOrder;
            this.IdBrigade = idBrigade;
            this.StartDate = startDate.ToString("yyyy-MM-dd");
            this.EndDate = endDate.ToString("yyyy-MM-dd");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

