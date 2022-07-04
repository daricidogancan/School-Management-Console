using Okulyonetim.App.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulyonetim.App.Database
{
    public class OkulContext:DbContext
    {
        public OkulContext():base(@"server=.\SQLEXPRESS;database=OkulDb;trusted_connection=true;")
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Servis> Servisler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
    }
}
