using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UralsibTask.Models
{
    public class BrandInitializer : DropCreateDatabaseAlways<AutoContext>
    {
        protected override void Seed(AutoContext db)
        {
            db.Brands.Add(new Brand { Id = 1, BrandName = "Audi", Activity = true });
            db.Brands.Add(new Brand { Id = 2, BrandName = "Ford", Activity = true });
            db.Brands.Add(new Brand { Id = 3, BrandName = "Mercedes", Activity = false });
            db.Brands.Add(new Brand { Id = 4, BrandName = "Mercedes-Benz", Activity = true });
            db.Brands.Add(new Brand { Id = 5, BrandName = "BMW", Activity = true });
            db.Brands.Add(new Brand { Id = 6, BrandName = "Jeep", Activity = true });
            db.Brands.Add(new Brand { Id = 7, BrandName = "Toyota", Activity = true });
            db.Brands.Add(new Brand { Id = 8, BrandName = "Mazda", Activity = true });


            base.Seed(db);
        }
    }
}