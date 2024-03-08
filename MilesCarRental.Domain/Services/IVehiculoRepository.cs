using MilesCarRental.Domain.Entities;
using MilesCarRental.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Services
{
    public interface IVehiculoRepository : IRepository<Vehiculo>
    {
        Task<IEnumerable<Vehiculo>> GetVehiculosDisponiblesAsync();
        Task<IEnumerable<Vehiculo>> GetVehiculosPorLocalidadAsync(int localidadId);
        Task<IEnumerable<Vehiculo>> GetVehiculosPorTipoAsync(string tipo);
    }
}
