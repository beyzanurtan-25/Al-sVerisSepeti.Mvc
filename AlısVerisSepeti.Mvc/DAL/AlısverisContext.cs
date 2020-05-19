using AlısVerisSepeti.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlısVerisSepeti.Mvc.DAL
{
    public class AlısverisContext:DbContext
    {
        public AlısverisContext() : base("cstr")
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Urun> Urunler{ get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Musteri>().ToTable("tblMusteriler");

            modelBuilder.Entity<Musteri>().Property(k => k.MusteriAd).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(k => k.Sehir).HasMaxLength(35).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(k => k.MusteriSoyad).HasMaxLength(35).IsRequired().HasColumnType("varchar");


            modelBuilder.Entity<Urun>().ToTable("tblUrun");

            modelBuilder.Entity<Urun>().Property(o => o.UrunAd).HasMaxLength(25).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Urun>().Property(o => o.Ozellik).HasMaxLength(25).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Urun>().Property(o => o.Fiyat).IsRequired().HasColumnType("int");
          

            modelBuilder.Entity<Kullanici>().ToTable("tblKullanici");

            modelBuilder.Entity<Kullanici>().Property(o => o.kullaniciAd).HasMaxLength(25).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Kullanici>().Property(o => o.sifre).HasMaxLength(25).IsRequired().HasColumnType("varchar");
        }
    }
}