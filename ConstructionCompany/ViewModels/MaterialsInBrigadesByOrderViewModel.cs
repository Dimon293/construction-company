using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ConstructionCompany.Models;

namespace ConstructionCompany.ViewModels
{
    class MaterialsInBrigadesByOrderViewModel
    {
        public ObservableCollection<BrigadeMaterials> BrigadeMaterialsCollection { get; set; }
        public Order Order { get; set; }

        public MaterialsInBrigadesByOrderViewModel(Order order)
        {
            Order = order;
            BrigadeMaterialsCollection = new ObservableCollection<BrigadeMaterials>();
            FillBrigadeMaterials(order);
        }

        void FillBrigadeMaterials(Order order)
        {
            foreach(Brigade b in order.BrigadesCollection)
            {
                BrigadeMaterialsCollection.Add(new BrigadeMaterials(order, b));
            }
        }
    }
    class BrigadeMaterials
    {
        public long Id { get; set; }
        public Order Order { get; set; }
        public Brigade Brigade { get; set; }
        public ObservableCollection<MaterialCountVM> MaterialsCountCollection { get; set; }
        public string BrigadeName { get { return Brigade.Name; } }
        public string WorkName { get { return Brigade.WorkName; } }

        public BrigadeMaterials(Order order, Brigade brigade)
        {
            Order = order;
            Brigade = brigade;
            MaterialsCountCollection = new ObservableCollection<MaterialCountVM>();
            FillMaterials();
        }

        void FillMaterials()
        {
            foreach (MaterialUsing mu in DataModel.MaterialsUsing)
            {
                int count = GetTotalMaterialCount(Order, Brigade, mu.MaterialName);
                if (mu.IdBrigade == Brigade.Id && mu.IdOrder == Order.Id && !AlreadyExist(mu.MaterialName, count))
                {                   
                    MaterialsCountCollection.Add(new MaterialCountVM(FindMaterialByName(mu.MaterialName), count));
                }
            }
        }

        int GetTotalMaterialCount(Order order, Brigade brigade, string materialName)
        {
            int sumCount = 0;
            foreach(MaterialUsing mu in DataModel.MaterialsUsing)
            {
                if(mu.IdOrder==order.Id && mu.IdBrigade==brigade.Id && mu.MaterialName == materialName)
                {
                    sumCount += mu.Count;
                }
            }
            return sumCount;
        }

        bool AlreadyExist (string materialName, int materialCount)
        {
            foreach(MaterialCountVM mc in MaterialsCountCollection)
            {
                if (mc.Material.Name == materialName && mc.Count == materialCount)
                    return true;
            }
            return false;
        }

        Material FindMaterialByName(string name)
        {
            foreach (Material m in DataModel.Materials)
            {
                if (m.Name == name)
                {
                    return m;
                }
            }
            throw new ArgumentNullException("Данный материал не существует");
        }


        Material GetMaterialByName(string name)
        {
            try
            {
                foreach (Material m in DataModel.Materials)
                {
                    if (m.Name == name)
                    {
                        return m;
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
    class MaterialCountVM
    {
        public Material Material { get; set; }
        public int Count { get; set; }
        public string Name { get { return Material.Name; } }
        public MaterialCountVM(Material m, int count)
        {
            Material = m;
            Count = count;
        }
    }
}
