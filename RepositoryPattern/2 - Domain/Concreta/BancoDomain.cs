using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class BancoDomain : Repository<BancoEntity>, IBanco
    {
        public BancoDomain(AppDbContext context) : base(context)
        {
        }
    }
}
