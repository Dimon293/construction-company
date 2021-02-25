using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ConstructionCompany.DataAdapters
{
    class BrigadeDataAdapter : DataAdapter
    {
        private ObservableCollection<Brigade> Brigades;
        public BrigadeDataAdapter(MySqlConnection connection, ObservableCollection<Brigade> brigades) : base(connection)
        {
            Brigades = brigades;
        }

        private void Brigades_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Brigade);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Brigade);
                    break;
            }
        }
        private void Brigade_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name" || e.PropertyName == "BrigadierName" || e.PropertyName == "WorkName") this.Update(sender as Brigade);
        }

        public void Fill()
        {
            Brigades.CollectionChanged -= Brigades_CollectionChanged;
            List<Dictionary<string, string>> allBrigades = GetQueryResult("select b.Id, b.Name, w.LastName, wo.WorkName from Brigade b left join Worker w on b.IdBrigadier=w.Id left join Work wo on b.IdWork=wo.Id;");
            foreach (Dictionary<string, string> a in allBrigades)
            {
                Brigade br = new Brigade(long.Parse(a["Id"]), a["Name"], a["LastName"], a["WorkName"]);
                br.PropertyChanged += Brigade_PropertyChanged;
                
                Brigades.Add(br);
            }
            Brigades.CollectionChanged += Brigades_CollectionChanged;
        }
        public void Add(Brigade brigade)
        {
            brigade.PropertyChanged += Brigade_PropertyChanged;
            brigade.Id = InsertRow($"insert into Brigade (Name, IdBrigadier, IdWork) values ('{brigade.Name}', '{GetBrigadierId(brigade.BrigadierName)}', '{GetWorkId(brigade.WorkName)}');");
        }
        public void Delete(Brigade brigade)
        {
            Execute($"delete from Brigade where Id={brigade.Id}");
        }
        public void Update(Brigade brigade)
        {
            Execute($"update Brigade set Name='{brigade.Name}', IdBrigadier='{GetBrigadierId(brigade.BrigadierName)}', IdWork='{GetWorkId(brigade.WorkName)}' where id={brigade.Id};");
        }
        private long GetBrigadierId(string name)
        {
            foreach (Worker w in DataModel.Workers)
            {
                if (w.LastName == name)
                    return w.Id;
            }
            return 0;
        }
        private long GetWorkId(string name)
        {
            foreach (Work w in DataModel.Works)
            {
                if (w.WorkName == name)
                    return w.Id;
            }
            return 0;
        }
    }
}
