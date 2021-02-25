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
    public class Worker : INotifyPropertyChanged
    {
        private string lastName, firstName, patronymic, brigadeName, address, phone;
        private int passportNumber, experience;
        private DateTime birthday;
        public long Id { get; set; }
       
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; OnPropertyChanged("Patronymic"); }
        }
        public string Birthday
        {
            get { return birthday.ToString("yyyy-MM-dd"); }
            set
            {
                birthday = Convert.ToDateTime(value);
                OnPropertyChanged("Birthday");
            }
        }
        public string BrigadeName
        {
            get { return brigadeName; }
            set { brigadeName = value; OnPropertyChanged("BrigadeName"); }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged("Phone"); }
        }

        public int PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; OnPropertyChanged("PassportNumber"); }
        }

        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged("Address"); }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; OnPropertyChanged("Experience"); }
        }
        public Worker()
        {
            this.BrigadeName = "";
            this.LastName = "";
            this.FirstName = "";
            this.Patronymic = "";
            this.Birthday = DateTime.Now.ToString("yyyy-MM-dd");
            this.PassportNumber = 0;
            this.Address = "";
            this.Phone = "";
            this.Experience = 0;
        }
        public Worker(long id, string brigadeName, string lastName, string firstName, string patronymic, DateTime birthday, int passportNumber, string address, string phone, int experience)
        {
            this.Id = id;
            this.BrigadeName = brigadeName;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Patronymic = patronymic;
            this.Birthday = birthday.ToString("yyyy-MM-dd");
            this.PassportNumber = passportNumber;
            this.Address = address;
            this.Phone = phone;
            this.Experience = experience;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
