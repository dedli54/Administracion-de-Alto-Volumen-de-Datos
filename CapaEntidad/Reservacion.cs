using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reservacion
    {
		public int IdReservacion { set; get; }
		public string HotelReservacion { set; get; }
		public int TipoHabitacion { set; get; }
		public int NumeroPersonasR { set; get; }
		public int ServicioAdicionalR { set; get; }
		public string NombreCliente { set; get; }
		public decimal Precio { set; get; }
		public string CartaResponsiva { set; get; }
		public decimal MontoPagado { set; get; }
		public int MetodoPago { set; get; }
		public string CheckIn { set; get; }
		public string CheckOut { set; get; }
		public string FechaModificacion { set; get; }
	}
}