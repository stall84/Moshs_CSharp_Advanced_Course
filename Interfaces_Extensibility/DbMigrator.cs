using System;

namespace Interfaces_Extensibility
{
    // Notice how we don't change the code within DbMigrator when we completely changed the behavior of our App by creating and implementing 
    // FileLogger after initially using ConsoleLogger.  This is the concept of extensibility. This is called Open-Closed-Principal (OCP).
    // Meaning software entities should be Open for extension, but Closed for modification. This is exactly what we have in this project.
    // This DbMigrator class is CLOSED to modification, However in the constructor, where we inject the ILogger Interface, we OPEN it to extension.

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)           // This is Dependency Injection: Adding/Specifying the dependencies the class relies on in the constructor 
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration STARTED at {DateTime.Now}");

            _logger.LogInfo($"Migration COMPLETED at {DateTime.Now}");
            
            
        }
    }
}
