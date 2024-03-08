using System;
using System.Collections.Generic;

namespace MilesCarRental.Infrastructure.Data.Models;

public partial class Vehiculo
{
    public int VehiculoId { get; set; }

    public string Modelo { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public bool Disponible { get; set; }

    public int LocalidadRecogida { get; set; }

    public int LocalidadDevolucion { get; set; }

    public string? Tipo { get; set; }

    public int? CapacidadPasajeros { get; set; }

    public string? Transmision { get; set; }

    public virtual Localidade LocalidadDevolucionNavigation { get; set; } = null!;

    public virtual Localidade LocalidadRecogidaNavigation { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
