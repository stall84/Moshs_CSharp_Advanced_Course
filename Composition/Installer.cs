namespace Composition
{
    partial class Program
    {
        public class Installer
        {
            private readonly Logger _logger;

            public Installer(Logger logger)
            {
                _logger = logger;
            }

            public void Install()
            // Composition used to bring in the functionality of the Logger class. Constructor initialized (composition)
            {
                _logger.Log("We are installing the app");
            }
        }
    }
}
