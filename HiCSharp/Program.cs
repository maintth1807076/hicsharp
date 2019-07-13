using System;
using System.Collections.Generic;
using HiCSharp.controller;
using HiCSharp.entity;
using HiCSharp.model;
using MySql.Data.MySqlClient;

namespace HiCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new StudentController();
            while (true)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Menu Manage Student");
                Console.WriteLine("1. Add student.");
                Console.WriteLine("2. Print student list.");
                Console.WriteLine("3. Update student information.");
                Console.WriteLine("4. Delete student.");
                Console.WriteLine("5. Close.");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Please select number in (1,2,3,4,5)");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        controller.addStudent();
                        break;  
                    case 2:
                        controller.printList();
                        break; 
                    case 3:
                        break;  
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Bye bye.");
                        break;
                    default:
                        Console.WriteLine("Please select again.");
                        break;
                }
                if (choice == 5)
                {
                    break;
                }
            }
        }
    }
}