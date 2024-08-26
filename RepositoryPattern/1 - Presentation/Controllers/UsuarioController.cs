using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Controllers;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;
using RepositoryPattern.UnitOfWork;

namespace RepositoryPattern._1___Presentation.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase, IControllerPattern<UsuarioEntity>
    {
        private readonly IUnitOfWork  _uof;

        public ActionResult<IEnumerable<UsuarioEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public ActionResult<UsuarioEntity> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<UsuarioEntity> Post(UsuarioEntity entidade)
        {
            throw new NotImplementedException();
        }

        public ActionResult<UsuarioEntity> Put(int id, UsuarioEntity t)
        {
            throw new NotImplementedException();
        }
        public ActionResult<UsuarioEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
