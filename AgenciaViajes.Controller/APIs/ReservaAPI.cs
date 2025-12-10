using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaViajes.Controller.Assemblers;
using AgenciaViajes.Controller.DTOs;
using AgenciaViajes.Model;

namespace AgenciaViajes.Controller.APIs
{
    //ReservaAPI --> Clase que gestiona las operaciones de reservas
    public class ReservaAPI
    {
        private readonly RepositorioReservas repo = new RepositorioReservas();

        //Listar() --> Devuelve todas las reservas en forma de DTO
        public List<ReservaDTO> Listar()
        {
            var reservas = repo.Seleccionar();
            return ReservaAssembler.ToDTOList(reservas);
        }

        //PorCliente() --> Devuelve las reservas de un cliente concreto
        public List<ReservaDTO> PorCliente(int idCliente)
        {
            var reservas = repo.SeleccionarPorCliente(idCliente);
            return ReservaAssembler.ToDTOList(reservas);
        }

        //PorViaje() --> Devuelve las reservas de un viaje concreto
        public List<ReservaDTO> PorViaje(int idViaje)
        {
            var reservas = repo.SeleccionarPorViaje(idViaje);
            return ReservaAssembler.ToDTOList(reservas);
        }

        //Crear() --> Crea una nueva reserva
        public void Crear(int idCliente, int idViaje, DateTime fechaReserva)
        {
            ValidarReserva(fechaReserva); //Validamos la fecha de reserva

            var dto = new ReservaDTO { IdCliente = idCliente, IdViaje = idViaje, FechaReserva = fechaReserva.Date };
            var entity = ReservaAssembler.ToEntity(dto);
            repo.CrearReserva(entity);
        }

        //Cancelar() --> Cancela una reserva por su ID
        public void Cancelar(int idReserva)
        {
            repo.CancelarReserva(idReserva);
        }

        //ValidarReserva() --> Comprueba que la fecha no sea pasada
        private void ValidarReserva(DateTime fechaReserva)
        {
            if (fechaReserva.Date < DateTime.Today)
            {
                throw new ArgumentException("La fecha de reserva no puede ser pasada.");
            } 
        }
    }
}
