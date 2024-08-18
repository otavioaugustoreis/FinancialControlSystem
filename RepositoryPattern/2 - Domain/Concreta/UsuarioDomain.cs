using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class UsuarioDomain : Repository<UsuarioEntity>, IUsuario
    {

        public UsuarioDomain(AppDbContext context) : base(context)
        {
        }

    }
}
