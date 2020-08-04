namespace CadastroUsuario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoSexoTabelaUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Sexo", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Sexo");
        }
    }
}
