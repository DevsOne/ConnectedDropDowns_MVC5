namespace ConnectedDropDowns_MVC5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConnectedDropDowns_MVC5.Models.DropDownDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.DropDownDbContext context)
        {
            context.Countries.AddOrUpdate(new Models.Country { ID = "1", Name = "United States" });
            context.Countries.AddOrUpdate(new Models.Country { ID = "2", Name = "Canada" });
            context.Countries.AddOrUpdate(new Models.Country { ID = "3", Name = "Australia" });


            context.States.AddOrUpdate(new Models.State { ID = "1", Name = "Florida", CountryId = "1" });
            context.States.AddOrUpdate(new Models.State { ID = "2", Name = "Nevada", CountryId = "1" });
            context.States.AddOrUpdate(new Models.State { ID = "3", Name = "California", CountryId = "1" });
            context.States.AddOrUpdate(new Models.State { ID = "4", Name = "Ontario", CountryId = "2" });
            context.States.AddOrUpdate(new Models.State { ID = "5", Name = "Quebec", CountryId = "2" });
            context.States.AddOrUpdate(new Models.State { ID = "6", Name = "New Brunswick", CountryId = "2" });
            context.States.AddOrUpdate(new Models.State { ID = "7", Name = "Queensland", CountryId = "3" });
            context.States.AddOrUpdate(new Models.State { ID = "8", Name = "Tasmania", CountryId = "3" });


            context.Cities.AddOrUpdate(new Models.City { ID = "1", Name = "Miami", StateId = "1" });
            context.Cities.AddOrUpdate(new Models.City { ID = "2", Name = "Orlando", StateId = "1" });
            context.Cities.AddOrUpdate(new Models.City { ID = "3", Name = "Jacksonville", StateId = "1" });
            context.Cities.AddOrUpdate(new Models.City { ID = "4", Name = "Las Vegas", StateId = "2" });
            context.Cities.AddOrUpdate(new Models.City { ID = "5", Name = "Reno", StateId = "2" });
            context.Cities.AddOrUpdate(new Models.City { ID = "6", Name = "Carson City", StateId = "2" });
            context.Cities.AddOrUpdate(new Models.City { ID = "7", Name = "Los Angeles", StateId = "3" });
            context.Cities.AddOrUpdate(new Models.City { ID = "8", Name = "Sacramento", StateId = "3" });
            context.Cities.AddOrUpdate(new Models.City { ID = "9", Name = "Riverside", StateId = "3" });
            context.Cities.AddOrUpdate(new Models.City { ID = "10", Name = "Toronto", StateId = "4" });
            context.Cities.AddOrUpdate(new Models.City { ID = "11", Name = "Ottawa", StateId = "4" });
            context.Cities.AddOrUpdate(new Models.City { ID = "12", Name = "Niagara Falls", StateId = "4" });
            context.Cities.AddOrUpdate(new Models.City { ID = "13", Name = "Quebec City", StateId = "5" });
            context.Cities.AddOrUpdate(new Models.City { ID = "14", Name = "Montreal", StateId = "5" });
            context.Cities.AddOrUpdate(new Models.City { ID = "15", Name = "Trois-Rivières", StateId = "5" });
            context.Cities.AddOrUpdate(new Models.City { ID = "16", Name = "Edmunston", StateId = "6" });
            context.Cities.AddOrUpdate(new Models.City { ID = "17", Name = "Saint John", StateId = "6" });
            context.Cities.AddOrUpdate(new Models.City { ID = "18", Name = "Campbellton", StateId = "6" });
            context.Cities.AddOrUpdate(new Models.City { ID = "19", Name = "Brisbane", StateId = "7" });
            context.Cities.AddOrUpdate(new Models.City { ID = "20", Name = "Mackay", StateId = "7" });
            context.Cities.AddOrUpdate(new Models.City { ID = "21", Name = "Townsville", StateId = "7" });
            context.Cities.AddOrUpdate(new Models.City { ID = "22", Name = "Devonport", StateId = "8" });
            context.Cities.AddOrUpdate(new Models.City { ID = "23", Name = "Launceston", StateId = "8" });
            context.Cities.AddOrUpdate(new Models.City { ID = "24", Name = "Strahan", StateId = "8" });
        }

    }
}
