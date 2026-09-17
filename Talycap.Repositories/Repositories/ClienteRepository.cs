using Microsoft.EntityFrameworkCore;
using Talycap.DTOs.Clientes;
using Talycap.Repositories.Data;
using Talycap.Repositories.Interfaces;

namespace Talycap.Repositories.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteDbContext _context;

        public ClienteRepository(ClienteDbContext context)
        {
            _context = context;
        }
        public async Task<ClienteDto?> ObtenerPorIdentificacionAsync(
            string identificacion)
        {
            var cliente = await _context.Clientes
                .FromSqlRaw(
                    "EXEC sp_ObtenerCliente @Identificacion = {0}",
                    identificacion)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (cliente == null)
                return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                Identificacion = cliente.Identificacion,
                Nombre = cliente.Nombre,
                Correo = cliente.Correo,
                Telefono = cliente.Telefono
            };
        }
    }
}