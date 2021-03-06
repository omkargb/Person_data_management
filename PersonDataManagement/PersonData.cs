using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    class PersonData
    {
        //variable for storing person data - list
        List<Person> personList=new List<Person>();

        //adding default values to list and displaying
        public void NewList()
        {
            // ssn, name, address, age
            personList.Add(new Person("p1", "Ramesh", "Kolkata", 14));
            personList.Add(new Person("p2", "John", "Delhi", 17));
            personList.Add(new Person("p3", "Omkar", "Pune", 26));
            personList.Add(new Person("p4", "Suresh","Mumbai", 32));
            personList.Add(new Person("p5", "Rita", "Kolkata", 49));
            personList.Add(new Person("p6", "Neha", "Keral", 61));
            personList.Add(new Person("p7", "Chetan", "Pune", 65));

            DisplayPerson(personList);
        }

        public void ListTop2RecordsAgeLessThan60()
        {
            List<Person> lip = 
                personList
                .FindAll(person => person.age < 60)  //find
                .OrderBy(x => x.age)        //sort
                .Take(2)                    //select
                .ToList();                  //save

            DisplayPerson(lip);
        }
        
        public void RecordsBetweenGivenAge()
        {
            List<Person> lip = 
                personList
                .FindAll(person => person.age > 13 && person.age < 18);
            DisplayPerson(lip);
        }
        
        public void CalculateAverageAge()
        {
            double averageAge = 
                personList
                .Average(person => person.age); 
            Console.WriteLine("\n 4] Average Age is : "+averageAge.ToString("#.000"));   //3 digits after decimal
        }        

        public void SearchValue(string term)
        {
            bool value =
                personList
                .Contains(personList
                .FirstOrDefault(x => x.name.ToUpper()      //return first element if found
                .Equals(term.ToUpper()) )    ); 

            if(value==true)
            {   Console.WriteLine("\n Search term matched. Value found. \n");   }
            else 
            {   Console.WriteLine("\n Search term not matched. Value not found. \n");   }
        }

        public void SkipRecords()
        {
            List<Person> lip = personList
                .FindAll(person => person.age < 60)
                .Skip(3)    //skip first n records and save remaining
                .ToList();

            DisplayPerson(lip);
        }

        public void RemoveRecord(string term)
        {
            bool removed = personList
                .Remove(personList
                .FirstOrDefault(p => p.name.ToUpper()
                .Equals(term.ToUpper()) ) );

            if (removed == true)
            { Console.WriteLine("\n Search term matched. Value removed. "); }
            else
            { Console.WriteLine("\n Search term not matched. Value not removed. "); }

            DisplayPerson(personList);
        }

        void DisplayPerson(List<Person> people)
        {
            Console.WriteLine("\n Displaying person list : ");
            foreach(var p in people)
            {
                Console.WriteLine(" SSN : "+p.SSN+" \t Name : "+p.name+"\t\t Address : "+p.address+"\t\t Age : "+p.age);
            }
        }
    }
}
