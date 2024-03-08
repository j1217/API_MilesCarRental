using MilesCarRental.Domain.Entities;
using MilesCarRental.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Services
{
    public class LocalidadService
    {
        private readonly ILocalidadRepository _localidadRepository;

        public LocalidadService(ILocalidadRepository localidadRepository)
        {
            _localidadRepository = localidadRepository;
        }

        public async Task<IEnumerable<Localidad>> GetLocalidadesConVehiculosAsync()
        {
            return (IEnumerable<Localidad>)await _localidadRepository.GetLocalidadesConVehiculosAsync();
        }

    }
}
