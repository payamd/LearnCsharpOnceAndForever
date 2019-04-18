using System;

namespace _2K19
{
    public class DbCommands
    {
        private readonly DbConnection _dbConnection;


        public DbCommands(DbConnection dbConnection)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
        }
            
        
        public void Execute()
        {
            Console.WriteLine("open connection " + _dbConnection.ConnectionString);
            Console.WriteLine("run istruction");
            Console.WriteLine("close connection " + _dbConnection.ConnectionString);
        }

    }
}