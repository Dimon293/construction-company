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
    public class WorkType : INotifyPropertyChanged
    {
        private string typeName, note;

        public long Id { get; set; }
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; OnPropertyChanged("TypeName"); }
        }
        public string Note
        {
            get { return note; }
            set { note = value; OnPropertyChanged("Note"); }
        }
        
        public WorkType()
        {
            this.TypeName = "";
            this.Note = "";
        }

        public WorkType(long id, string typeName, string note)
        {
            this.Id = id;
            this.TypeName = typeName;
            this.Note = note;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyTypeName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyTypeName));
        }
    }
}
