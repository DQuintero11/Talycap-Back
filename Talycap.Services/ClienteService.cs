using Talycap.DTOs.Clientes;
using Talycap.Repositories.Interfaces;
using Talycap.Services.Interfaces;

namespace Talycap.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(
            IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<ClienteDto?> ObtenerPorIdentificacionAsync(
            string identificacion)
        {
            if (string.IsNullOrWhiteSpace(identificacion))
            {
                return null;
            }

            return await _clienteRepository
                .ObtenerPorIdentificacionAsync(identificacion);
        }
    }
}