using Microsoft.AspNetCore.Mvc;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Controllers;
using RepositoryPattern.Entity;
using RepositoryPattern.Repository;
using RepositoryPattern.UnitOfWork;

namespace RepositoryPattern._1___Presentation.Controllers
{
    /*GET:

Retorno Padrão: Ok(T result) ou NotFound().
Descrição: Retorna os dados solicitados (com Ok) ou um status 404 (NotFound) se o recurso não for encontrado.
POST (Create):

Retorno Padrão: CreatedAtAction(...) ou BadRequest().
Descrição: Retorna um status 201 (CreatedAtAction) com o local do novo recurso, ou 400 (BadRequest) se a criação falhar devido a dados inválidos.
PUT (Update):

Retorno Padrão: NoContent() ou NotFound() ou BadRequest().
Descrição: Retorna um status 204 (NoContent) quando a atualização é bem-sucedida, 404 (NotFound) se o recurso não for encontrado, ou 400 (BadRequest) para dados inválidos.
DELETE:

Retorno Padrão: NoContent() ou NotFound().
Descrição: Retorna um status 204 (NoContent) quando a exclusão é bem-sucedida ou 404 (NotFound) se o recurso não for encontrado.*/

    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase, IControllerPattern<UsuarioEntity>
    {
        private readonly IUnitOfWork  _uof;


        [HttpGet]
        public ActionResult<IEnumerable<UsuarioEntity>> Get()
        {
            return Ok(_uof._Usuario.Get());
        }


        [HttpGet("usuario/{id:int}")]
        public ActionResult<UsuarioEntity> GetId(int id)
        {
            UsuarioEntity usuarioEntity = _uof._Usuario.GetId(u => u.Id == id);

            if (usuarioEntity is null) {
              return BadRequest("Usuário não encontrado");
            }

            return Ok(usuarioEntity);
        }

        [HttpPost]
        public ActionResult<UsuarioEntity> Post(UsuarioEntity entidade)
        {
            _uof._Usuario.Post(entidade);
            _uof.Commit();
            return new CreatedAtRouteResult("UsuarioCriado", new { id = entidade.Id }, entidade);
        }

        [HttpPut("{id:int}")]
        public ActionResult<UsuarioEntity> Put(int id, UsuarioEntity t)
        {
            _uof._Usuario.Put(t);
            _uof.Commit();
            return NoContent();
        }
        public ActionResult<UsuarioEntity> Delete(int id)
        {
            UsuarioEntity entidade = _uof._Usuario.GetId(p => p.Id == id);
            _uof._Usuario?.Delete(entidade);
            _uof.Commit();
            return NoContent();
        }
    }
}
