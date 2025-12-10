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
    //ViajeAPI --> Clase que gestiona las operaciones de viajes
    public class ViajeAPI
    {
        private readonly RepositorioViajes repo = new RepositorioViajes();

        //Listar() --> Devuelve todos los viajes en forma de DTO
        public List<ViajeDTO> Listar()
        {
            var viajes = repo.Seleccionar();
            return ViajeAssembler.ToDTOList(viajes);
        }

        //Crear() --> Crea un nuevo viaje
        public void Crear(string destino, decimal precio, int plazas)
        {
            ValidarViaje(destino, precio, plazas); //Validamos los datos

            var dto = new ViajeDTO { Destino = destino.Trim(), Precio = precio, PlazasDisponibles = plazas };
            var entity = ViajeAssembler.ToEntity(dto);
            repo.Crear(entity);
        }

        //Modificar() --> Edita un viaje existente
        public void Modificar(ViajeDTO dto)
        {
            ValidarViaje(dto.Destino, dto.Precio, dto.PlazasDisponibles);

            var entity = ViajeAssembler.ToEntity(dto);
            repo.Actualizar(entity);
        }

        //Eliminar() --> Borra un viaje por su ID
        public void Eliminar(int idViaje)
        {
            repo.Eliminar(idViaje);
        }

        //ValidarViaje() --> Comprueba que los datos del viaje sean correctos
        private void ValidarViaje(string destino, decimal precio, int plazas)
        {
            if (string.IsNullOrWhiteSpace(destino))
            {
                throw new ArgumentException("El destino es obligatorio.");
            }
                
            if (precio <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor que 0.");
            }
                
            if (plazas < 0)
            {
                throw new ArgumentException("Las plazas deben ser un entero ≥ 0.");
            }
                
        }
    }
}
