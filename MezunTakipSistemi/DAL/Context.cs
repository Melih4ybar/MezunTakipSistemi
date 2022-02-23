using MezunTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MezunTakipSistemi.DAL
{
    public class Context:DbContext
    {
        public Context() : base("MezunKayitSistemi") { }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Admin> Yoneticiler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Duyuru> Duyurular { get; set; }
        public DbSet<Ilan> Ilanlar { get; set; }
        public DbSet<Etkinlik> Etkinlikler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}