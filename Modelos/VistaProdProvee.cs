using System;
using System.Collections.Generic;

namespace Practica_1.Modelos;

public partial class VistaProdProvee
{
    public long? Correlativo { get; set; }

    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public string? Proveedor { get; set; }
}
