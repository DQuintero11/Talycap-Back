using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talycap.DTOs.Clientes
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public string Identificacion { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }
    }
}