using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Controllers;

using RepositoryPattern.Entity;
using RepositoryPattern.UnitOfWork;

namespace RepositoryPattern._1___Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase, IControllerPattern<LoginEntity>
    {
        private readonly IUnitOfWork _uof;

        public LoginController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public ActionResult<LoginEntity> Delete(int id)
        {
            LoginEntity login = _uof._Login.GetId(p => p.Id == id);

            if(login is null) return NotFound();


        }

        public ActionResult<IEnumerable<LoginEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public ActionResult<LoginEntity> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<LoginEntity> Post(LoginEntity entidade)
        {
            throw new NotImplementedException();
        }

        public ActionResult<LoginEntity> Put(int id, LoginEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
