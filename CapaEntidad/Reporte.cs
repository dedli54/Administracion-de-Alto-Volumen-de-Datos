using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reporte
    {
		public int IdReporte { set; get; }
		public string NombreHotelRep { set; get; }
		public int TipoHabitacionRep { set; get; }
		public int NumeroPersonas { set; get; }
		public int ServicioAdicional { set; get; }
		public string NombreCliente { set; get; }
		public decimal MontoPagado { set; get; }
		public string CheckInRep { set; get; }
		public string CheckOutRep { set; get; }
		public string FechaRegRes { set; get; }
	}
}