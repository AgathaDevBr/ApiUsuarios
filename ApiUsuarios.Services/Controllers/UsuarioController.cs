using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuarios.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Serviço para autenticação de usuários.
        /// </summary>
        [HttpPost]
        [Route("Autenticar")]
        public IActionResult Autenticar()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para criação de usuários.
        /// </summary>
        [HttpPost]
        [Route("CriarConta")]
        public IActionResult CriarConta()
        {
            return Ok();
        }
    }
}
