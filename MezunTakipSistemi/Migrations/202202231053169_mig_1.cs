namespace MezunTakipSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duyuru",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Icerik = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Etkinlik",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EtkinlikAdi = c.String(),
                        Icerik = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Firma",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Sifre = c.String(),
                        SifreTekrari = c.String(),
                        CepNo = c.String(),
                        Adres = c.String(),
                        KurumTuru = c.String(),
                        Sektör = c.String(),
                        VergiDairesi = c.String(),
                        VergiNo = c.String(),
                        YetkiliTC = c.String(),
                        YetkiliUnvan = c.String(),
                        YetkiliAdi = c.String(),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ilan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IlanBaslik = c.String(),
                        IlanTanimi = c.String(),
                        Sektor = c.String(),
                        Pozisyon = c.String(),
                        SonBasvuruTarihi = c.DateTime(nullable: false),
                        Firma_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Firma", t => t.Firma_ID)
                .Index(t => t.Firma_ID);
            
            CreateTable(
                "dbo.Ogrenci",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OgrNo = c.String(),
                        Email = c.String(),
                        Sifre = c.String(),
                        SifreTekrari = c.String(),
                        Bolum = c.String(),
                        CepNo = c.String(),
                        CalismaDurumu = c.Boolean(nullable: false),
                        DogumTarihi = c.DateTime(nullable: false),
                        Cinsiyet = c.Boolean(nullable: false),
                        DogumYeri = c.String(),
                        YasadigiYer = c.String(),
                        MedeniDurum = c.String(),
                        LinkedinAdres = c.String(),
                        Adres = c.String(),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Email = c.String(),
                        Sifre = c.String(),
                        CepNo = c.String(),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ilan", "Firma_ID", "dbo.Firma");
            DropIndex("dbo.Ilan", new[] { "Firma_ID" });
            DropTable("dbo.Admin");
            DropTable("dbo.Ogrenci");
            DropTable("dbo.Ilan");
            DropTable("dbo.Firma");
            DropTable("dbo.Etkinlik");
            DropTable("dbo.Duyuru");
        }
    }
}
