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
    class MaterialDataAdapter : DataAdapter
    {
        private ObservableCollection<Material> Materials;
        public MaterialDataAdapter(MySqlConnection connection, ObservableCollection<Material> materials) : base(connection)
        {
            Materials = materials;
        }
        private void Materials_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Material);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Material);
                    break;
            }
        }
        private void Material_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name" || e.PropertyName == "UnitOfMeasurement" || e.PropertyName == "Area" || e.PropertyName == "Price") this.Update(sender as Material);
        }

        public void Fill()
        {
            Materials.CollectionChanged -= Materials_CollectionChanged;

            List<Dictionary<string, string>> allMaterials = GetQueryResult("select Id, Name, UnitOfMeasurement, Area, Price from Material;");
            

            foreach (Dictionary<string, string> a in allMaterials)
            {
                Material na = new Material(long.Parse(a["Id"]), a["Name"], a["UnitOfMeasurement"], int.Parse(a["Area"]), int.Parse(a["Price"]));

                na.PropertyChanged += Material_PropertyChanged;

                Materials.Add(na);
            }

            Materials.CollectionChanged += Materials_CollectionChanged;
        }

        public void Add(Material material)
        {
            material.PropertyChanged += Material_PropertyChanged;
            material.Id = InsertRow($"insert into Material (Name, UnitOfMeasurement, Area, Price) values ('{material.Name}', '{material.UnitOfMeasurement}', '{material.Area}', '{material.Price}');");
        }

        public void Delete(Material material)
        {
            Execute($"delete from Material where Id={material.Id}");
        }

        public void Update(Material material)
        {
            Execute($"update Material set Name='{material.Name}', UnitOfMeasurement='{material.UnitOfMeasurement}', Area='{material.Area}', Price='{material.Price}' where Id={material.Id};");
        }
    }
}