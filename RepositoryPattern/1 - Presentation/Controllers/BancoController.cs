using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Controllers;

namespace RepositoryPattern._1___Presentation.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class BancoController : ControllerBase, IControllerPattern<BancoEntity>
    {
        
        public ActionResult<BancoEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<IEnumerable<BancoEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public ActionResult<BancoEntity> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<BancoEntity> Post(BancoEntity entidade)
        {
            throw new NotImplementedException();
        }

        public ActionResult<BancoEntity> Put(int id, BancoEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
