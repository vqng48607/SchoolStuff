using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindfrydWPF
{
    public class FlowerSort
    {
        public string Name { get; set; }

        public string PicturePath { get; set; }

        public int ProductionTime { get; set; }

        public int HalfLifeTime { get; set; }

        public int Size { get; set; }

        public FlowerSort(string name, string picturePath, int productionTime, int halfLifeTime, int size)
        {
            Name = name;
            this.PicturePath = picturePath;
            this.ProductionTime = productionTime;
            this.HalfLifeTime = halfLifeTime;
            this.Size = size;
        }

        public override string ToString()
        {
            return "Flower name: " + Name + "\n Picture path: " + PicturePath + "\n Production time: " + ProductionTime + "\n Half Life Time: " + HalfLifeTime + "\n Size: " + Size;
        }
    }

   
}
