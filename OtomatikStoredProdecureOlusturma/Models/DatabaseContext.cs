using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OtomatikStoredProdecureOlusturma.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitap>().MapToStoredProcedures(
                    config=> { config.Insert(i => i.HasName("KitapEkle"));
                    config.Update(u => u.HasName("KitapGuncelle"));
                    config.Delete(x => x.HasName("KitapSil"));

                    });
        }
    }
}