using Practica_1.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Clases
{
    internal class Operaciones
    {
        public void AgregarProducto(Producto p)
        {
            using (var contexto = new InventarioContext())
            {
                contexto.Productos.Add(p);
                contexto.SaveChanges();
            }
        }
        public void Actualizarproducto(Producto producto)
        {
            using (var context = new InventarioContext())
            {
                var productoxistente = context.Productos.Find(producto.Id);
                if (productoxistente != null)
                {
                    productoxistente.Nombre = producto.Nombre;
                    productoxistente.Precio = producto.Precio;
                    productoxistente.Cantidad = producto.Cantidad;
                    productoxistente.Idproveedor = producto.Idproveedor;
                    context.SaveChanges();
                }
            }
        }
        public void EliminarProducto(int id)
        {
            using (var context = new InventarioContext())
            {
                var producto = context.Productos.Find(id);
                if (producto != null)
                {
                    context.Productos.Remove(producto);
                    context.SaveChanges();
                }
            }
        }
        public List<VistaProdProvee> filtrarProductos(string campo, string opcion, List<VistaProdProvee> productos)
        {
            List<VistaProdProvee> productos_encontrados = new List<VistaProdProvee>();
            switch (opcion)
            {
                case "Nombre":
                    foreach (VistaProdProvee p in productos)
                    {
                        if (campo == p.Nombre)
                        {
                            productos_encontrados.Add(p);
                        }
                    }
                    break;
                case "Precio":
                    break;
            }
            return productos_encontrados;
        }

    }
}
