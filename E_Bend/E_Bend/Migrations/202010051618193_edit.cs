namespace E_Bend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DobradorModels", "EquipeId");
            RenameColumn(table: "dbo.DobradorModels", name: "EquipeModel_Id", newName: "EquipeId");
            RenameIndex(table: "dbo.DobradorModels", name: "IX_EquipeModel_Id", newName: "IX_EquipeId");
            AddColumn("dbo.EquipeModels", "Equipe", c => c.String(nullable: false));
            DropColumn("dbo.EquipeModels", "Nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EquipeModels", "Nome", c => c.String(nullable: false));
            DropColumn("dbo.EquipeModels", "Equipe");
            RenameIndex(table: "dbo.DobradorModels", name: "IX_EquipeId", newName: "IX_EquipeModel_Id");
            RenameColumn(table: "dbo.DobradorModels", name: "EquipeId", newName: "EquipeModel_Id");
            AddColumn("dbo.DobradorModels", "EquipeId", c => c.Int());
        }
    }
}
