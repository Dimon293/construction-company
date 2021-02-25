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
    public class Rule : INotifyPropertyChanged
    {

        private string workName, attributeName;
        private int materialMaterialCount, attributeValue;

        public long Id { get; set; }

        public string WorkName
        {
            get { return workName; }
            set { workName = value; OnPropertyChanged("WorkName"); }
        }

        public int AttributeValue
        {
            get { return attributeValue; }
            set { attributeValue = value; OnPropertyChanged("AttributeValue"); }
        }
        
        public string AttributeName
        {
            get { return attributeName; }
            set { attributeName = value; OnPropertyChanged("AttributeName"); }
        }

        public int MaterialCount
        {
            get { return materialMaterialCount; }
            set { materialMaterialCount = value; OnPropertyChanged("MaterialCount"); }
        }

        public Rule()
        {
            this.WorkName = "";
            this.AttributeName = "";
            this.AttributeValue = 0;
        }

        public Rule(long id, string workName, string attributeName, int attributeValue)
        {
            this.Id = id;
            this.WorkName = workName;
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
