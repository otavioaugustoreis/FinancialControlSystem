using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Interface
{
    public interface IGasto : IRepository<GastoEntity>
    {
        public void AdicionarGasto();
    }
}
