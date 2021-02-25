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
    public class ObjectDataAdapter : DataAdapter
    {
        private ObservableCollection<Models.Object> Objects;
        public ObjectDataAdapter(MySqlConnection connection, ObservableCollection<Models.Object> objects) : base(connection)
        {
            Objects = objects;
        }

        private void Objects_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Models.Object);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Models.Object);
                    break;
            }
        }
        private void Object_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Address" || e.PropertyName == "Area" || e.PropertyName == "ObjectTypeName" || e.PropertyName == "CustomerName") this.Update(sender as Models.Object);
        }

        public void Fill()
        {
            Objects.CollectionChanged -= Objects_CollectionChanged;
            List<Dictionary<string, string>> allObjects = GetQueryResult("select o.Id, o.Address, o.Area, ot.TypeName, c.LastName from Object o left join ObjectType ot on o.IdObjectType=ot.Id left join Customer c on o.IdCustomer=c.Id;");
            foreach (Dictionary<string, string> a in allObjects)
            {
                Models.Object br = new Models.Object(long.Parse(a["Id"]), a["Address"], int.Parse(a["Area"]), a["TypeName"], a["LastName"]);
                br.PropertyChanged += Object_PropertyChanged;
                Objects.Add(br);
            }
            Objects.CollectionChanged += Objects_CollectionChanged;
        }
        public void Add(Models.Object @object)
        {
            @object.PropertyChanged += Object_PropertyChanged;
            @object.Id = InsertRow($"insert into Object (Address, Area, IdObjectType, IdCustomer) values ('{@object.Address}', '{@object.Area}', '{GetObjectTypeId(@object.ObjectTypeName)}', '{GetCustomertId(@object.CustomerName)}');");
        }
        public void Delete(Models.Object @object)
        {
            Execute($"delete from Object where Id={@object.Id}");
        }
        public void Update(Models.Object @object)
        {
            Execute($"update Object set Address='{@object.Address}', Area='{@object.Area}', IdObjectType='{GetObjectTypeId(@object.ObjectTypeName)}', IdCustomer='{GetCustomertId(@object.CustomerName)}' where id={@object.Id};");
        }
        private long GetObjectTypeId(string name)
        {
            foreach (ObjectType ot in DataModel.ObjectTypes)
            {
                if (ot.TypeName == name)
                    return ot.Id;
            }
            return 0;
        }
        private long GetCustomertId(string name)
        {
            foreach (Customer c in DataModel.Customers)
            {
                if (c.LastName == name)
                    return c.Id;
            }
            return 0;
        }
    }
}
