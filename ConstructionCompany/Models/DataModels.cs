using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ConstructionCompany.DataAdapters;
using System.Collections.ObjectModel;

namespace ConstructionCompany.Models
{
    public static class DataModel
    {
        static public MySqlConnection DBConnection;
        
        static public ObservableCollection<Customer> Customers { get; set; }
        static private CustomerDataAdapter customerDataAdapter;

        static public ObservableCollection<Material> Materials { get; set; }
        static private MaterialDataAdapter materialDataAdapter;

        static public ObservableCollection<Work> Works { get; set; }
        static private WorkDataAdapter workDataAdapter;

        static public ObservableCollection<Worker> Workers { get; set; }
        static private WorkerDataAdapter workerDataAdapter;
        
        static public ObservableCollection<Brigade> Brigades { get; set; }
        static private BrigadeDataAdapter brigadeDataAdapter;

        static public ObservableCollection<Object> Objects { get; set; }
        static private ObjectDataAdapter objectDataAdapter;

        static public ObservableCollection<Order> Orders { get; set; }
        static private OrderDataAdapter orderDataAdapter;

        static public ObservableCollection<Machinery> Machinery { get; set; }
        static private MachineryDataAdapter machineryDataAdapter;

        static public ObservableCollection<MachineryType> MachineryTypes { get; set; }
        static private MachineryTypeDataAdapter machineryTypeDataAdapter;

        static public ObservableCollection<WorkType> WorkTypes { get; set; }
        static private WorkTypeDataAdapter workTypeDataAdapter;

        static public ObservableCollection<ObjectType> ObjectTypes { get; set; }
        static private ObjectTypeDataAdapter objectTypeDataAdapter;

        static public ObservableCollection<OrderBrigade> OrderBrigades { get; set; }
        static private OrderBrigadeDataAdapter orderBrigadeDataAdapter;

        static public ObservableCollection<MaterialUsing> MaterialsUsing { get; set; }
        static private MaterialUsingDataAdapter materialUsingDataAdapter;

        static public ObservableCollection<MachineryUsing> MachineryUsing { get; set; }
        static private MachineryUsingDataAdapter machineryUsingDataAdapter;

        static public ObservableCollection<OrderWork> OrderWorks { get; set; }
        static private OrderWorkDataAdapter orderWorkDataAdapter;

        static public ObservableCollection<Rule> Rules { get; set; }
        static private RuleDataAdapter ruleDataAdapter;

        static DataModel()
        {
            DBConnection = new MySqlConnection("server=127.0.0.1; port=3306; pwd=root; Uid=root; database=cc; charset=utf8");
            DBConnection.Open();

            Customers = new ObservableCollection<Customer>();
            customerDataAdapter = new CustomerDataAdapter(DBConnection, Customers);
            customerDataAdapter.Fill();

            Materials = new ObservableCollection<Material>();
            materialDataAdapter = new MaterialDataAdapter(DBConnection, Materials);
            materialDataAdapter.Fill();
            
            Workers = new ObservableCollection<Worker>();
            workerDataAdapter = new WorkerDataAdapter(DBConnection, Workers);
            workerDataAdapter.Fill();

            Works = new ObservableCollection<Work>();
            workDataAdapter = new WorkDataAdapter(DBConnection, Works);
            workDataAdapter.Fill();

            Brigades = new ObservableCollection<Brigade>();
            brigadeDataAdapter = new BrigadeDataAdapter(DBConnection, Brigades);
            brigadeDataAdapter.Fill();
            
            Objects = new ObservableCollection<Object>();
            objectDataAdapter = new ObjectDataAdapter(DBConnection, Objects);
            objectDataAdapter.Fill();

            Orders = new ObservableCollection<Order>();
            orderDataAdapter = new OrderDataAdapter(DBConnection, Orders);
            orderDataAdapter.Fill();


            Machinery = new ObservableCollection<Machinery>();
            machineryDataAdapter = new MachineryDataAdapter(DBConnection, Machinery);
            machineryDataAdapter.Fill();

            MachineryTypes = new ObservableCollection<MachineryType>();
            machineryTypeDataAdapter = new MachineryTypeDataAdapter(DBConnection, MachineryTypes);
            machineryTypeDataAdapter.Fill();

            WorkTypes = new ObservableCollection<WorkType>();
            workTypeDataAdapter = new WorkTypeDataAdapter(DBConnection, WorkTypes);
            workTypeDataAdapter.Fill();

            ObjectTypes = new ObservableCollection<ObjectType>();
            objectTypeDataAdapter = new ObjectTypeDataAdapter(DBConnection, ObjectTypes);
            objectTypeDataAdapter.Fill();

            OrderBrigades = new ObservableCollection<OrderBrigade>();
            orderBrigadeDataAdapter = new OrderBrigadeDataAdapter(DBConnection, OrderBrigades);
            orderBrigadeDataAdapter.Fill();

            MaterialsUsing = new ObservableCollection<MaterialUsing>();
            materialUsingDataAdapter = new MaterialUsingDataAdapter(DBConnection, MaterialsUsing);
            materialUsingDataAdapter.Fill();

            MachineryUsing = new ObservableCollection<MachineryUsing>();
            machineryUsingDataAdapter = new MachineryUsingDataAdapter(DBConnection, MachineryUsing);
            machineryUsingDataAdapter.Fill();

            OrderWorks = new ObservableCollection<OrderWork>();
            orderWorkDataAdapter = new OrderWorkDataAdapter(DBConnection, OrderWorks);
            orderWorkDataAdapter.Fill();

            Rules = new ObservableCollection<Rule>();
            ruleDataAdapter = new RuleDataAdapter(DBConnection, Rules);
            ruleDataAdapter.Fill();
        }
    }
}
