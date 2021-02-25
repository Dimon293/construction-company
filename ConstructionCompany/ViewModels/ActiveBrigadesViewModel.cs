using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;

namespace ConstructionCompany.ViewModels
{
    class ActiveBrigadesViewModel
    {
        public ObservableCollection<Brigade> BrigadesCollection { get; set; }
        public ActiveBrigadesViewModel()
        {
            BrigadesCollection = new ObservableCollection<Brigade>();
            FillBrigadesCollection();
        }
        void FillBrigadesCollection()
        {
            foreach(Brigade b in DataModel.Brigades)
            {
                if (b.IsActive)
                    BrigadesCollection.Add(b);
            }
        }
    }
}
