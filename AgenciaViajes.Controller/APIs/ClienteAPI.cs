using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AgenciaViajes.Controller.Assemblers;
using AgenciaViajes.Controller.DTOs;
using AgenciaViajes.Model;

namespace AgenciaViajes.Controller.APIs
{
    //ClienteAPI --> Clase que gestiona las operaciones de clientes
    public class ClienteAPI
    {
        //Repositorio para acceder a la BD
        private readonly RepositorioClientes repo = new RepositorioClientes();

        //Listar() --> Devuelve todos los clientes en forma de DTO
        public List<ClienteDTO> Listar()
        {
            var clientes = repo.Seleccionar();
            return ClienteAssembler.ToDTOList(clientes);
        }

        //Crear() --> Crea un nuevo cliente
        public void Crear(string nombre, string apellidos, string email)
        {
            ValidarCliente(nombre, apellidos, email); //Validamos los datos

            if (repo.ExisteEmail(email.Trim())) //Comprobamos que el email no esté repetido
            {
                throw new ArgumentException("Ya existe un cliente con ese email.");
            }

            var dto = new ClienteDTO
            {
                Nombre = nombre.Trim(),
                Apellidos = apellidos.Trim(),
                Email = email.Trim()
            };

            var entity = ClienteAssembler.ToEntity(dto); //Convertimos a entidad
            repo.Crear(entity); //Guardamos en la BD
        }

        //Editar() --> Edita un cliente existente
        public void Editar(ClienteDTO dto)
        {
            ValidarCliente(dto.Nombre, dto.Apellidos, dto.Email);

            //Comprobamos si el email ya existe en otro cliente
            if (repo.ExisteEmailEnOtroCliente(dto.IdCliente, dto.Email.Trim()))
            {
                throw new ArgumentException("Ya existe otro cliente con ese email.");
            }

            var entity = ClienteAssembler.ToEntity(dto);
            repo.Actualizar(entity);
        }

        //Eliminar() --> Borra un cliente por su ID
        public void Eliminar(int idCliente)
        {
            repo.Eliminar(idCliente);
        }

        //ValidarCliente() --> Comprueba que los datos del cliente sean correctos
        private void ValidarCliente(string nombre, string apellidos, string email)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre es obligatorio.");
            }
                
            if (string.IsNullOrWhiteSpace(apellidos))
            {
                throw new ArgumentException("Los apellidos son obligatorios.");
            }
                
            if (!Regex.IsMatch(email ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("El email no tiene formato válido.");
            }
                
        }
    }
}
