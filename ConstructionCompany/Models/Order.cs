using System;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace ConstructionCompany.Models
{
    public class Order : INotifyPropertyChanged
    {
        private string note, objectAddress;
        private int price;
        private DateTime startDate, endDate;
        private ObservableCollection<Brigade> brigadesCollection;
        private ObservableCollection<Work> worksCollection;
        public long Id { get; set; }

        public ObservableCollection<Brigade> BrigadesCollection
        {
            get { return brigadesCollection; }
            set { brigadesCollection = value; OnPropertyChanged("BrigadesCollection"); }
        }

        public ObservableCollection<Work> WorksCollection
        {
            get { return worksCollection; }
            set { worksCollection = value; OnPropertyChanged("WorksCollection"); }
        }

        public string ObjectAddress
        {
            get { return objectAddress; }
            set { objectAddress = value; OnPropertyChanged("ObjectAddress"); }
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

        public int Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
        }

        public string Note
        {
            get { return note; }
            set { note = value; OnPropertyChanged("Note"); }
        }

        public DateTime EndDateTime { get { return endDate; } }

        public DateTime StartDateTime { get { return startDate; } }

        public Order()
        {
            this.ObjectAddress = "";
            this.StartDate = DateTime.Now.ToString("yyyy-MM-dd");
            this.EndDate = DateTime.Now.ToString("yyyy-MM-dd");
            this.Price = 0;
            this.Note = "";
            this.BrigadesCollection = new ObservableCollection<Brigade>();
            this.WorksCollection = new ObservableCollection<Work>();
        }

       public Order(long id, string objectAddress, DateTime startDate, DateTime endDate, int price, string note)
        {
            this.Id = id;
            this.ObjectAddress = objectAddress;
            this.StartDate = startDate.ToString("yyyy-MM-dd");
            this.EndDate = endDate.ToString("yyyy-MM-dd");
            this.Price = price;
            this.Note = note;
            this.BrigadesCollection = new ObservableCollection<Brigade>();
            this.WorksCollection = new ObservableCollection<Work>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
