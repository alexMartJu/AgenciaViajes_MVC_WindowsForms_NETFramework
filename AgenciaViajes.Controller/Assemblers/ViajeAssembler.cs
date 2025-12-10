using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaViajes.Controller.DTOs;
using AgenciaViajes.Model;

namespace AgenciaViajes.Controller.Assemblers
{
    //ViajeAssembler --> Clase que convierte entre ViajeDTO y la entidad Viajes
    public static class ViajeAssembler
    {
        //ToDTO() --> Convierte un objeto de tipo Viajes en un ViajeDTO
        public static ViajeDTO ToDTO(Viajes viaje)
        {
            return new ViajeDTO
            {
                IdViaje = viaje.IdViaje,
                Destino = viaje.Destino,
                Precio = viaje.Precio,
                PlazasDisponibles = viaje.PlazasDisponibles
            };
        }

        //ToEntity() --> Convierte un ViajeDTO en un objeto de tipo Viajes
        public static Viajes ToEntity(ViajeDTO dto)
        {
            return new Viajes
            {
                IdViaje = dto.IdViaje,
                Destino = dto.Destino,
                Precio = dto.Precio,
                PlazasDisponibles = dto.PlazasDisponibles
            };
        }

        //ToDTOList() --> Convierte una lista de Viajes en una lista de ViajeDTO
        public static List<ViajeDTO> ToDTOList(List<Viajes> viajes)
        {
            return viajes.Select(v => ToDTO(v)).ToList();
        }
    }
}
