using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Hotel
    {

		public string NombreHotel { set; get; }
		public string DescripcionHotel { set; get; }
		public string DireccionHotel { set; get; }
		public bool Estado { set; get; }
		public int NumHabitaciones { set; get; }
		public int Pisos { set; get; }
		public string FechaRegistroHotel { set; get; }
	}
}