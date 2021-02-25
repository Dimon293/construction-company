using ConstructionCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ConstructionCompany.ExpertPart
{
    //Для RulesW
    class RulesWorksViewModel
    {
        public ObservableCollection<WorkWithMaterialAndMachinery> WorksCollection { get; set; }
        public bool ExistInCollection(string workName)
        {
            foreach(WorkWithMaterialAndMachinery wwmam in WorksCollection)
            {
                if(wwmam.WorkName == workName)
                {
                    return true;
                }
            }
            return false;
        }

        public RulesWorksViewModel()
        {
            FillWorksCollection();
        }

        void FillWorksCollection()
        {
            this.WorksCollection = new ObservableCollection<WorkWithMaterialAndMachinery>();
            foreach (Rule r in DataModel.Rules)
            {
                if (!ExistInCollection(r.WorkName))
                    WorksCollection.Add(new WorkWithMaterialAndMachinery(GetWorkByName(r.WorkName)));
            }
        }
        Work GetWorkByName(string name)
        {
            foreach (Work w in DataModel.Works)
            {
                if (w.WorkName == name)
                    return w;
            }
            return null;
        }

    }
    
}
