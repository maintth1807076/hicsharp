using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using HiCSharp.entity;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.X509;

namespace HiCSharp.model
{
    public class StudentModel
    
    {
        private ConnectionHelper connectionHelper = new ConnectionHelper();
        private List<Student> list = new List<Student>();

        public void Save(Student student)
        {
            connectionHelper.Connect();
            MySqlCommand cmd = new MySqlCommand("Insert into students (rollNumber, name, email, address) values (@rollNumber, @name, @email, @address) ",connectionHelper.Cnn);
            cmd.Parameters.AddWithValue("@rollNumber", student.RollNumber);
            cmd.Parameters.AddWithValue("@name", student.FullName);
            cmd.Parameters.AddWithValue("@email", student.Email);
            cmd.Parameters.AddWithValue("@address", student.Address);
            cmd.ExecuteNonQuery();
        }

        public List<Student> List()
        {
            connectionHelper.Connect();
            MySqlCommand cmd = new MySqlCommand("select * from students",connectionHelper.Cnn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string rollNumber = dataReader.GetString(0);
                string fullName = dataReader.GetString(1);
                string email = dataReader.GetString(2);
                string address = dataReader.GetString(3);
                Student student = new Student(rollNumber, email, fullName, address);
                list.Add(student);
            }

            return list;

        }
        
    }
    
   
}