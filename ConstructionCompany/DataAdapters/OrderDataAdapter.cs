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
    public class OrderDataAdapter : DataAdapter
    {
        private ObservableCollection<Order> Orders;
        public OrderDataAdapter(MySqlConnection connection, ObservableCollection<Order> orders) : base(connection)
        {
            Orders = orders;
        }

        private void Orders_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Order);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Order);
                    break;
            }
        }
        private void Order_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ObjectAddress" || e.PropertyName == "StartDate" || e.PropertyName == "EndDate"
                || e.PropertyName == "Price" || e.PropertyName == "Note") this.Update(sender as Order);
        }

        public void Fill()
        {
            Orders.CollectionChanged -= Orders_CollectionChanged;
            List<Dictionary<string, string>> allOrders = GetQueryResult("select o.Id, obj.Address, o.StartDate, o.EndDate, o.Price, o.Note from Orders o left join Object obj on o.IdObject = obj.Id;");

            List<Dictionary<string, string>> allBrigadesInOrders = GetQueryResult("select Id, IdOrder, IdBrigade from OrderBrigade;");

            List<Dictionary<string, string>> allWorksInOrders = GetQueryResult("select Id, IdOrder, IdWork from OrderWork;");

            foreach (Dictionary<string, string> a in allOrders)
            {
                Order na = new Order(long.Parse(a["Id"]), a["Address"], Convert.ToDateTime(a["StartDate"]), Convert.ToDateTime(a["EndDate"]), int.Parse(a["Price"]), a["Note"]);

                foreach (Dictionary<string, string> b in allBrigadesInOrders)
                {
                    if (long.Parse(b["IdOrder"]) == na.Id)
                    {
                        na.BrigadesCollection.Add(FindBrigade(long.Parse(b["IdBrigade"])));
                    }
                }

                foreach (Dictionary<string, string> b in allWorksInOrders)
                {
                    if (long.Parse(b["IdOrder"]) == na.Id)
                    {
                        na.WorksCollection.Add(FindWork(long.Parse(b["IdWork"])));
                    }
                }

                na.PropertyChanged += Order_PropertyChanged;
                Orders.Add(na);
            }
            Orders.CollectionChanged += Orders_CollectionChanged;
        }

        public void Add(Order order)
        {
            order.PropertyChanged += Order_PropertyChanged;
            order.Id = InsertRow($"insert into Orders (IdObject, StartDate, EndDate, Price, Note) values ('{GetObjectId(order.ObjectAddress)}', '{order.StartDate}', '{order.EndDate}', '{order.Price}', '{order.Note}');");
        }
        public void Delete(Order order)
        {
            Execute($"delete from Orders where Id={order.Id}");
        }
        public void Update(Order order)
        {
            Execute($"update Orders set IdObject= '{GetObjectId(order.ObjectAddress)}', StartDate='{order.StartDate}', EndDate='{order.EndDate}', Price='{order.Price}', Note='{order.Note}' where id={order.Id};");
        }
        private long GetObjectId(string name)
        {
            foreach (Models.Object o in DataModel.Objects)
            {
                if (o.Address == name)
                    return o.Id;
            }
            return 0;
        }
        private Brigade FindBrigade(long id)
        {
            foreach (Brigade brigade in DataModel.Brigades)
            {
                if (brigade.Id == id)
                    return brigade;
            }
            return null;
        }

        private Work FindWork(long id)
        {
            foreach (Work work in DataModel.Works)
            {
                if (work.Id == id)
                    return work;
            }
            return null;
        }
    }
}
