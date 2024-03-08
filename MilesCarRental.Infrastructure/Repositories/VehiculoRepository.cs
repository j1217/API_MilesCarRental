using Microsoft.EntityFrameworkCore;
using MilesCarRental.Infrastructure.Data.Contexts;
using MilesCarRental.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Infrastructure.Repositories
{
    public class VehiculoRepository : Repository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(MilesCarRentalContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosDisponiblesAsync()
        {
            return await _context.Vehiculos.Where(v => v.Disponible).ToListAsync();
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosPorLocalidadAsync(int localidadId)
        {
            return await _context.Vehiculos.Where(v => v.LocalidadRecogida == localidadId || v.LocalidadDevolucion == localidadId).ToListAsync();
        }

        public async Task<IEnumerable<Vehiculo>> GetVehiculosPorTipoAsync(string tipo)
        {
            return await _context.Vehiculos.Where(v => v.Tipo == tipo).ToListAsync();
        }
    }
}
