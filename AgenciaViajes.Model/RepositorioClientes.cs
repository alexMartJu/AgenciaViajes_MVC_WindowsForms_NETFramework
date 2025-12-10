using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Model
{
    //RepositorioClientes --> Clase que gestiona los datos de clientes en la base de datos
    public class RepositorioClientes
    {
        private readonly AgenciaViajesEntities _context = new AgenciaViajesEntities(); //Conexión con la BD

        //Seleccionar() --> Devuelve todos los clientes
        public List<Clientes> Seleccionar()
        {
            return _context.Clientes.ToList();
        }

        //Crear() --> Añade un nuevo cliente
        public void Crear(Clientes cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        //Actualizar() --> Modifica los datos de un cliente existente
        public void Actualizar(Clientes cliente)
        {
            var existente = _context.Clientes.Find(cliente.IdCliente);
            if (existente != null)
            {
                existente.Nombre = cliente.Nombre;
                existente.Apellidos = cliente.Apellidos;
                existente.Email = cliente.Email;

                _context.SaveChanges();
            }
        }

        //Eliminar() --> Borra un cliente si no tiene reservas
        public void Eliminar(int idCliente)
        {
            var cliente = _context.Clientes.Find(idCliente);
            if (cliente == null)
            {
                throw new InvalidOperationException("Cliente no existe.");
            }

            //Comprobamos si tiene reservas activas
            bool tieneReservas = _context.Reservas.Any(r => r.IdCliente == idCliente);
            if (tieneReservas)
            {
                throw new InvalidOperationException("No se puede eliminar el cliente porque tiene reservas activas.");
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        //ExisteEmail() --> Comprueba si ya existe un cliente con ese email
        public bool ExisteEmail(string email)
        {
            return _context.Clientes.Any(c => c.Email == email);
        }

        //ExisteEmailEnOtroCliente() --> Comprueba si el email pertenece a otro cliente distinto
        public bool ExisteEmailEnOtroCliente(int idCliente, string email)
        {
            return _context.Clientes.Any(c => c.Email == email && c.IdCliente != idCliente);
        }
    }
}
