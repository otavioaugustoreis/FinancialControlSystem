using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Repository;
using System.Linq.Expressions;

namespace RepositoryPattern._1___Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase, IRelatorio
    {
        public void AdicionarReceitaMesGastoEntioty()
        {
            throw new NotImplementedException();
        }

        public RelatorioEntity Delete(RelatorioEntity entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RelatorioEntity> Get()
        {
            throw new NotImplementedException();
        }

        public RelatorioEntity GetId(Expression<Func<RelatorioEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public RelatorioEntity Post(RelatorioEntity entidade)
        {
            throw new NotImplementedException();
        }

        public RelatorioEntity Put(RelatorioEntity entidade)
        {
            throw new NotImplementedException();
        }
    }
}
