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
    class WorkDataAdapter : DataAdapter
    {
        private ObservableCollection<Work> Works;
        public WorkDataAdapter(MySqlConnection connection, ObservableCollection<Work> works) : base(connection)
        {
            Works = works;
        }
        private void Works_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Work);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Work);
                    break;
            }
        }
        private void Work_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "WorkTypeName" || e.PropertyName == "WorkName" || e.PropertyName == "Tariff") this.Update(sender as Work);
        }

        public void Fill()
        {
            Works.CollectionChanged -= Works_CollectionChanged;

            List<Dictionary<string, string>> allWorks = GetQueryResult("select w.Id, wt.TypeName, w.WorkName, w.Tariff from Work w left join WorkType wt on w.IdWorkType=wt.Id;");

            foreach (Dictionary<string, string> a in allWorks)
            {
                Work na = new Work(long.Parse(a["Id"]), a["TypeName"], a["WorkName"], int.Parse(a["Tariff"]));

                na.PropertyChanged += Work_PropertyChanged;

                Works.Add(na);
            }

            Works.CollectionChanged += Works_CollectionChanged;
        }

        public void Add(Work work)
        {
            work.PropertyChanged += Work_PropertyChanged;
            work.Id = InsertRow($"insert into Work (IdWorkType, WorkName, Tariff) values ('{GetWorkTypekId(work.WorkTypeName)}', '{work.WorkName}', '{work.Tariff}');");
        }
        
        public void Delete(Work work)
        {
            Execute($"delete from Work where Id={work.Id}");
        }
        
        public void Update(Work work)
        {
            Execute($"update Work set IdWorkType='{GetWorkTypekId(work.WorkTypeName)}', WorkName='{work.WorkName}', Tariff='{work.Tariff}' where Id={work.Id};");
        }

        private long GetWorkTypekId(string name)
        {
            foreach (WorkType t in DataModel.WorkTypes)
            {
                if (t.TypeName == name)
                    return t.Id;
            }
            return 0;
        }
    }
}