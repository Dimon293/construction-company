using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ConstructionCompany.Models;

namespace ConstructionCompany.ExpertPart
{
    class ExpertMaterialCountViewModel
    {
        public ObservableCollection<BrigadeWithMaterialCount> BrigadeWithMaterialCountCollection { get; set; }
        

        public ExpertMaterialCountViewModel()
        {
            this.BrigadeWithMaterialCountCollection = new ObservableCollection<BrigadeWithMaterialCount>();
        }

        public void AddWorkWithMaterialCount(Order order, Work work, Brigade brigade, ObservableCollection<MaterialCount> materialCountCollection)
        {
            RemoveAlreadyExistingMaterials(order, brigade, materialCountCollection);
            BrigadeWithMaterialCountCollection.Add(new BrigadeWithMaterialCount(work, brigade, materialCountCollection));
        }
        // Удаление уже существующих материалов из списка предлагаемых к покупке или изменение их количества в зависимости от уже приобретенных
        void RemoveAlreadyExistingMaterials(Order order, Brigade brigade, ObservableCollection<MaterialCount> materialCountCollection)
        {
            foreach(MaterialCount mc in materialCountCollection)
            {
                MaterialUsing mu = AlreadyExist(order, brigade, mc);
                if(mu != null)
                {
                    int count = mc.Count - TotalMaterialCount(order, brigade);
                    if (count >= 0)
                    {
                        mc.Count = count;
                    }
                    else mc.Count = 0;
                }
            }
        }
        // Возвращает уже существующие в списках материалы
        MaterialUsing AlreadyExist(Order order, Brigade brigade, MaterialCount materialCount)
        {
            foreach(MaterialUsing mu in DataModel.MaterialsUsing)
            {
                if(mu.IdOrder == order.Id && mu.IdBrigade == brigade.Id && mu.Material.Id == materialCount.Material.Id)
                {
                    return mu;
                }
            }
            return null;
        }
        // Возвращает количество заказанного материала
        int TotalMaterialCount(Order order, Brigade brigade)
        {
            int count = 0;
            foreach (MaterialUsing mu in DataModel.MaterialsUsing)
            {
                if (mu.IdOrder == order.Id && mu.IdBrigade == brigade.Id)
                {
                    count += mu.Count;
                }
            }
            return count;
        }
    }
    class ExpertMachineryViewModel
    {
        public ObservableCollection<BrigadeWithMachinery> WorkWithMachineryCollection { get; set; }

        public ExpertMachineryViewModel()
        {
            this.WorkWithMachineryCollection = new ObservableCollection<BrigadeWithMachinery>();
        }

        public void AddWorkWithMachinery(Order order, Work work, Brigade brigade, ObservableCollection<Machinery> machineryCollection)
        {
            WorkWithMachineryCollection.Add(new BrigadeWithMachinery(order, work, brigade, machineryCollection));
        }
    }
}
