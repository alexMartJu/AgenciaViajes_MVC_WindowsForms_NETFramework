using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaViajes.Controller.DTOs;
using AgenciaViajes.Model;

namespace AgenciaViajes.Controller.Assemblers
{
    //ClienteAssembler --> Clase que convierte entre ClienteDTO y la entidad Clientes
    public static class ClienteAssembler
    {
        //ToDTO() --> Convierte un objeto de tipo Clientes en un ClienteDTO
        public static ClienteDTO ToDTO(Clientes cliente)
        {
            return new ClienteDTO
            {
                IdCliente = cliente.IdCliente,
                Nombre = cliente.Nombre,
                Apellidos = cliente.Apellidos,
                Email = cliente.Email
            };
        }

        //ToEntity() --> Convierte un ClienteDTO en un objeto de tipo Clientes
        public static Clientes ToEntity(ClienteDTO dto)
        {
            return new Clientes
            {
                IdCliente = dto.IdCliente,
                Nombre = dto.Nombre,
                Apellidos = dto.Apellidos,
                Email = dto.Email
            };
        }

        //ToDTOList() --> Convierte una lista de Clientes en una lista de ClienteDTO
        public static List<ClienteDTO> ToDTOList(List<Clientes> clientes)
        {
            return clientes.Select(c => ToDTO(c)).ToList();
        }
    }
}
