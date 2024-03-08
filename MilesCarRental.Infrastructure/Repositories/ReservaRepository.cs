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
    public class ReservaRepository : Repository<Reserva>, IReservaRepository
    {
        public ReservaRepository(MilesCarRentalContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Reserva>> GetByVehicleIdAsync(int vehicleId)
        {
            return await _context.Reservas.Where(r => r.VehiculoId == vehicleId).ToListAsync();
        }

        public async Task<IEnumerable<Reserva>> GetByStatusAsync(string status)
        {
            return await _context.Reservas.Where(r => r.Estado == status).ToListAsync();
        }

        public async Task<IEnumerable<Reserva>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.Reservas.Where(r => r.FechaRecogida >= startDate && r.FechaDevolucion <= endDate).ToListAsync();
        }

        public async Task<IEnumerable<Reserva>> GetByUserIdAsync(int userId)
        {
            return await _context.Reservas.Where(r => r.UsuarioId == userId).ToListAsync();
        }

        Task<IEnumerable<Reserva>> IReservaRepository.GetByVehicleIdAsync(int vehicleId)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Reserva>> IReservaRepository.GetByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Reserva>> IReservaRepository.GetByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Reserva>> IReservaRepository.GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
