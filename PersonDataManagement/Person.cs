using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class Person
    {
        public string SSN;
        public string name;
        public string address;
        public int age;

        public Person(string SSN, string name, string address, int age)
        {
            this.SSN = SSN;
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
