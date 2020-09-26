using System.Threading.Tasks;

namespace Interfaces_Extensibility
{
    // Utilizing Extensibility by use of an interface (ILogger). We are able to 'hot-swap' out the behavior of our Application very easily, and 
    // thoroughly decoupled.  Notice the commented out first instance of DbMigrator we pass in a new ConsoleLogger implementation, but becasue we've 
    // extended DbMigrator through the ILogger interface, after creating a new behavior class (FileLogger), we simply swap it right into the instance call 
    // with the new parameters (in this case a file path)


    class Program
    {
        static void Main(string[] args)
        {
            //var migration1 = new DbMigrator(new ConsoleLogger());             // This was our initial implementation with the ConsoleLogger class implemented

            //migration1.Migrate();
            var dbMigrate = new DbMigrator(new FileLogger("D:\\Projects\\Logs\\dbMigLog2.txt"));        // Using an interface allows us to quickly swap in a new implementation (FileLogger class)

            dbMigrate.Migrate();
        }
    }
}
