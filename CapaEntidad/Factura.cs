using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {
		public int IdFactura { set; get; }
		public string NombreClienteFactura { set; get; }
		public int TipoCambio { set; get; }
		public string FechaVencimiento { set; get; }
		public int CantidadPersonas { set; get; }
		public string TipoPieza { set; get; }
		public decimal Precio { set; get; }
		public decimal Importe { set; get; }
		public decimal Subtotal { set; get; }
		public decimal Iva { set; get; }
		public decimal Total { set; get; }
	}
}