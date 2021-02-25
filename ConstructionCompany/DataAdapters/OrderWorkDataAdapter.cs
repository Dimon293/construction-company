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
    class OrderWorkDataAdapter : DataAdapter
    {
        private ObservableCollection<OrderWork> OrderWorks;
        public OrderWorkDataAdapter(MySqlConnection connection, ObservableCollection<OrderWork> orderWorks) : base(connection)
        {
            OrderWorks = orderWorks;
        }
        private void OrderWorks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as OrderWork);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as OrderWork);
                    break;
            }
        }
        private void OrderWork_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IdOrder" || e.PropertyName == "IdWork") this.Update(sender as OrderWork);
        }
        public void Fill()
        {
            OrderWorks.CollectionChanged -= OrderWorks_CollectionChanged;

            List<Dictionary<string, string>> allOrderWorks = GetQueryResult("select Id, IdOrder, IdWork from OrderWork;");

            foreach (Dictionary<string, string> t in allOrderWorks)
            {
                OrderWork ob = new OrderWork(long.Parse(t["Id"]), long.Parse(t["IdOrder"]), long.Parse(t["IdWork"]));

                foreach (Work work in DataModel.Works)
                {
                    if (long.Parse(t["IdWork"]) == work.Id)
                    {
                        work.OrdersCollection.Add(FindOrder(long.Parse(t["IdOrder"])));
                    }
                }

                ob.PropertyChanged += OrderWork_PropertyChanged;

                OrderWorks.Add(ob);
            }
            OrderWorks.CollectionChanged += OrderWorks_CollectionChanged;
        }
        public void Add(OrderWork orderWork)
        {
            orderWork.PropertyChanged += OrderWork_PropertyChanged;
            orderWork.Id = InsertRow($"insert into OrderWork (IdOrder, IdWork) values ('{orderWork.IdOrder}', '{orderWork.IdWork}');");
        }
        public void Delete(OrderWork orderWork)
        {
            Execute($"delete from OrderWork where Id={orderWork.Id}");
        }
        public void Update(OrderWork orderWork)
        {
            Execute($"update OrderWork set IdOrder='{orderWork.IdOrder}', IdWork='{orderWork.IdWork}' where Id={orderWork.Id};");
        }
        private Order FindOrder(long id)
        {
            foreach (Order order in DataModel.Orders)
            {
                if (order.Id == id)
                    return order;
            }
            return null;
        }

    }
}
