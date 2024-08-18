using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class ReceitaDomain : Repository<ReceitaEntity>, IReceita
    {
        public ReceitaDomain(AppDbContext context) : base(context)
        {
        }
    }
}
