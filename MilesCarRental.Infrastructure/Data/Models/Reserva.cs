using System;
using System.Collections.Generic;

namespace MilesCarRental.Infrastructure.Data.Models;

public partial class Reserva
{
    public int ReservaId { get; set; }

    public int? VehiculoId { get; set; }

    public DateTime? FechaRecogida { get; set; }

    public DateTime? FechaDevolucion { get; set; }

    public int? UsuarioId { get; set; }

    public string? Estado { get; set; }

    public virtual Vehiculo? Vehiculo { get; set; }
}
