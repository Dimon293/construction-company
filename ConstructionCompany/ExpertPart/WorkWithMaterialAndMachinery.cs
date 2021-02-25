using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;

namespace ConstructionCompany.ExpertPart
{
    class WorkWithMaterialAndMachinery
    {
        public Work Work { get; set; }
        public string WorkName { get { return Work.WorkName; } }

        public ObservableCollection<Material> MaterialsCollection { get; set; }
        public ObservableCollection<Machinery> MachineryCollection { get; set; }
        public ObservableCollection<MachineryType> MachineryTypeCollection { get; set; }
        public WorkWithMaterialAndMachinery(Work work)
        {
            this.Work = work;
            FillMaterialsCollection();
            FillMachineryTypeCollection();
        }
        // Заполнение коллекции правил для материалов
        void FillMaterialsCollection()
        {
            this.MaterialsCollection = new ObservableCollection<Material>();
            foreach (Rule r in DataModel.Rules)
            {
                if (r.WorkName == Work.WorkName && r.AttributeName == "Материал")
                    MaterialsCollection.Add(GetMaterialById(r.AttributeValue));
            }
        }
        // Заполнение коллекции правил для типов техники
        void FillMachineryTypeCollection()
        {
            this.MachineryTypeCollection = new ObservableCollection<MachineryType>();
            foreach (Rule r in DataModel.Rules)
            {
                if (r.WorkName == Work.WorkName && r.AttributeName == "Техника")
                    MachineryTypeCollection.Add(GetMachineryTypeById(r.AttributeValue));
            }
        }
        Machinery GetMachineryById(int id)
        {
            foreach (Machinery m in DataModel.Machinery)
            {
                if (m.Id == id)
                    return m;
            }
            throw new ArgumentNullException("Строительной техники не существует");
        }

        Material GetMaterialById(int id)
        {
            foreach (Material m in DataModel.Materials)
            {
                if (m.Id == id)
                    return m;
            }
            throw new ArgumentNullException("Материала не существует");
        }

        MachineryType GetMachineryTypeById(int id)
        {
            foreach (MachineryType m in DataModel.MachineryTypes)
            {
                if (m.Id == id)
                    return m;
            }
            throw new ArgumentNullException("Материала не существует");
        }
    }
}