﻿using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class LoginDomain : Repository<LoginEntity>, ILogin 
    {
        public LoginDomain(AppDbContext context) : base(context)
        {
        }

        public void CadastrarLogin(UsuarioEntity usuarioEntity)
        {
            if(usuarioEntity is null) return;
        }
    }
}
