using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ConstructionCompany.Models
{
    public class OrderBrigade : INotifyPropertyChanged
    {
        private long idOrder, idBrigade;
        private int area;

        private ObservableCollection<Material> materialsCollection;
        private ObservableCollection<Machinery> machineryCollection;

        public long Id { get; set; }

        public ObservableCollection<Material> MaterialsCollection
        {
            get { return materialsCollection; }
            set { materialsCollection = value; OnPropertyChanged("MaterialsCollection"); }
        }

        public ObservableCollection<Machinery> MachineryCollection
        {
            get { return machineryCollection; }
            set { machineryCollection = value; OnPropertyChanged("MachineryCollection"); }
        }

        public long IdOrder
        {
            get { return idOrder; }
            set { idOrder = value; OnPropertyChanged("IdOrder"); }
        }
        public long IdBrigade
        {
            get { return idBrigade; }
            set { idBrigade = value; OnPropertyChanged("IdBrigade"); }
        }
        public int Area
        {
            get { return area; }
            set { area = value; OnPropertyChanged("Area"); }
        }
        public OrderBrigade()
        {
            this.IdOrder = 1;
            this.IdBrigade = 1;
            this.Area = 0;
            MaterialsCollection = new ObservableCollection<Material>();
            MachineryCollection = new ObservableCollection<Machinery>();

        }
        public OrderBrigade(long id, long idOrder, long idBrigade)
        {
            this.Id = id;
            this.IdOrder = idOrder;
            this.IdBrigade = idBrigade;
            MaterialsCollection = new ObservableCollection<Material>();
            MachineryCollection = new ObservableCollection<Machinery>();
        }
        public OrderBrigade(long id, long idOrder, long idBrigade, int area)
        {
            this.Id = id;
            this.IdOrder = idOrder;
            this.IdBrigade = idBrigade;
            this.Area = area;
            MaterialsCollection = new ObservableCollection<Material>();
            MachineryCollection = new ObservableCollection<Machinery>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
