using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talycap.DTOs.Clientes;

namespace Talycap.Services.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDto?> ObtenerPorIdentificacionAsync(
            string identificacion);
    }
}
