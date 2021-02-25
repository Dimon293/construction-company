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
    public class MaterialUsing : INotifyPropertyChanged
    {
        private int count, price;
        private long idOrderBrigade, idOrder, idBrigade;
        private string materialName, brigadeName;
        private DateTime date;

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

        public long IdBrigade
        {
            get { return idBrigade; }
            set { idBrigade = value; OnPropertyChanged("IdBrigade"); }
        }

        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged("Count"); }
        }

        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; OnPropertyChanged("MaterialName"); }
        }

        public string Date
        {
            get { return date.ToString("yyyy-MM-dd"); }
            set
            {
                date = Convert.ToDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        public int Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
        }

        public int CountingPrice
        {
            get { return count*Material.Price; }
            set { }
        }

        public Material Material {
            get
            {
                foreach(Material m in DataModel.Materials)
                {
                    if (m.Name == this.MaterialName) return m;
                }
                return null;
            }
        }
        public MaterialUsing()
        {
            this.MaterialName = "Кирпич";
            this.IdOrder = 1;
            this.IdBrigade = 0;
            this.Count = 1;
            this.Date = DateTime.Now.ToString("yyyy-MM-dd");
            this.Price = 0;
        }

        public MaterialUsing(long id, string materialName, long idOrder, long idBrigade, int count, DateTime date, int price)
        {
            this.Id = id;
            this.MaterialName = materialName;
            this.IdOrder = idOrder;
            this.IdBrigade = idBrigade;
            this.Count = count;
            this.Date = date.ToString("yyyy-MM-dd");
            this.Price = price;
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
