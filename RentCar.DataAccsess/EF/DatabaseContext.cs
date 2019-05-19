using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataAccsess.EF
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Arac> Arac { get; set; }
        public DbSet<AracTakip> AracTakip { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sirket> Sirket { get; set; }
        public DbSet<Kiralama> Kiralama { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
