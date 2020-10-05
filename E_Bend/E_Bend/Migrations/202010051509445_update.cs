namespace E_Bend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DobradorModels", "EquipeId", "dbo.EquipeModels");
            DropIndex("dbo.DobradorModels", new[] { "EquipeId" });
            AddColumn("dbo.DobradorModels", "EquipeModel_Id", c => c.Int());
            CreateIndex("dbo.DobradorModels", "EquipeModel_Id");
            AddForeignKey("dbo.DobradorModels", "EquipeModel_Id", "dbo.EquipeModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DobradorModels", "EquipeModel_Id", "dbo.EquipeModels");
            DropIndex("dbo.DobradorModels", new[] { "EquipeModel_Id" });
            DropColumn("dbo.DobradorModels", "EquipeModel_Id");
            CreateIndex("dbo.DobradorModels", "EquipeId");
            AddForeignKey("dbo.DobradorModels", "EquipeId", "dbo.EquipeModels", "Id");
        }
    }
}
