namespace CadastroUsuario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTabelaUsuariosSistema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsuarioSistemas",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Login = c.String(nullable: false, maxLength: 100),
                    Senha = c.String(maxLength: 100),
                    Email = c.String(maxLength: 100),
                    Nome = c.String(maxLength: 100),

                });
               
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.UsuarioSistemas", "cod_cidade", "dbo.Cidades");
            //DropIndex("dbo.UsuarioSistemas", new[] { "cod_cidade" });
            //DropTable("dbo.UsuarioSistemas");
        }
    }
}
