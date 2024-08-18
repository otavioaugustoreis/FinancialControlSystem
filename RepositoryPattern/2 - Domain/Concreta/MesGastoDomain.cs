using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;

namespace RepositoryPattern._2___Domain.Concreta
{
    public class MesGastoDomain : Repository<MesGastoEntity>, IMesGasto
    {
        public MesGastoDomain(AppDbContext context) : base(context)
        {
        }
    }
}
