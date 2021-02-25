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
    public class MachineryType : INotifyPropertyChanged
    {
        private string typeName;

        public long Id { get; set; }
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; OnPropertyChanged("TypeName"); }
        }

        public MachineryType()
        {
            this.TypeName = "";
        }

        public MachineryType(long id, string typeName)
        {
            this.Id = id;
            this.TypeName = typeName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyTypeName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyTypeName));
        }
    }
}
