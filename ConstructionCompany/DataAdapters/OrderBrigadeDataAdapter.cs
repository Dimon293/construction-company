using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ConstructionCompany.DataAdapters
{
    class OrderBrigadeDataAdapter : DataAdapter
    {
        private ObservableCollection<OrderBrigade> OrderBrigades;
        public OrderBrigadeDataAdapter(MySqlConnection connection, ObservableCollection<OrderBrigade> orderBrigades) : base(connection)
        {
            OrderBrigades = orderBrigades;
        }
        private void OrderBrigades_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as OrderBrigade);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as OrderBrigade);
                    break;
            }
        }
        private void OrderBrigade_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IdOrder" || e.PropertyName == "IdBrigade" || e.PropertyName == "Area") this.Update(sender as OrderBrigade);
        }
        public void Fill()
        {
            OrderBrigades.CollectionChanged -= OrderBrigades_CollectionChanged;

            List<Dictionary<string, string>> allOrderBrigades = GetQueryResult("select Id, IdOrder, IdBrigade, Area from OrderBrigade;");

            foreach (Dictionary<string, string> t in allOrderBrigades)
            {
                OrderBrigade ob = new OrderBrigade(long.Parse(t["Id"]), long.Parse(t["IdOrder"]), long.Parse(t["IdBrigade"]), int.Parse(t["Area"]));

                foreach (Brigade brigade in DataModel.Brigades)
                {
                    if (long.Parse(t["IdBrigade"]) == brigade.Id)
                    {
                        brigade.OrdersCollection.Add(FindOrder(long.Parse(t["IdOrder"])));
                    }
                }

                ob.PropertyChanged += OrderBrigade_PropertyChanged;

                OrderBrigades.Add(ob);
            }
            OrderBrigades.CollectionChanged += OrderBrigades_CollectionChanged;
        }
        public void Add(OrderBrigade orderBrigade)
        {
            orderBrigade.PropertyChanged += OrderBrigade_PropertyChanged;
            orderBrigade.Id = InsertRow($"insert into OrderBrigade (IdOrder, IdBrigade, Area) values ('{orderBrigade.IdOrder}', '{orderBrigade.IdBrigade}', '{orderBrigade.Area}');");
        }
        public void Delete(OrderBrigade orderBrigade)
        {
            Execute($"delete from OrderBrigade where Id={orderBrigade.Id}");
        }
        public void Update(OrderBrigade orderBrigade)
        {
            Execute($"update OrderBrigade set IdOrder='{orderBrigade.IdOrder}', IdBrigade='{orderBrigade.IdBrigade}', '{orderBrigade.Area}' where Id={orderBrigade.Id};");
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
