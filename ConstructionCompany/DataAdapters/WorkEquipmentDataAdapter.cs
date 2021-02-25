//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
//using ConstructionCompany.Models;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.ComponentModel;

//namespace ConstructionCompany.DataAdapters
//{
//    class WorkEquipmentDataAdapter : DataAdapter
//    {
//        private ObservableCollection<WorkEquipment> WorkEquipment;
//        public WorkEquipmentDataAdapter(MySqlConnection connection, ObservableCollection<WorkEquipment> workEquipment) : base(connection)
//        {
//            WorkEquipment = workEquipment;
//        }
//        private void WorkEquipment_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
//        {
//            switch (e.Action)
//            {
//                case NotifyCollectionChangedAction.Add:
//                    this.Add(e.NewItems[0] as WorkEquipment);
//                    break;
//                case NotifyCollectionChangedAction.Remove:
//                    this.Delete(e.OldItems[0] as WorkEquipment);
//                    break;
//            }
//        }
//        private void WorkEquipment_PropertyChanged(object sender, PropertyChangedEventArgs e)
//        {
//            if (e.PropertyName == "IdRule" || e.PropertyName == "IdMachinery" || e.PropertyName == "IdMaterial" || e.PropertyName == "MaterialCount") this.Update(sender as WorkEquipment);
//        }
//        public void Fill()
//        {
//            WorkEquipment.CollectionChanged -= WorkEquipment_CollectionChanged;

//            List<Dictionary<string, string>> allWorkEquipment = GetQueryResult("select Id, IdRule, IdMachinery, IdMaterial, MaterialCount from WorkEquipment;");

//            foreach (Dictionary<string, string> t in allWorkEquipment)
//            {
//                WorkEquipment ob = new WorkEquipment(long.Parse(t["Id"]), long.Parse(t["IdRule"]), long.Parse(t["IdMachinery"]), long.Parse(t["IdMaterial"]), int.Parse(t["MaterialCount"]));

//                foreach (Machinery machinery in DataModel.Machinery)
//                {
//                    if (long.Parse(t["IdMachinery"]) == machinery.Id)
//                    {
//                        machinery.OrdersCollection.Add(FindOrder(long.Parse(t["IdRule"])));
//                    }
//                }

//                ob.PropertyChanged += WorkEquipment_PropertyChanged;

//                WorkEquipment.Add(ob);
//            }
//            WorkEquipment.CollectionChanged += WorkEquipment_CollectionChanged;
//        }
//        public void Add(WorkEquipment workEquipment)
//        {
//            workEquipment.PropertyChanged += WorkEquipment_PropertyChanged;
//            workEquipment.Id = InsertRow($"insert into WorkEquipment (IdRule, IdMachinery, MaterialCount) values ('{workEquipment.IdRule}', '{workEquipment.IdMachinery}', '{workEquipment.MaterialCount}');");
//        }
//        public void Delete(WorkEquipment workEquipment)
//        {
//            Execute($"delete from WorkEquipment where Id={workEquipment.Id}");
//        }
//        public void Update(WorkEquipment workEquipment)
//        {
//            Execute($"update WorkEquipment set IdRule='{workEquipment.IdRule}', IdMachinery='{workEquipment.IdMachinery}', '{workEquipment.MaterialCount}' where Id={workEquipment.Id};");
//        }
//        private Order FindOrder(long id)
//        {
//            foreach (Order order in DataModel.Orders)
//            {
//                if (order.Id == id)
//                    return order;
//            }
//            return null;
//        }

//    }
//}
