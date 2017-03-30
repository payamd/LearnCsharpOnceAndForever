using System;

namespace LearnCsharpOneTimeAndForever
{

    public abstract class DbConnection
    {
        private  string ConnectionString;
        private TimeSpan Timeout;
        public abstract bool ConnectionString_open();
        public abstract bool ConnectionString_close();
    }



    public class OracleDbConnection : DbConnection
    {
        public override bool ConnectionString_open()
        {
            Console.WriteLine("Oracle db connection open !!");
            return true;
        }

        public override bool ConnectionString_close()
        {
            Console.WriteLine("Oracle db connection close !!");
            return false;
        }
    }


    public class SqlDbConnection : DbConnection
    {
        public override bool ConnectionString_open()
        {
            Console.WriteLine("Sql db connection open !!");
            return true;
        }

        public override bool ConnectionString_close()
        {
            Console.WriteLine("Sql db connection close !!");
            return false;
        }
    }



}