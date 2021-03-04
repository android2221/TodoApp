using System;
using System.Reflection;
using DbUp;

namespace DatabaseMigrator
{
    class Program
    {
        static int Main(string[] args)
        {
            var connectionString = "Server=database;Database=TodoDB;User Id=SA;Password=p@ssw0rd1;";
            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsFromFileSystem("/app/dbscripts")
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(50000000);

            return 0;
        }
    }
}
