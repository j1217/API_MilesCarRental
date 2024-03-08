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
    public class LocalidadRepository : Repository<Localidade>, ILocalidadRepository
    {
        public LocalidadRepository(MilesCarRentalContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Localidade>> GetLocalidadesConVehiculosAsync()
        {
            return await _context.Localidades
                .Where(l => l.VehiculoLocalidadDevolucionNavigations.Any() || l.VehiculoLocalidadRecogidaNavigations.Any())
                .ToListAsync();
        }
    }
}
