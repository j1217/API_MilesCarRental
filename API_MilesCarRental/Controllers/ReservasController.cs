using API_MilesCarRental.Models;
using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Application.Services;

namespace API_MilesCarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservasController : ControllerBase
    {
        private readonly ReservaService _reservaService;

        public ReservasController(ReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet("porvehiculo/{idVehiculo}")]
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservasPorIdVehiculo(int idVehiculo)
        {
            var reservas = await _reservaService.GetReservasPorIdVehiculoAsync(idVehiculo);
            return Ok(reservas);
        }

        [HttpGet("porestado/{estado}")]
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservasPorEstado(string estado)
        {
            var reservas = await _reservaService.GetReservasPorEstadoAsync(estado);
            return Ok(reservas);
        }

        [HttpGet("porfechas/{fechaInicio}/{fechaFin}")]
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservasPorRangoDeFechas(string fechaInicio, string fechaFin)
        {
            if (!DateTime.TryParse(fechaInicio, out var start) || !DateTime.TryParse(fechaFin, out var end))
            {
                return BadRequest("Las fechas no son válidas");
            }

            var reservas = await _reservaService.GetReservasPorRangoDeFechasAsync(start, end);
            return Ok(reservas);
        }

        [HttpGet("porusuario/{idUsuario}")]
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservasPorIdUsuario(int idUsuario)
        {
            var reservas = await _reservaService.GetReservasPorIdUsuarioAsync(idUsuario);
            return Ok(reservas);
        }
    }
}
