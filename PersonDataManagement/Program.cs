﻿using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to person data management program.");
            PersonData data = new PersonData();
            data.NewList();

            Console.WriteLine("\n 1] Retrieve top 2 records from the list for age is less than 60 : ");
            data.ListTop2RecordsAgeLessThan60();

            Console.WriteLine("\n 2] Retrieve all record from the list for age between 13 to 18 : ");
            data.RecordsBetweenGivenAge();
        }
    }
}
