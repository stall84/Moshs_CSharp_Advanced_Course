namespace Composition
{
    partial class Program
    {
        public class DbMigrator
        {
            private readonly Logger _logger;

            public DbMigrator(Logger logger)
            {
                _logger = logger;
            }

            public void Migrate()
                // Composition used to bring in the functionality of the Logger class. Constructor initialized (composition) above
            {
                _logger.Log("We are migrating BLAH!");
            }
        }
    }
}
