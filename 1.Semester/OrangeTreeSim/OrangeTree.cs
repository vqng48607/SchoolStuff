using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age 
        {
            set { 
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    this.age = 0;
                }
            }
            get { return age; }
        }

        public int Height
        {
            set { height = value; }
            get { return height; }
        }

        public bool TreeAlive
        {
            set { treeAlive = value; }
            get { return treeAlive; }
        }

        public int NumOranges
        {
            get { return numOranges; }
        }

        public int OrangesEaten
        {
            get { return orangesEaten; }
        }

        public void OneYearPasses()
        {
            age = age + 1;
            orangesEaten = 0;

            if (age < 80)
            {
                height = height + 2;
                treeAlive = true;
                numOranges = (age - 1) * 5;
            }
            else if (age >= 80)
            {
                treeAlive = false;
                numOranges = 0;
            }

        }
        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten = orangesEaten + count;
                numOranges = numOranges - count;
            }

        }
    }



}
