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
    class MaterialUsingDataAdapter : DataAdapter
    {
        private ObservableCollection<MaterialUsing> MaterialsUsing;
        public MaterialUsingDataAdapter(MySqlConnection connection, ObservableCollection<MaterialUsing> materialsUsing) : base(connection)
        {
            MaterialsUsing = materialsUsing;
        }
        private void MaterialsUsing_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as MaterialUsing);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as MaterialUsing);
                    break;
            }
        }
        private void MaterialUsing_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MaterialName" || e.PropertyName == "IdOrder" || e.PropertyName == "IdBrigade" || e.PropertyName == "Count" || e.PropertyName == "Date" || e.PropertyName == "Price") this.Update(sender as MaterialUsing);
            //if (e.PropertyName == "Count")
            //    (sender as MaterialUsing).Price= SetCountingPriceValue(sender as MaterialUsing);
        }
        

        public void Fill()
        {
            MaterialsUsing.CollectionChanged -= MaterialsUsing_CollectionChanged;

            //List<Dictionary<string, string>> allMaterialsUsing = GetQueryResult("select mu.Id, m.IdMaterial, ob.IdOrderBrigade, mu.Count, mu.Date, mu.Price from MaterialUsing mu left join Material m on m.IdMaterial=m.ID left join OrderBrigade ob on ob.IdOrderBrigade = ;");

            List<Dictionary<string, string>> allMaterialsUsing = GetQueryResult("select mu.Id, m.Name, ob.IdOrder, ob.IdBrigade, mu.Count, mu.Date, mu.Price from MaterialUsing mu left join Material m on mu.IdMaterial=m.Id left join OrderBrigade ob on mu.IdOrderBrigade=ob.Id;");


            foreach (Dictionary<string, string> a in allMaterialsUsing)
            {
                MaterialUsing na = new MaterialUsing(long.Parse(a["Id"]), a["Name"], long.Parse(a["IdOrder"]), long.Parse(a["IdBrigade"]), int.Parse(a["Count"]), Convert.ToDateTime(a["Date"]), int.Parse(a["Price"]));

                na.PropertyChanged += MaterialUsing_PropertyChanged;

                MaterialsUsing.Add(na);
            }

            MaterialsUsing.CollectionChanged += MaterialsUsing_CollectionChanged;
        }

        public void Add(MaterialUsing materialUsing)
        {
            materialUsing.PropertyChanged += MaterialUsing_PropertyChanged;
            materialUsing.Id = InsertRow($"insert into MaterialUsing (IdMaterial, IdOrderBrigade, Count, Date, Price) values ('{GetMaterialId(materialUsing.MaterialName)}', '{GetIdOrderBrigade(materialUsing.IdOrder, materialUsing.IdBrigade)}', '{materialUsing.Count}', '{materialUsing.Date}', '{materialUsing.Price}');");
        }

        public void Delete(MaterialUsing materialUsing)
        {
            Execute($"delete from MaterialUsing where Id={materialUsing.Id}");
        }

        public void Update(MaterialUsing materialUsing)
        {
            Execute($"update MaterialUsing set IdMaterial='{GetMaterialId(materialUsing.MaterialName)}', IdOrderBrigade='{GetIdOrderBrigade(materialUsing.IdOrder, materialUsing.IdBrigade)}', Count='{(materialUsing.Count)}', Date='{materialUsing.Date}', Price='{materialUsing.Price}' where Id={materialUsing.Id};");
            
        }

        private long GetIdBrigade(string name)
        {
            foreach (Brigade b in DataModel.Brigades)
            {
                if (name == b.Name)
                    return b.Id;
            }
            return 0;
        }

        private long GetIdOrderBrigade(long idOrder, long idBrigade)
        {
            foreach(OrderBrigade ob in DataModel.OrderBrigades)
            {
                if (idOrder == ob.IdOrder && idBrigade == ob.IdBrigade)
                    return ob.Id;
            }
            return 0;
        }

        private long GetMaterialId(string name)
        {
            foreach (Material material in DataModel.Materials)
            {
                if (material.Name == name)
                    return material.Id;
            }
            return 0;
        }
    }
}