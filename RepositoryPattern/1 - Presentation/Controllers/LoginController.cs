using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Controllers;

using RepositoryPattern.Entity;

namespace RepositoryPattern._1___Presentation.Controllers
{
    public class LoginController : ControllerBase, IControllerPattern<LoginEntity>
    {
        public ActionResult<LoginEntity> Delete(int id)
        {
            throw new NotImplementedException();
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
