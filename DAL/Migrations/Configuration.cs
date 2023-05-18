namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Policy;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Model.TravelAgencyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Model.TravelAgencyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*for (int i = 1; i <= 5; i++)
            {
                context.Admins.AddOrUpdate(new Model.Admin
                {
                    Id = i,
                    Username = Guid.NewGuid().ToString().Substring(0, 10),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Password = Guid.NewGuid().ToString().Substring(0, 4),
                });
            }
            for (int i =1; i <= 5; i++)
            {
                context.Packages_Inclusions.AddOrUpdate(new Model.Package_Inclusion
                {
                    Inclusion_Id = "" + i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Phone = Guid.NewGuid().ToString().Substring(0, 12),
                    Location = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 4),
                });
            }
            for (int i=1; i<=10;i++)
            {
                context.Travellers.AddOrUpdate(new Model.Traveller
                {
                    TId = "" + i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Phone = Guid.NewGuid().ToString().Substring(0, 12),
                    Password = Guid.NewGuid().ToString().Substring(0, 4),
                });
            }*/
        }
    }
}
