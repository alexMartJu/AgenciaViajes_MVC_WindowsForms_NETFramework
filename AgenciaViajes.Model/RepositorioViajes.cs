using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Model
{
    //RepositorioViajes --> Clase que gestiona los datos de viajes en la base de datos
    public class RepositorioViajes
    {
        private readonly AgenciaViajesEntities _context = new AgenciaViajesEntities(); //Conexión con la BD

        //Seleccionar() --> Devuelve todos los viajes
        public List<Viajes> Seleccionar()
        {
            return _context.Viajes.ToList();
        }

        //Crear() --> Añade un nuevo viaje
        public void Crear(Viajes viaje)
        {
            _context.Viajes.Add(viaje);
            _context.SaveChanges();
        }

        //Actualizar() --> Modifica los datos de un viaje existente
        public void Actualizar(Viajes viaje)
        {
            var existente = _context.Viajes.Find(viaje.IdViaje);
            if (existente != null)
            {
                existente.Destino = viaje.Destino;
                existente.Precio = viaje.Precio;
                existente.PlazasDisponibles = viaje.PlazasDisponibles;

                _context.SaveChanges();
            }
        }

        //Eliminar() --> Borra un viaje si no tiene reservas
        public void Eliminar(int idViaje)
        {
            var viaje = _context.Viajes.Find(idViaje);
            if (viaje == null)
            {
                throw new InvalidOperationException("Viaje no existe.");
            }

            //Comprobamos si el viaje tiene reservas activas
            bool tieneReservas = _context.Reservas.Any(r => r.IdViaje == idViaje);
            if (tieneReservas)
            {
                throw new InvalidOperationException("No se puede eliminar el viaje porque tiene reservas activas.");
            }

            _context.Viajes.Remove(viaje);
            _context.SaveChanges();
        }
    }
}
