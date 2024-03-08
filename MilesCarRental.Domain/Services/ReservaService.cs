using MilesCarRental.Domain.Entities;
using MilesCarRental.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Services
{
    public class ReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public async Task<IEnumerable<Reserva>> GetReservasPorIdVehiculoAsync(int idVehiculo)
        {
            return (IEnumerable<Reserva>)await _reservaRepository.GetByVehicleIdAsync(idVehiculo);
        }

        public async Task<IEnumerable<Reserva>> GetReservasPorEstadoAsync(string estado)
        {
            return (IEnumerable<Reserva>)await _reservaRepository.GetByStatusAsync(estado);
        }

        public async Task<IEnumerable<Reserva>> GetReservasPorRangoDeFechasAsync(DateTime fechaInicio, DateTime fechaFin)
        {
            return (IEnumerable<Reserva>)await _reservaRepository.GetByDateRangeAsync(fechaInicio, fechaFin);
        }

        public async Task<IEnumerable<Reserva>> GetReservasPorIdUsuarioAsync(int idUsuario)
        {
            return (IEnumerable<Reserva>)await _reservaRepository.GetByUserIdAsync(idUsuario);
        }

    }
}
