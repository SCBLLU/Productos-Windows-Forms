using System;
using System.Collections.Generic;

namespace Practica_1.Modelos;

public partial class Proveedor
{
    public int Idproveedor { get; set; }

    public string? NombreProveedor { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
