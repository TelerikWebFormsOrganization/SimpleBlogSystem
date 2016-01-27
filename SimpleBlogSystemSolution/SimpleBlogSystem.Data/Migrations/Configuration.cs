namespace SimpleBlogSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SimpleBlogSystem.Data.SimpleBlogSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SimpleBlogSystem.Data.SimpleBlogSystemDbContext context)
        {
            
        }
    }
}
