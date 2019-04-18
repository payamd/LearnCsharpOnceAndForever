using System;

namespace _2K19
{
    public class OracleConnection:DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("open oracle connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("close oracle connection");
        }
    }
}