using System;
using System.Collections.Generic;
using System.Linq;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;

namespace ConstructionCompany.ExpertPart
{
    // Для конкретной работы находит необходимые материалы и технику
    class ExpertClass
    {
        private List<Rule> RulesList { get; set; }
        private List<Material> MaterialsList { get; set; }
        private List<Machinery> MachineryList { get; set; }
        private List<MachineryType> MachineryTypeList { get; set; }
        private Dictionary<MachineryType, ObservableCollection<Machinery>> MachineryTypeD { get; set; }

        private Work Work { get; set; }
        private int Area { get; set; }
        private ObservableCollection<MaterialCount> MaterialCountCollection { get; set; }
        private ObservableCollection<Machinery> MachineryCollection { get; set; }

        public ExpertClass(Work work, int area)
        {
            this.Work = work;
            this.Area = area;
            
            GetRuleValues();
            GetValues();
            GetMachineryValues();
            FillMachineryTypeD();
        }
        // Добавление правил в коллекцию
        void GetRuleValues()
        {
            this.RulesList = new List<Rule>();
            foreach (Rule r in DataModel.Rules)
            {
                RulesList.Add(r);
            }
        }
        // Заполнение список материалов и техники по каждой из работ в заказе
        void GetValues()
        {
            this.MaterialsList = new List<Material>();
            this.MachineryTypeList = new List<MachineryType>();
            foreach (Rule r in RulesList)
            {
                if (r.WorkName == Work.WorkName && r.AttributeName == "Материал")
                {
                    MaterialsList.Add(GetMaterialById(r.AttributeValue));
                }
                if (r.WorkName == Work.WorkName && r.AttributeName == "Техника")
                {
                    MachineryTypeList.Add(GetMachineryTypeById(r.AttributeValue));
                }
            }
        }
        // Заполнение словаря "Тип техники - Конкретная техника"
        public void FillMachineryTypeD()
        {
            this.MachineryTypeD = new Dictionary<MachineryType, ObservableCollection<Machinery>>();
            foreach(MachineryType mt in MachineryTypeList)
            {
                MachineryTypeD.Add(mt, GetMachineryCollection(mt));
            }
        }
        // Возвращает коллекцию СВОБОДНОЙ техники указанного типа
        ObservableCollection<Machinery> GetMachineryCollection(MachineryType mt)
        {
            ObservableCollection<Machinery> mc = new ObservableCollection<Machinery>();
            foreach (Machinery m in DataModel.Machinery)
            {
                if (m.MachineryTypeName == mt.TypeName && !m.InUse)
                {
                    mc.Add(m);
                    return mc;
                }
            }
            throw new ArgumentNullException("Техники данного типа не существует");
        }
        // Заполнение коллекции техники
        void GetMachineryValues()
        {
            this.MachineryList = new List<Machinery>();
            foreach (MachineryType mt in MachineryTypeList)
            {
                foreach (Machinery m in DataModel.Machinery)
                {
                    if (m.MachineryTypeName == mt.TypeName)
                    {
                        MachineryList.Add(m);
                    }
                }
            }
        }
        // Возвращает коллекцию "Материал - Его количество"
        public ObservableCollection<MaterialCount> GetMaterialCount()
        {
            MaterialCountCollection = new ObservableCollection<MaterialCount>();
            foreach (Material m in MaterialsList)
            {
                MaterialCountCollection.Add(new MaterialCount(m, (int)Math.Floor(Convert.ToDouble(this.Area) / Convert.ToDouble(m.Area))));
            }
            return MaterialCountCollection;
        }
        // Возвращает коллекцию техники с одной единицей техники на каждый тип
        public ObservableCollection<Machinery> GetMachinery()
        {
            Machinery m;
            ObservableCollection<Machinery> mc = new ObservableCollection<Machinery>();
            foreach (KeyValuePair<MachineryType, ObservableCollection<Machinery>> kvp in MachineryTypeD)
            {
                //Last, т.к. нужна одна единица техники каждого типа
                m = kvp.Value.Last();
                mc.Add(m);
            }
            return mc;
        }
        // Возвращает коллекцию со всей техникой (-)
        public ObservableCollection<Machinery> GetAllMachinery()
        {
            MachineryCollection = new ObservableCollection<Machinery>();
            foreach(Machinery m in MachineryList)
            {
                MachineryCollection.Add(m);
            }
            return MachineryCollection;
        }
        // Возвращает коллекцию со всей СВОБОДНОЙ техникой (-)
        public ObservableCollection<Machinery> GetFreeMachinery()
        {
            MachineryCollection = new ObservableCollection<Machinery>();

            foreach (Machinery m in MachineryList)
            {
                if(!m.InUse)
                    MachineryCollection.Add(m);
            }
            return MachineryCollection;
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

        Machinery GetMachineryById(int id)
        {
            foreach (Machinery m in DataModel.Machinery)
            {
                if (m.Id == id)
                    return m;
            }
            throw new ArgumentNullException("Строительной техники не существует");
        }

        MachineryType GetMachineryTypeById(int id)
        {
            foreach (MachineryType m in DataModel.MachineryTypes)
            {
                if (m.Id == id)
                    return m;
            }
            throw new ArgumentNullException("Типа строительной техники не существует");
        }
    }
}
