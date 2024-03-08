using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRental.Domain.Entities
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public bool Disponible { get; set; }
        public int LocalidadRecogidaId { get; set; }
        public int LocalidadDevolucionId { get; set; }
        public string Tipo { get; set; }
        public int? CapacidadPasajeros { get; set; }
        public string Transmision { get; set; }

        public virtual Localidad LocalidadRecogida { get; set; }
        public virtual Localidad LocalidadDevolucion { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
