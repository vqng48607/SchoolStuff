using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName { get { return dataFileName; } }

        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            using (StreamWriter streamWriter = new StreamWriter("Data.txt"))
            {
                streamWriter.WriteLine(person.MakeTitle());
                
            }

        }

        public Person LoadPerson()
        {

            string person;

            using (StreamReader streamreader = new StreamReader("Data.txt"))
            {
                person = streamreader.ReadLine();
            }


            string input = person;
            string[] personArray = input.Split(";");

            foreach (string value in personArray)
            {
                Console.WriteLine(value);
            }

            Person person1 = new Person(personArray[0], DateTime.Parse(personArray[1]), Double.Parse(personArray[2]), bool.Parse(personArray[3]), int.Parse(personArray[4]));
            

            return person1;
        }

        public void SavePersons(Person[] persons)
        {
            using (StreamWriter streamWriter = new StreamWriter("Data.txt"))
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    streamWriter.WriteLine(persons[i].MakeTitle());
                }
            }
        }

        public Person[] LoadPersons()
        {
            Person[] person = new Person[30];
            using (StreamReader streamreader = new StreamReader("Data.txt"))
            {
                string input = streamreader.ReadLine();

                int personcount = 0;

                while (input != null)
                {
                    string[] inputArray = input.Split(";");
                    Person personArray = new Person(inputArray[0], DateTime.Parse(inputArray[1]), double.Parse(inputArray[2]), bool.Parse(inputArray[3]), int.Parse(inputArray[4]));
                    person[personcount++] = personArray;

                    input = streamreader.ReadLine();
                }
            }

            return person;
        }
    }
}
