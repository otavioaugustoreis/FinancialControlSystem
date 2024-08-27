using RepositoryPattern._2___Domain.Concreta;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Interface
{
    public interface ILogin : IRepository<LoginEntity>
    {
        public void CadastrarLogin(UsuarioEntity usuarioEntity);
    }
}
