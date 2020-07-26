using System;
using CadastroUsuario.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroUsuario.Service
{
    public class UsuarioAutenticacao
    {
        public static bool Login(string login, string senha)
        {
            using (meuBanco db = new meuBanco())
            {
                return db.usuariosSistema.Any(user => user.Login.Equals(login, StringComparison.OrdinalIgnoreCase) && user.Senha == senha);
                    
            }

        }

    }



}