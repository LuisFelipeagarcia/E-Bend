namespace E_Bend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DobradorModels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(nullable: false),
                    Ano_Cad = c.Int(nullable: false),
                    Elemento = c.String(nullable: false),
                    Telefone = c.String(),
                    Email = c.String(),
                    EquipeId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipeModels", t => t.EquipeId)
                .Index(t => t.EquipeId);

            CreateTable(
                "dbo.EquipeModels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(nullable: false),
                    Disputas = c.Int(nullable: false),
                    Vitorias = c.Int(nullable: false),
                    Derrotas = c.Int(nullable: false),
                    Ano_Fund = c.Int(nullable: false),
                    Ativo = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.DobradorModels", "EquipeId", "dbo.EquipeModels");
            DropIndex("dbo.DobradorModels", new[] { "EquipeId" });
            DropTable("dbo.EquipeModels");
            DropTable("dbo.DobradorModels");
        }
    }
}
