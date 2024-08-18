using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class CategoriaDomain : Repository<CategoriaEntity>, ICategoria
    {
        public CategoriaDomain(AppDbContext context) : base(context)
        {
        }
    }
}
