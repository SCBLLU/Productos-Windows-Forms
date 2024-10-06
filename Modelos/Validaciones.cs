using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Modelos
{
    public class Validaciones
    {
        public bool validarnombre(string nombre) // validar nombre
        {
            try
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool validarcosto(string costo) // validar costo
        {
            try
            {
                if (string.IsNullOrEmpty(costo))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool validarproveedor(string proveedor) // validar proveedor
        {
            try
            {
                if (string.IsNullOrEmpty(proveedor))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool validarcantidad(string cantidad) // validar cantidad
        {
            try
            {
                if (string.IsNullOrEmpty(cantidad))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


    }
}
