using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Controller.DTOs
{
    //ClienteDTO --> Clase que representa los datos de un cliente
    public class ClienteDTO
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellidos}";
    }
}
