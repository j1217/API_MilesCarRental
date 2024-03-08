using MilesCarRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Services
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
            return await _vehiculoRepository.GetVehiculosDisponiblesAsync();
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosPorLocalidadAsync(int localidadId)
        {
            return await _vehiculoRepository.GetVehiculosPorLocalidadAsync(localidadId);
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosPorTipoAsync(string tipo)
        {
            return await _vehiculoRepository.GetVehiculosPorTipoAsync(tipo);
        }
    }
}
