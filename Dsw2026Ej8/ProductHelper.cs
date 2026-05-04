using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    //palabra clave 'partial' para indicar que la clase está dividida
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            // Retorna el formato [code] description - price (en formato moneda)
            //constante 'CurrencyFormat' que definiremos en el otro archivo[cite: 1]
            return $"[{code}] {description} - {FormatearPrecio(price)}";
        }
    }
    public partial class ProductHelper
    {
        private string FormatearPrecio(decimal price)
        {
            return price.ToString("C");
        }
    }
}
