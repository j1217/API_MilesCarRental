using MilesCarRental.Domain.Entities;
using MilesCarRental.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Application.Services
{
    public class VehiculoService
    {
        private readonly IVehiculoRepository _vehiculoRepository;

        public VehiculoService(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosDisponiblesAsync()
        {
            return (IEnumerable<Vehiculo>)await _vehiculoRepository.GetVehiculosDisponiblesAsync();
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosPorLocalidadAsync(int localidadId)
        {
            return (IEnumerable<Vehiculo>)await _vehiculoRepository.GetVehiculosPorLocalidadAsync(localidadId);
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosPorTipoAsync(string tipo)
        {
            return (IEnumerable<Vehiculo>)await _vehiculoRepository.GetVehiculosPorTipoAsync(tipo);
        }

    }
}
