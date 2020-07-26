using CadastroUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CadastroUsuario.Controllers
{
    public class CidadeController : ApiController
    {
        private meuBanco db = new meuBanco();

        public IQueryable<Cidade> GetCidades()
        {
            return db.cidades;
        }

        public IQueryable<Cidade> GetCidades(string nome_cidade)
        {

            var cidades = from c in db.cidades
                          where c.nome_cidade.Contains(nome_cidade)
                          select c;

            return cidades;

           
        }

    }
}
