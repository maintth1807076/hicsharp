using System;
using System.Collections.Generic;
using HiCSharp.entity;
using HiCSharp.model;

namespace HiCSharp.controller
{
    public class StudentController
    {
        private StudentModel model = new StudentModel();

        public void addStudent()
        {
            Student student = new Student();
            Console.WriteLine("Please enter student rollnumber: ");
            student.RollNumber = Console.ReadLine();
            Console.WriteLine("Please enter student email: ");
            student.Email = Console.ReadLine();
            Console.WriteLine("Please enter student fullname: ");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Please enter student address: ");
            student.Address = Console.ReadLine();
            model.Save(student);
            Console.WriteLine("Add rooif.");
        }
        public void printList()
        {
            var model1 = new StudentModel();
            var list = model1.List();
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("List is empty. Please add student.");
                return;
            }
            Console.WriteLine("List ddaay.");
            for (int i = 0; i < list.Count; i++)
            {
                Student student = list[i];
                Console.WriteLine(student.ToString());
            }
        }
    }
}