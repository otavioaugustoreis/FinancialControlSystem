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

        [HttpGet]
        public ActionResult<IEnumerable<LoginEntity>> Get()
        {
            return Ok(_uof._Login.Get());
        }

        [HttpGet("login/{id:int}")]
        public ActionResult<LoginEntity> GetId(int id)
        {
            LoginEntity loginEntity = _uof._Login.GetId(l => l.Id == id);
            
            if(loginEntity is null) return NotFound("Login não encontrado");

            return Ok(loginEntity);
        }

        [HttpPost]
        public ActionResult<LoginEntity> Post(LoginEntity entidade)
        {
            _uof._Login.Post(entidade);
            _uof.Commit();
            return new CreatedAtRouteResult("UsuarioCriado", new { id = entidade.Id }, entidade);
        }

        [HttpPut("{id:int}")]
        public ActionResult<LoginEntity> Put(int id, LoginEntity t)
        {
            _uof._Login.Put(t);
            _uof.Commit();
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public ActionResult<LoginEntity> Delete(int id)
        {
            LoginEntity login = _uof._Login.GetId(p => p.Id == id);

            if (login is null) return NotFound();
            return NoContent();

        }
    }
}
