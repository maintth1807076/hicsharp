using System;

namespace HiCSharp.entity
{
    public class Student
    {
        private string _address;

        public Student(string rollNumber, string email, string fullName, string address)
        {
            RollNumber = rollNumber;
            Email = email;
            FullName = fullName;
            _address = address;
        }

        public Student()
        {
        }

        public string RollNumber { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public override string ToString()
        {
            string informStudent = String.Format("RollNumber: {0}, FullName: {1}, Address: {2}, Email: {3}.",  
                RollNumber, FullName, _address, Email);
            return informStudent;
        }
    }
}