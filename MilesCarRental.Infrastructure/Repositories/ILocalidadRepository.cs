﻿using MilesCarRental.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Infrastructure.Repositories
{
    public interface ILocalidadRepository : IRepository<Localidade>
    {
        Task<IEnumerable<Localidade>> GetLocalidadesConVehiculosAsync();
    }
}
