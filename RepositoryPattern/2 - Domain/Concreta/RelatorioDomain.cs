using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class RelatorioDomain : Repository<RelatorioEntity>, IRelatorio
    {
        public RelatorioDomain(AppDbContext context) : base(context)
        {
        }
        public void AdicionarReceitaMesGastoEntioty()
        {
            throw new NotImplementedException();
        }
    }
}
