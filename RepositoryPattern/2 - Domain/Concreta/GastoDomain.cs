using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class GastoDomain : Repository<GastoEntity>, IGasto
    {
        public GastoDomain(AppDbContext context) : base(context)
        {
        }

        public void AdicionarGasto()
        {
            return;
        }
    }
}
