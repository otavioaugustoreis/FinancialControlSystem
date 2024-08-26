using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Interface
{
    public interface IReceitaMesGasto : IRepository<ReceitaMesGastoEntity>
    {
        public void AdicionarReceitaMesGastoEntioty();
    }
}
