﻿namespace MezunTakipSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ogrenci", "Cinsiyet", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ogrenci", "Cinsiyet", c => c.Boolean(nullable: false));
        }
    }
}
