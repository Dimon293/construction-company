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
    class ObjectTypeDataAdapter : DataAdapter
    {
        private ObservableCollection<ObjectType> ObjectTypes;
        public ObjectTypeDataAdapter(MySqlConnection connection, ObservableCollection<ObjectType> objectTypes) : base(connection)
        {
            ObjectTypes = objectTypes;
        }
        private void ObjectTypes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as ObjectType);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as ObjectType);
                    break;
            }
        }
        private void ObjectType_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "TypeName") this.Update(sender as ObjectType);
        }

        public void Fill()
        {
            ObjectTypes.CollectionChanged -= ObjectTypes_CollectionChanged;

            List<Dictionary<string, string>> allObjectTypes = GetQueryResult("select Id, TypeName from ObjectType;");


            foreach (Dictionary<string, string> a in allObjectTypes)
            {
                ObjectType na = new ObjectType(long.Parse(a["Id"]), a["TypeName"]);

                na.PropertyChanged += ObjectType_PropertyChanged;

                ObjectTypes.Add(na);
            }

            ObjectTypes.CollectionChanged += ObjectTypes_CollectionChanged;
        }

        public void Add(ObjectType objectType)
        {
            objectType.PropertyChanged += ObjectType_PropertyChanged;
            objectType.Id = InsertRow($"insert into ObjectType (TypeName) values ('{objectType.TypeName}');");
        }

        public void Delete(ObjectType objectType)
        {
            Execute($"delete from ObjectType where Id={objectType.Id}");
        }

        public void Update(ObjectType objectType)
        {
            Execute($"update ObjectType set TypeName='{objectType.TypeName}' where Id={objectType.Id};;");
        }
    }
}