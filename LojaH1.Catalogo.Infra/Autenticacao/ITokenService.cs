﻿using LojaH1.Catalogo.Infra.Autenticacao.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Infra.Autenticacao
{
	public interface ITokenService
	{
		Task<string> GerarTokenJWT(TokenRequest request);
		Task<JwtSecurityToken> DecodificarTokenJWT(string protectedText);
	}
}
