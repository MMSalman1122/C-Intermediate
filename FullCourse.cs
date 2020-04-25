using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Logger
    {
        public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.log("We are migrating");
        }
    }

    public class Installer
    {
        private Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.log("Installing");
        }
    }
    class Program
    {
        public static void Main()
        {
            var dbMigrator = new DbMigrator(new Logger());


            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
          
            Console.ReadLine();
        }
     
    }
}
