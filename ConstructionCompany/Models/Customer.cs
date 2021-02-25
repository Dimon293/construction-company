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

namespace ConstructionCompany.Models
{
    public class Customer : INotifyPropertyChanged
    {
        private string lastName, firstName, patronymic, email, phone;

        public long Id { get; set; }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; OnPropertyChanged("Patronymic"); }
        }
        
        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged("Phone"); }
        }
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("Email"); }
        }

        public Customer()
        {
            this.LastName = "";
            this.FirstName = "";
            this.Patronymic = "";
            this.Phone = "";
            this.Email = "";
        }

        public Customer(long id, string lastName, string firstName, string patronymic, string phone, string email)
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Patronymic = patronymic;
            this.Phone = phone;
            this.Email = email;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
