using System;

namespace _2K19
{
    public class SqlConnection : DbConnection
    {


        public override void OpenConnection()
        {
            Console.WriteLine("SQL Connection open");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL Connection close");
        }

        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
    }
}