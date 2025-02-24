using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.Services;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        /// <summary>
        /// Obtém todos os usuários.
        /// </summary>
        /// <returns>Uma lista de usuários.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> GetUsuarios()
        {
            var usuarios = _usuarioService.GetUsuarios();
            return Ok(usuarios);
        }

        /// <summary>
        /// Obtém um usuário pelo ID.
        /// </summary>
        /// <param name="id">O ID do usuário.</param>
        /// <returns>O usuário correspondente ao ID.</returns>
        [HttpGet("{id}")]
        public ActionResult<Usuario> GetUsuario(int id)
        {
            var usuario = _usuarioService.GetUsuario(id);
            if (usuario == null)
            {
                return NotFound(new { message = "Usuário não encontrado." });
            }
            return Ok(usuario);
        }

        /// <summary>
        /// Cria um novo usuário.
        /// </summary>
        /// <param name="usuario">Os dados do usuário.</param>
        /// <returns>O usuário criado.</returns>
        [HttpPost]
        public ActionResult<Usuario> PostUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest(new { message = "Dados inválidos." });
            }

            var createdUsuario = _usuarioService.CreateUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = createdUsuario.Id }, createdUsuario);
        }

        /// <summary>
        /// Atualiza um usuário existente.
        /// </summary>
        /// <param name="id">O ID do usuário.</param>
        /// <param name="usuario">Os dados atualizados do usuário.</param>
        /// <returns>Resposta apropriada.</returns>
        [HttpPut("{id}")]
        public IActionResult PutUsuario(int id, [FromBody] Usuario usuario)
        {
            if (usuario == null || id != usuario.Id)
            {
                return BadRequest(new { message = "ID inválido ou dados do usuário incorretos." });
            }

            var updated = _usuarioService.UpdateUsuario(usuario);
            if (!updated)
            {
                return NotFound(new { message = "Usuário não encontrado para atualização." });
            }

            return NoContent();
        }

        /// <summary>
        /// Exclui um usuário.
        /// </summary>
        /// <param name="id">O ID do usuário.</param>
        /// <returns>Resposta apropriada.</returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            var deleted = _usuarioService.DeleteUsuario(id);
            if (!deleted)
            {
                return NotFound(new { message = "Usuário não encontrado para exclusão." });
            }

            return NoContent();
        }
    }
}
