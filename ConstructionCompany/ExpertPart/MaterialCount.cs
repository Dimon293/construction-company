using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionCompany.Models;

namespace ConstructionCompany.ExpertPart
{
    class MaterialCount
    {
        public Material Material { get; set; }
        public string MaterialName { get { return Material.Name; } }
        public int Count { get; set; }
        public int CountingPrice { get { return Count * Material.Price; } }

        public MaterialCount(Material material, int count)
        {
            this.Material = material;
            this.Count = count;
        }
    }
}
