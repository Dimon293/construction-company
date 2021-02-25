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

namespace ConstructionCompany.DataAdapters
{
    class MachineryDataAdapter : DataAdapter
    {
        private ObservableCollection<Machinery> Machinery;
        public MachineryDataAdapter(MySqlConnection connection, ObservableCollection<Machinery> machinery) : base(connection)
        {
            Machinery = machinery;
        }
        private void Machinery_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Machinery);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Machinery);
                    break;
            }
        }
        private void Machinery_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MachineryTypeName" || e.PropertyName == "Name") this.Update(sender as Machinery);
        }

        public void Fill()
        {
            Machinery.CollectionChanged -= Machinery_CollectionChanged;

            List<Dictionary<string, string>> allMachinery = GetQueryResult("select m.Id, mt.TypeName, m.Name from Machinery m left join MachineryType mt on m.IdMachineryType=mt.Id;");


            foreach (Dictionary<string, string> a in allMachinery)
            {
                Machinery na = new Machinery(long.Parse(a["Id"]), a["Name"], a["TypeName"]);

                na.PropertyChanged += Machinery_PropertyChanged;

                Machinery.Add(na);
            }

            Machinery.CollectionChanged += Machinery_CollectionChanged;
        }

        public void Add(Machinery machinery)
        {
            machinery.PropertyChanged += Machinery_PropertyChanged;
            machinery.Id = InsertRow($"insert into Machinery (IdMachineryType, Name) values ('{GetMachineryTypeId(machinery.MachineryTypeName)}', '{machinery.Name}');");
        }

        public void Delete(Machinery machinery)
        {
            Execute($"delete from Machinery where Id={machinery.Id}");
        }

        public void Update(Machinery machinery)
        {
            Execute($"update Machinery set IdMachineryType='{GetMachineryTypeId(machinery.MachineryTypeName)}', Name='{machinery.Name}' where Id={machinery.Id};");
        }

        private long GetMachineryTypeId(string name)
        {
            foreach (MachineryType t in DataModel.MachineryTypes)
            {
                if (t.TypeName == name)
                    return t.Id;
            }
            return 0;
        }
    }
}