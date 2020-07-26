namespace CadastroUsuario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluirPKTabelaUsuariosSistemas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UsuarioSistemas", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UsuarioSistemas", "ID");

        }
        
        public override void Down()
        {

        }
    }
}
