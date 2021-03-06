﻿using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace CadastroUsuario.Service
{
    public class ProviderTokenAcesso:OAuthAuthorizationServerProvider
    {
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
             context.Validated();

            return base.ValidateClientAuthentication(context);
        }


        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            if (UsuarioAutenticacao.Login(context.UserName, context.Password))
            {
                var identidade = new ClaimsIdentity(context.Options.AuthenticationType);
                identidade.AddClaim(new Claim("UsuarioLogado", context.UserName));
                context.Validated(identidade);
            }

            else
            {
                context.SetError("Acesso Inválido! Credenciais não´são válidas!");
                
            }


            return base.GrantResourceOwnerCredentials(context);
        }
    }
}