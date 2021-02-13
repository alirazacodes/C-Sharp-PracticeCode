using System;

namespace InterfacesAndExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration Stated at {0}" +  DateTime.Now);

            _logger.LogInfo("Migration Finished at {0}" + DateTime.Now);

        }
    }
}