using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to person data management program.");
            PersonData data = new PersonData();
            data.NewList();

            Console.WriteLine("\n 2] Retrieve top 2 records from the list for age is less than 60 : ");
            data.ListTop2RecordsAgeLessThan60();

            Console.WriteLine("\n 3] Retrieve all record from the list for age between 13 to 18 : ");
            data.RecordsBetweenGivenAge();

            data.CalculateAverageAge();

            Console.WriteLine("\n 5] Searching for value in list :");
            Console.Write("\n Enter a value to search : ");
            string value = Console.ReadLine();
            data.SearchValue(value);

            Console.WriteLine("\n 6] Skip record from the list for age is less than 60");
            data.SkipRecords();

            Console.WriteLine("\n 7] Removing a value from list :");
            Console.Write("\n Enter a value to remove : ");
            string delValue = Console.ReadLine();
            data.RemoveRecord(delValue);
        }
    }
}
