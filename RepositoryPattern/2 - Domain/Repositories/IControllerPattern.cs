using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.UnitOfWork;

namespace RepositoryPattern.Controllers
{
    public interface IControllerPattern<T>
    {
        
        public ActionResult<IEnumerable<T>> Get();
        public ActionResult<T> GetId(int id);
        public ActionResult<T> Post(T entidade);
        public ActionResult<T> Put(int id, T t);
        public ActionResult<T> Delete(int id);
    }
}
