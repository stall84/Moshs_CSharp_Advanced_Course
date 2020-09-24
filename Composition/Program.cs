namespace Composition
{
    partial class Program
       // Class composition, in contrast with Class inheritance is relatively simple in that you compose the
       // required class inside the class you need it. Setting a field/property, then initializing it.
    {

        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}


// Inheritance generally results in much tighter-coupling of classes whereas Composition
// allows for much looser-coupling (less side effects when one class is changed).
// Composition requires a little extra work/code, but the advantage is looser coupling.
