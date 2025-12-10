using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Controller.DTOs
{
    //ViajeDTO --> Clase que representa los datos de un viaje
    public class ViajeDTO
    {
        public int IdViaje { get; set; }
        public string Destino { get; set; }
        public decimal Precio { get; set; }
        public int PlazasDisponibles { get; set; }
    }
}
