using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace HiCSharp.model
{
    public class ConnectionHelper
    {
        private const string ServerName = "localhost";
        private const string DatabaseName = "myschool";
        private const string Username = "root";
        private const string Password = "";
        private MySqlConnection cnn;
        

        public void Connect()
        {
            
            var cnnString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};SslMode=none", ServerName,
                DatabaseName, Username, Password);
            this.cnn = new MySqlConnection(cnnString);
            cnn.Open();
        }

        public MySqlConnection Cnn
        {
            get => cnn;
            set => cnn = value;
        }
    }
}