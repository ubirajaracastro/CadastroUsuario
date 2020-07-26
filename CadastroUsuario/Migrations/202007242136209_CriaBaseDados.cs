namespace CadastroUsuario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaBaseDados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        cod_cidade = c.Int(nullable: false, identity: true),
                        nome_cidade = c.String(nullable: false, maxLength: 100, unicode: false),
                        uf_cidade = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        cep_cidade = c.String(maxLength: 8, unicode: false),
                    })
                .PrimaryKey(t => t.cod_cidade);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        cod_cliente = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 100),
                        sobrenome = c.String(maxLength: 100),
                        cpf = c.String(),
                        telResidencial = c.String(),
                        telCelular = c.String(),
                        rg = c.String(),
                        email = c.String(),
                        cod_cidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_cliente)
                .ForeignKey("dbo.Cidades", t => t.cod_cidade, cascadeDelete: true)
                .Index(t => t.cod_cidade);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "cod_cidade", "dbo.Cidades");
            DropIndex("dbo.Usuarios", new[] { "cod_cidade" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Cidades");
        }
    }
}
