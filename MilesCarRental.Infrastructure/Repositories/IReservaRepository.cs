using MilesCarRental.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Infrastructure.Repositories
{
    public interface IReservaRepository : IRepository<Reserva>
    {
        Task<IEnumerable<Reserva>> GetByVehicleIdAsync(int vehicleId);
        Task<IEnumerable<Reserva>> GetByStatusAsync(string status);
        Task<IEnumerable<Reserva>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<IEnumerable<Reserva>> GetByUserIdAsync(int userId);
    }
}
