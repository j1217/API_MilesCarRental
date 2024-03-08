using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Entities
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime FechaRecogida { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int UsuarioId { get; set; }
        public string Estado { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }
    }
}
