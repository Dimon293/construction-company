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
    class MachineryTypeDataAdapter : DataAdapter
    {
        private ObservableCollection<MachineryType> MachineryTypes;
        public MachineryTypeDataAdapter(MySqlConnection connection, ObservableCollection<MachineryType> machineryTypes) : base(connection)
        {
            MachineryTypes = machineryTypes;
        }
        private void MachineryTypes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as MachineryType);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as MachineryType);
                    break;
            }
        }
        private void MachineryType_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "TypeName") this.Update(sender as MachineryType);
        }

        public void Fill()
        {
            MachineryTypes.CollectionChanged -= MachineryTypes_CollectionChanged;

            List<Dictionary<string, string>> allMachineryTypes = GetQueryResult("select Id, TypeName from MachineryType;");


            foreach (Dictionary<string, string> a in allMachineryTypes)
            {
                MachineryType na = new MachineryType(long.Parse(a["Id"]), a["TypeName"]);

                na.PropertyChanged += MachineryType_PropertyChanged;

                MachineryTypes.Add(na);
            }

            MachineryTypes.CollectionChanged += MachineryTypes_CollectionChanged;
        }

        public void Add(MachineryType machineryType)
        {
            machineryType.PropertyChanged += MachineryType_PropertyChanged;
            machineryType.Id = InsertRow($"insert into MachineryType (TypeName) values ('{machineryType.TypeName}');");
        }

        public void Delete(MachineryType machineryType)
        {
            Execute($"delete from MachineryType where Id={machineryType.Id}");
        }

        public void Update(MachineryType machineryType)
        {
            Execute($"update MachineryType set TypeName='{machineryType.TypeName}' where Id={machineryType.Id};");
        }
    }
}