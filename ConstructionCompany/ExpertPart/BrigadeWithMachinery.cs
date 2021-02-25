using ConstructionCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ConstructionCompany.ExpertPart
{
    class BrigadeWithMachinery
    {
        public Order Order { get; set; }
        public Work Work { get; set; }
        public string WorkName { get { return Work.WorkName; } }
        public Brigade Brigade { get; set; }
        public string BrigadeName { get { return Brigade.Name; } }
        public ObservableCollection<Machinery> MachineryCollection { get; set; }

        public BrigadeWithMachinery(Order order, Work work, Brigade brigade, ObservableCollection<Machinery> machineryCollection)
        {
            this.Order = order;
            this.Work = work;
            this.Brigade = brigade;
            this.MachineryCollection = machineryCollection;
        }
    }
}
