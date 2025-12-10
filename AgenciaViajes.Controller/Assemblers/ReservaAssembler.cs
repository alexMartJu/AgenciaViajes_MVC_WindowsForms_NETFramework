using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaViajes.Controller.DTOs;
using AgenciaViajes.Model;

namespace AgenciaViajes.Controller.Assemblers
{
    //ReservaAssembler --> Clase que convierte entre ReservaDTO y la entidad Reservas
    public static class ReservaAssembler
    {
        //ToDTO() --> Convierte un objeto de tipo Reservas en un ReservaDTO
        public static ReservaDTO ToDTO(Reservas reserva)
        {
            return new ReservaDTO
            {
                IdReserva = reserva.IdReserva,
                IdCliente = reserva.IdCliente,
                IdViaje = reserva.IdViaje,
                FechaReserva = reserva.FechaReserva
            };
        }

        //ToEntity() --> Convierte un ReservaDTO en un objeto de tipo Reservas
        public static Reservas ToEntity(ReservaDTO dto)
        {
            return new Reservas
            {
                IdReserva = dto.IdReserva,
                IdCliente = dto.IdCliente,
                IdViaje = dto.IdViaje,
                FechaReserva = dto.FechaReserva
            };
        }

        //ToDTOList() --> Convierte una lista de Reservas en una lista de ReservaDT
        public static List<ReservaDTO> ToDTOList(List<Reservas> reservas)
        {
            return reservas.Select(r => ToDTO(r)).ToList();
        }
    }
}
