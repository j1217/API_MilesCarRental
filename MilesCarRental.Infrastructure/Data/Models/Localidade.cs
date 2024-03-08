using System;
using System.Collections.Generic;

namespace MilesCarRental.Infrastructure.Data.Models;

public partial class Localidade
{
    public int LocalidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Vehiculo> VehiculoLocalidadDevolucionNavigations { get; set; } = new List<Vehiculo>();

    public virtual ICollection<Vehiculo> VehiculoLocalidadRecogidaNavigations { get; set; } = new List<Vehiculo>();
}
