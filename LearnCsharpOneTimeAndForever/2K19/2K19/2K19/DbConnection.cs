using System;

namespace _2K19
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
    
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(connectionString));
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}