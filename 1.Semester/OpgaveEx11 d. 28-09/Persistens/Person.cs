using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistens
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        DateTime t1 = new DateTime(1900, 1, 1);

        public string Name 
        { 
            get 
            { 
                return name; 
            } 

            set 
            {
                if (value == "")
                {
                    throw new Exception("Der er opstået en fejl");
                }
                else
                {
                    name = value;
                }
            } 
        }
        public DateTime BirthDate 
        { 
            get 
            { 
                return birthDate; 
            } 

            set 
            { 
                if (value <= t1)
                {
                    throw new Exception("Der er opstået en fejl");
                }
                else
                {
                    birthDate = value;
                }
            } 
        }

        public double Height 
        { 
            get 
            { 
                return height; 
            } 

            set 
            { 
                if (value <= 0)
                {
                    throw new Exception("Der er opstået en fejl");
                }
                else
                {
                    height = value;
                }
            } 
        }
        public bool IsMarried { get { return isMarried; } set { isMarried = value; } }
        public int NoOfChildren 
        { 
            get 
            { 
                return noOfChildren; 
            } 
            set 
            { 
                if (value < 0)
                {
                    throw new Exception("Der er opstået en fejl");
                }
                else
                {
                    noOfChildren = value;
                }
            } 
        }

        public Person (string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }

        public Person(string name, DateTime birthDate, double height, bool isMarried) :
            this(name, birthDate, height, isMarried, 0)
        {
        }

        public string MakeTitle()
        {
            return Name + ";" + BirthDate.ToString() + ";" + Height.ToString() + ";" + IsMarried.ToString() + ";" + NoOfChildren.ToString();
        }


    }
}
