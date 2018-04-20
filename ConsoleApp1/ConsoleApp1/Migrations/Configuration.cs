/*
 * Description: This file represents the Configuration class
 * Author: Mtsharif 
 * Date: 27/2/2018
 */
 
namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /// <summary>
    /// This class includes the configuration that allows automatic migrations
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApp1.Models.WorkflowManagementSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ConsoleApp1.Models.WorkflowManagementSystemDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
