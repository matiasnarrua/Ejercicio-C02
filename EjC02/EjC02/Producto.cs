using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjC02
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigoDeBarra;
        }
        public string GetMarca() {  return this.marca;  }
        public float GetPrecio() { return this.precio;  }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: ");
            sb.AppendLine(p.marca);
            sb.AppendLine("Codigo: ");
            sb.AppendLine((string)p);
            sb.AppendLine("Precio: ");
            sb.AppendLine(p.precio.ToString());

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p.codigoDeBarra == marca)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }



    }
}
