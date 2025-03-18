using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Siniflar
{
    public class Context : DbContext  //DbContext sınıfından miras almam gerekiyor
    {
        //buranın üzerinden tabloları sql'e yansıtıcam,backend kısmında tablolarıma buradan ulaşıcam
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }
        public DbSet<Faturalar> Faturalars { get; set; }
        public DbSet<Gider> Giders { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<SatisHareket> SatisHarekets { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Detay> Detays { get; set; }
        public DbSet<Yapilacak> Yapilacaks { get; set;}
        public DbSet<KargoDetay> KargoDetays { get; set;}
        public DbSet<KargoTakip> KargoTakips { get; set;}
        public DbSet<mesajlar> mesajlars { get; set;}
    
    }
}