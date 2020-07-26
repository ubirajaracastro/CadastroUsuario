using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroUsuario.Models
{
    public class meuBanco:DbContext
    {
        public meuBanco() : base("bancoDados")
        {

        }

        public DbSet<Cidade> cidades { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<UsuarioSistema> usuariosSistema { get; set; }

    }
}