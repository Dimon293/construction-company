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
    class MachineryUsingDataAdapter : DataAdapter
    {
        private ObservableCollection<MachineryUsing> MachineryUsing;
        public MachineryUsingDataAdapter(MySqlConnection connection, ObservableCollection<MachineryUsing> machineryUsing) : base(connection)
        {
            MachineryUsing = machineryUsing;
        }
        private void MachineryUsing_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as MachineryUsing);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as MachineryUsing);
                    break;
            }
        }
        private void MachineryUsing_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MachineryName" || e.PropertyName == "IdOrder" || e.PropertyName == "IdBrigade" || e.PropertyName == "StartDate" || e.PropertyName == "EndDate") this.Update(sender as MachineryUsing);
        }


        public void Fill()
        {
            MachineryUsing.CollectionChanged -= MachineryUsing_CollectionChanged;
            
            List<Dictionary<string, string>> allMachineryUsing = GetQueryResult("select mu.Id, m.Name, ob.IdOrder, ob.IdBrigade, mu.StartDate, mu.EndDate from MachineryUsing mu left join Machinery m on mu.IdMachinery=m.Id left join OrderBrigade ob on mu.IdOrderBrigade=ob.Id;");


            foreach (Dictionary<string, string> a in allMachineryUsing)
            {
                MachineryUsing na = new MachineryUsing(long.Parse(a["Id"]), a["Name"], long.Parse(a["IdOrder"]), long.Parse(a["IdBrigade"]), Convert.ToDateTime(a["StartDate"]), Convert.ToDateTime(a["EndDate"]));

                na.PropertyChanged += MachineryUsing_PropertyChanged;

                MachineryUsing.Add(na);
            }

            MachineryUsing.CollectionChanged += MachineryUsing_CollectionChanged;
        }

        public void Add(MachineryUsing machineryUsing)
        {
            machineryUsing.PropertyChanged += MachineryUsing_PropertyChanged;
            machineryUsing.Id = InsertRow($"insert into MachineryUsing (IdMachinery, IdOrderBrigade, StartDate, EndDate) values ('{GetMachineryId(machineryUsing.MachineryName)}', '{GetIdOrderBrigade(machineryUsing.IdOrder, machineryUsing.IdBrigade)}', '{machineryUsing.StartDate}', '{machineryUsing.EndDate}');");
        }

        public void Delete(MachineryUsing machineryUsing)
        {
            Execute($"delete from MachineryUsing where Id={machineryUsing.Id}");
        }

        public void Update(MachineryUsing machineryUsing)
        {
            Execute($"update MachineryUsing set IdMachinery='{GetMachineryId(machineryUsing.MachineryName)}', IdOrderBrigade='{GetIdOrderBrigade(machineryUsing.IdOrder, machineryUsing.IdBrigade)}', StartDate='{machineryUsing.StartDate}', EndDate='{machineryUsing.EndDate}' where Id={machineryUsing.Id};");

        }

        private long GetIdBrigade(string name)
        {
            foreach (Brigade b in DataModel.Brigades)
            {
                if (name == b.Name)
                    return b.Id;
            }
            return 0;
        }

        private long GetIdOrderBrigade(long idOrder, long idBrigade)
        {
            foreach (OrderBrigade ob in DataModel.OrderBrigades)
            {
                if (idOrder == ob.IdOrder && idBrigade == ob.IdBrigade)
                    return ob.Id;
            }
            return 0;
        }

        private long GetMachineryId(string name)
        {
            foreach (Machinery machinery in DataModel.Machinery)
            {
                if (machinery.Name == name)
                    return machinery.Id;
            }
            return 0;
        }
    }
}