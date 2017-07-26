using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UralsibTask.Models
{
    public class MarcsInitializer : DropCreateDatabaseAlways<AutoContext>
    {
        protected override void Seed(AutoContext db)
        {
            db.Marcs.Add(new Marcs { Id = 1, IdBrand = 1, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 2, IdBrand = 1, AutoMarc = "A6", Activity = true });
            db.Marcs.Add(new Marcs { Id = 3, IdBrand = 1, AutoMarc = "A4 Avant", Activity = true });
            db.Marcs.Add(new Marcs { Id = 4, IdBrand = 2, AutoMarc = "Focus", Activity = true });
            db.Marcs.Add(new Marcs { Id = 5, IdBrand = 2, AutoMarc = "Mustang", Activity = true });
            db.Marcs.Add(new Marcs { Id = 6, IdBrand = 2, AutoMarc = "Shelby", Activity = true });
            db.Marcs.Add(new Marcs { Id = 7, IdBrand = 3, AutoMarc = "w124", Activity = true });
            db.Marcs.Add(new Marcs { Id = 8, IdBrand = 3, AutoMarc = "w123", Activity = true });
            db.Marcs.Add(new Marcs { Id = 9, IdBrand = 3, AutoMarc = "w125", Activity = true });
            db.Marcs.Add(new Marcs { Id = 10, IdBrand = 4, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 11, IdBrand = 4, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 12, IdBrand = 4, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 13, IdBrand = 1, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 14, IdBrand = 1, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 15, IdBrand = 1, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 16, IdBrand = 1, AutoMarc = "TT Roadster", Activity = true });
            db.Marcs.Add(new Marcs { Id = 17, IdBrand = 1, AutoMarc = "TT Roadster", Activity = true });
            base.Seed(db);
        }
    }
}