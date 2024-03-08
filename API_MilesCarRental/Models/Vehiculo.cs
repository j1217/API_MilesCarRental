using System;
using System.Collections.Generic;

namespace API_MilesCarRental.Models;

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
}
