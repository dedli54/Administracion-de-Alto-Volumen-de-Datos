using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {

        public string fullName { get; set; }
        public string Nombre { set; get; }
        public string ApePaterno { set; get; }
        public string ApeMaterno { set; get; }
        public string Telefono { set; get; }
        public string CURP { set; get; }
        public string Correo { set; get; }
        public string Contrasenia { set; get; }
        public string NumeroNomina { set; get; }
        public int Puesto { set; get; }
        public bool Estado { set; get; }
        public string FechaRegistro { set; get; }


        public int cantError;
        public int setCantError(int errCant) {
            cantError += errCant;
            return cantError;
        }
    }
}