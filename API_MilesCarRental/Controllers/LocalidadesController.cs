using API_MilesCarRental.Models;
using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Application.Services;

namespace API_MilesCarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalidadesController : ControllerBase
    {
        private readonly LocalidadService _localidadService;

        public LocalidadesController(LocalidadService localidadService)
        {
            _localidadService = localidadService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Localidade>>> GetLocalidades()
        {
            var localidades = await _localidadService.GetLocalidadesConVehiculosAsync();
            return Ok(localidades);
        }

    }
}
