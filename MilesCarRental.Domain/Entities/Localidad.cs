using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Entities
{
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Vehiculo> VehiculosRecogida { get; set; }
        public virtual ICollection<Vehiculo> VehiculosDevolucion { get; set; }
    }
}
