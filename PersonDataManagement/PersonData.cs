using System;
using System.Collections.Generic;
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
