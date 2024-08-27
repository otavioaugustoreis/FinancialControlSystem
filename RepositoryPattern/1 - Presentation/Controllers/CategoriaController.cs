using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Controllers;
using RepositoryPattern.Entity;

namespace RepositoryPattern._1___Presentation.Controllers
{
    public class CategoriaController : ControllerBase, IControllerPattern<CategoriaEntity>
    {
        public ActionResult<CategoriaEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<IEnumerable<CategoriaEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public ActionResult<CategoriaEntity> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<CategoriaEntity> Post(CategoriaEntity entidade)
        {
            throw new NotImplementedException();
        }

        public ActionResult<CategoriaEntity> Put(int id, CategoriaEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
