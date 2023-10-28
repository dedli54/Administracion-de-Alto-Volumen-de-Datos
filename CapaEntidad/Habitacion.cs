using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Habitacion
    {
		public string NombreHab { set; get; }
		public string DescripcionHab { set; get; }
		public int NumeroCamas { set; get; }
		public decimal CostoPersona { set; get; }
		public int TipoHabitacion { set; get; }
		public bool Estado { set; get; }
		public string FechaRegistroHab { set; get; }
	}
}