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
    class WorkTypeDataAdapter : DataAdapter
    {
        private ObservableCollection<WorkType> WorkTypes;
        public WorkTypeDataAdapter(MySqlConnection connection, ObservableCollection<WorkType> workTypes) : base(connection)
        {
            WorkTypes = workTypes;
        }
        private void WorkTypes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as WorkType);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as WorkType);
                    break;
            }
        }
        private void WorkType_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "TypeName" || e.PropertyName == "Note") this.Update(sender as WorkType);
        }

        public void Fill()
        {
            WorkTypes.CollectionChanged -= WorkTypes_CollectionChanged;

            List<Dictionary<string, string>> allWorkTypes = GetQueryResult("select Id, TypeName, Note from WorkType;");


            foreach (Dictionary<string, string> a in allWorkTypes)
            {
                WorkType na = new WorkType(long.Parse(a["Id"]), a["TypeName"], a["Note"]);

                na.PropertyChanged += WorkType_PropertyChanged;

                WorkTypes.Add(na);
            }

            WorkTypes.CollectionChanged += WorkTypes_CollectionChanged;
        }

        public void Add(WorkType workType)
        {
            workType.PropertyChanged += WorkType_PropertyChanged;
            workType.Id = InsertRow($"insert into WorkType (TypeName, Note) values ('{workType.TypeName}', '{workType.Note}');");
        }

        public void Delete(WorkType workType)
        {
            Execute($"delete from WorkType where Id={workType.Id}");
        }

        public void Update(WorkType workType)
        {
            Execute($"update WorkType set TypeName='{workType.TypeName}', Note='{workType.Note}' where Id={workType.Id};");
        }
    }
}