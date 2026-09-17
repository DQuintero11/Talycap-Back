using Microsoft.AspNetCore.Mvc;
using Talycap.Services.Interfaces;

namespace Talycap.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(
            IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("{identificacion}")]
        public async Task<IActionResult> ObtenerCliente(
            string identificacion)
        {
            var cliente = await _clienteService
                .ObtenerPorIdentificacionAsync(identificacion);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
    }
}