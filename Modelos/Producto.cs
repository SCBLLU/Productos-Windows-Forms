using System;
using System.Collections.Generic;

namespace Practica_1.Modelos;

public partial class Producto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public int? Idproveedor { get; set; }

    public virtual Proveedor? IdproveedorNavigation { get; set; }
}
