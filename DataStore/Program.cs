using System;
using DataStore.Models;
using DataStore.DataContext;

namespace DataStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Store Data To Database");
            Console.WriteLine("----------------------\n");
            StoreToDB();
            Console.WriteLine("\nData Saved Succesfully!\n");
        }

        static void StoreToDB()
        {
            string name, phone_number;
            Console.WriteLine("Enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number: ");
            phone_number = Console.ReadLine();

            using (var con = new ApplicationDbContext())
            {
                Person person = new Person();
                person.name = name.ToString();
                person.phone_number = phone_number.ToString();
                con.Add(person);
                con.SaveChanges();
            }
            return;
        }
    }
}