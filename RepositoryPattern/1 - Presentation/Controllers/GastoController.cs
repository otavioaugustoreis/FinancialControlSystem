using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Controllers;
using RepositoryPattern.Entity;

namespace RepositoryPattern._1___Presentation.Controllers
{
    public class GastoController : ControllerBase, IControllerPattern<GastoEntity>
    {
        public ActionResult<GastoEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<IEnumerable<GastoEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public ActionResult<GastoEntity> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<GastoEntity> Post(GastoEntity entidade)
        {
            throw new NotImplementedException();
        }

        public ActionResult<GastoEntity> Put(int id, GastoEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
