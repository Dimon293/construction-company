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
    class CustomerDataAdapter : DataAdapter
    {
        private ObservableCollection<Customer> Customers;
        public CustomerDataAdapter(MySqlConnection connection, ObservableCollection<Customer> customers) : base(connection)
        {
            Customers = customers;
        }
        private void Customers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Customer);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Customer);
                    break;
            }
        }
        private void Customer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "LastName" || e.PropertyName == "FirstName" || e.PropertyName == "Patronymic" || e.PropertyName == "Phone" || e.PropertyName == "Email") this.Update(sender as Customer);
        }

        public void Fill()
        {
            Customers.CollectionChanged -= Customers_CollectionChanged;

            List<Dictionary<string, string>> allCustomers = GetQueryResult("select Id, LastName, FirstName, Patronymic, Phone, Email from Customer;");
            
            foreach (Dictionary<string, string> a in allCustomers)
            {
                Customer na = new Customer(long.Parse(a["Id"]), a["LastName"], a["FirstName"], a["Patronymic"], a["Phone"], a["Email"]);

                na.PropertyChanged += Customer_PropertyChanged;

                Customers.Add(na);
            }

            Customers.CollectionChanged += Customers_CollectionChanged;
        }

        public void Add(Customer customer)
        {
            customer.PropertyChanged += Customer_PropertyChanged;
            customer.Id = InsertRow($"insert into Customer (LastName, FirstName, Patronymic, Phone, Email) values ('{customer.LastName}', '{customer.FirstName}', '{customer.Patronymic}', '{customer.Phone}', '{customer.Email}');");
        }

        public void Delete(Customer customer)
        {
            Execute($"delete from Customer where Id={customer.Id}");
        }

        public void Update(Customer customer)
        {
            Execute($"update Customer set LastName='{customer.LastName}', FirstName='{customer.FirstName}', Patronymic='{customer.Patronymic}', Phone='{customer.Phone}', Email='{customer.Email}' where Id={customer.Id};");
        }
    }
}