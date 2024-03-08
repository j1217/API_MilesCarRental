using MilesCarRental.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Infrastructure.Repositories
{
    public interface IVehiculoRepository : IRepository<Vehiculo>
    {
        Task<IEnumerable<Vehiculo>> GetVehiculosDisponiblesAsync();
        Task<IEnumerable<Vehiculo>> GetVehiculosPorLocalidadAsync(int localidadId);
        Task<IEnumerable<Vehiculo>> GetVehiculosPorTipoAsync(string tipo);
    }
}
