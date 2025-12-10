using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Model
{
    //RepositorioReservas --> Clase que gestiona los datos de reservas en la base de datos
    public class RepositorioReservas
    {
        private readonly AgenciaViajesEntities _context = new AgenciaViajesEntities(); //Conexión con la BD

        //Seleccionar() --> Devuelve todas las reservas ordenadas por fecha
        public List<Reservas> Seleccionar()
        {
            return _context.Reservas.OrderBy(r => r.FechaReserva).ToList();
        }

        //SeleccionarPorCliente() --> Devuelve las reservas de un cliente concreto
        public List<Reservas> SeleccionarPorCliente(int idCliente)
        {
            return _context.Reservas.Where(r => r.IdCliente == idCliente).ToList();
        }

        //SeleccionarPorViaje() --> Devuelve las reservas de un viaje concreto
        public List<Reservas> SeleccionarPorViaje(int idViaje)
        {
            return _context.Reservas.Where(r => r.IdViaje == idViaje).ToList();
        }

        //CrearReserva() --> Añade una nueva reserva y resta una plaza al viaje
        public void CrearReserva(Reservas reserva)
        {
            using (var tx = _context.Database.BeginTransaction()) //Usamos transacción
            {
                try
                {
                    var viaje = _context.Viajes.Find(reserva.IdViaje);
                    if (viaje == null)
                    {
                        throw new InvalidOperationException("Viaje no existe.");
                    }
                        
                    if (viaje.PlazasDisponibles <= 0)
                    {
                        throw new InvalidOperationException("No hay plazas disponibles.");
                    }
                        
                    _context.Reservas.Add(reserva);
                    viaje.PlazasDisponibles -= 1; //Restamos una plaza
                    _context.SaveChanges();

                    tx.Commit(); //Confirmamos la transacción
                }
                catch
                {
                    tx.Rollback(); //Si falla, deshacemos los cambios
                    throw;
                }
            }
        }

        //CancelarReserva() --> Cancela una reserva y devuelve una plaza al viaje
        public void CancelarReserva(int idReserva)
        {
            using (var tx = _context.Database.BeginTransaction())
            {
                try
                {
                    var reserva = _context.Reservas.Find(idReserva);
                    if (reserva == null)
                    {
                        throw new InvalidOperationException("Reserva no existe.");
                    }
                        
                    var viaje = _context.Viajes.Find(reserva.IdViaje);
                    if (viaje == null)
                    {
                        throw new InvalidOperationException("Viaje no existe.");
                    } 
                        
                    _context.Reservas.Remove(reserva);
                    viaje.PlazasDisponibles += 1; //Devolvemos la plaza
                    _context.SaveChanges();

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
    }
}
