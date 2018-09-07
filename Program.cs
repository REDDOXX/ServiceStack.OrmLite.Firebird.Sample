using System;

namespace ServiceStack.OrmLite.Firebird.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "User=SYSDBA;" +
                "Password=secret;" +
                "Database=/tmp/database.fdb;" +
                "DataSource=localhost;" +
                "Port=3050;" +
                "Dialect=3;" +
                "Charset=ISO8859_1;" +
                "Role=;" +
                "Connection lifetime=15;" +
                "Pooling=true;" +
                "MinPoolSize=0;" +
                "MaxPoolSize=50;" +
                "Packet Size=8192;" +
                "ServerType=0";

            var dbFactory = new OrmLiteConnectionFactory(
                connectionString,
                FirebirdDialect.Provider);
        }
    }
}
