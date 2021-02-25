using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;

namespace ConstructionCompany.ExpertPart
{
    class BrigadeWithMaterialCount
    {
        public Work Work { get; set; }
        public Brigade Brigade { get; set; }
        public string BrigadeName { get { return Brigade.Name; } }
        public string WorkName { get { return Work.WorkName; } }
        public ObservableCollection<MaterialCount> MaterialCountCollection { get; set; }

        public BrigadeWithMaterialCount(Work work, Brigade brigade, ObservableCollection<MaterialCount> materialCountCollection)
        {
            this.Work = work;
            this.Brigade = brigade;
            this.MaterialCountCollection = materialCountCollection;
        }
    }
}
