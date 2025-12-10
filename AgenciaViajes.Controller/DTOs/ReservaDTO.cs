using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Controller.DTOs
{
    public class ReservaDTO
    {
        //ReservaDTO --> Clase que representa los datos de una reserva
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdViaje { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
