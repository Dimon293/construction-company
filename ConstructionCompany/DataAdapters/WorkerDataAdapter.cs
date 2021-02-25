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
    class WorkerDataAdapter : DataAdapter
    {
        private ObservableCollection<Worker> Workers;
        public WorkerDataAdapter(MySqlConnection connection, ObservableCollection<Worker> workers) : base(connection)
        {
            Workers = workers;
        }
        private void Workers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Worker);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Worker);
                    break;
            }
        }
        private void Worker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "BrigadeName" || e.PropertyName == "LastName" || e.PropertyName == "FirstName" || e.PropertyName == "Patronymic" || e.PropertyName == "Birthday" || e.PropertyName == "PassportNumber" || e.PropertyName == "Address" || e.PropertyName == "Phone" ||e.PropertyName == "Experience") this.Update(sender as Worker);
        }

        public void Fill()
        {
            Workers.CollectionChanged -= Workers_CollectionChanged;

            List<Dictionary<string, string>> allWorkers = GetQueryResult("select w.Id, b.Name, w.LastName, w.FirstName, w.Patronymic, w.Birthday, w.PassportNumber, w.Address, w.Phone, w.Experience from Worker w left join Brigade b on w.IdBrigade=b.Id;");
            
            foreach (Dictionary<string, string> a in allWorkers)
            {
                Worker na = new Worker(long.Parse(a["Id"]), a["Name"], a["LastName"], a["FirstName"], a["Patronymic"], Convert.ToDateTime(a["Birthday"]), int.Parse(a["PassportNumber"]), a["Address"], a["Phone"], int.Parse(a["Experience"]));

                na.PropertyChanged += Worker_PropertyChanged;

                Workers.Add(na);
            }

            Workers.CollectionChanged += Workers_CollectionChanged;
        }

        public void Add(Worker worker)
        {
            worker.PropertyChanged += Worker_PropertyChanged;
            worker.Id = InsertRow($"insert into Worker (IdBrigade, LastName, FirstName, Patronymic, Birthday, PassportNumber, Address, Phone, Experience) values ('{GetBrigadeId(worker.BrigadeName)}', '{worker.LastName}', '{worker.FirstName}', '{worker.Patronymic}', '{worker.Birthday}', '{worker.PassportNumber}', '{worker.Address}', '{worker.Phone}', '{worker.Experience}');");
        }
        
        public void Delete(Worker worker)
        {
            Execute($"delete from Worker where Id={worker.Id}");
        }
        
        public void Update(Worker worker)
        {
            Execute($"update Worker set IdBrigade='{GetBrigadeId(worker.BrigadeName)}', LastName='{worker.LastName}', FirstName='{worker.FirstName}', Patronymic='{worker.Patronymic}', Birthday='{worker.Birthday}', PassportNumber='{worker.PassportNumber}', Address='{worker.Address}', Phone='{worker.Phone}', Experience='{worker.Experience}' where Id={worker.Id};");
        }
        private long GetBrigadeId(string name)
        {
            foreach (Brigade b in DataModel.Brigades)
            {
                if (b.Name == name)
                    return b.Id;
            }
            DataModel.Brigades.Add(new Brigade());
            System.Windows.MessageBox.Show("Бригады не существует, создан пустой объект.");
            return DataModel.Workers.Count - 1;
        }
    }
}