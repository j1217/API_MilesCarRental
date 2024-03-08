using API_MilesCarRental.Models;
using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Application.Services;

namespace API_MilesCarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly VehiculoService _vehiculoService;

        public VehiculosController(VehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }

        [HttpGet("disponibles")]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculosDisponibles()
        {
            var vehiculos = await _vehiculoService.GetVehiculosDisponiblesAsync();
            return Ok(vehiculos);
        }

        [HttpGet("porlocalidad/{localidadId}")]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculosPorLocalidad(int localidadId)
        {
            var vehiculos = await _vehiculoService.GetVehiculosPorLocalidadAsync(localidadId);
            return Ok(vehiculos);
        }

        [HttpGet("portipo/{tipo}")]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculosPorTipo(string tipo)
        {
            var vehiculos = await _vehiculoService.GetVehiculosPorTipoAsync(tipo);
            return Ok(vehiculos);
        }
    }
}
