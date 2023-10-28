using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;
using Cassandra.Data;
using CapaEntidad;



namespace CapaDatos
{
    public class EnlaceCassandra
    {

        Usuario usCantLog = new Usuario();
        //Soy un comentario y puedo dejar en claro que el webito con frijoles es lo maximo
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }
        private static void conectar2()
        {
            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            _session = _cluster.Connect("keyspace3");
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        public List<Usuario> ListarUsuario(){
            string query = "Select \"Nombre\",\"ApeMaterno\", \"ApePaterno\", \"CURP\", \"Contrasenia\", \"Correo\", \"Estado\", \"FechaRegistro\",  \"NumeroNomina\", \"Puesto\", \"Telefono\" FROM \"PIA_AAVD\".\"Usuario\"";
            List<Usuario> lista = new List<Usuario>();
            conectar();
            var Resultado = _session.Execute(query);
            foreach (var row in Resultado) {

                Usuario usuarios = new Usuario();
                usuarios.Nombre = row.GetValue<string>("Nombre");
                usuarios.ApeMaterno = row.GetValue<string>("ApeMaterno");
                usuarios.ApePaterno = row.GetValue<string>("ApePaterno");
                usuarios.CURP = row.GetValue<string>("CURP");
                usuarios.Contrasenia = row.GetValue<string>("Contrasenia");
                usuarios.Correo = row.GetValue<string>("Correo");
                usuarios.Estado = row.GetValue<Nullable<bool>>("Estado") == null ? false : row.GetValue<bool>("Estado");
                usuarios.FechaRegistro = row.GetValue<object>("FechaRegistro") == null ? "" : row.GetValue<object>("FechaRegistro").ToString();
                usuarios.NumeroNomina = row.GetValue<string>("NumeroNomina");
                usuarios.Puesto = row.GetValue<int>("Puesto");
                usuarios.Telefono = row.GetValue<string>("Telefono");

                lista.Add(usuarios);
            }
            desconectar();
            return lista;
        }

        public bool InsertarUsuario(Usuario param)
        {
            var err = true;
            try
            {
                conectar();
                var queryIU = "Insert into \"PIA_AAVD\".\"Usuario\"( \"Nombre\", \"ApePaterno\", \"ApeMaterno\", \"Telefono\", \"CURP\", \"Correo\", \"Contrasenia\", \"NumeroNomina\", \"Puesto\", \"Estado\", \"FechaRegistro\") " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, {9}, '{10}') If not exists; ";
                queryIU = string.Format(queryIU, param.Nombre, param.ApePaterno, param.ApeMaterno, param.Telefono, param.CURP, param.Correo, param.Contrasenia, param.NumeroNomina, param.Puesto, param.Estado, param.FechaRegistro);
                int i = -1;
                _session.Execute(queryIU);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EditarUsuario(Usuario param)
        {
            var err = true;
            try
            {
                conectar();
                var queryEU = "Update \"PIA_AAVD\".\"Usuario\" set \"Nombre\" = '{0}',\"ApePaterno\" = '{1}', \"ApeMaterno\" = '{2}', \"Telefono\"='{3}',\"CURP\"='{4}', \"Contrasenia\"='{5}',\"NumeroNomina\"='{6}', \"Puesto\" = {7},\"Estado\"={8}  where \"Correo\" = '{9}';";
                queryEU = string.Format(queryEU, param.Nombre, param.ApePaterno, param.ApeMaterno, param.Telefono, param.CURP, param.Contrasenia, param.NumeroNomina, param.Puesto, param.Estado, param.Correo);
                int i = -1;
                _session.Execute(queryEU);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EliminarUsuario(Usuario param)
        {
            var err = true;
            try
            {
                conectar();
                var queryELU = "Delete from \"PIA_AAVD\".\"Usuario\" Where \"Correo\" = '{0}';";
                queryELU = string.Format(queryELU, param.Correo);
                int i = -1;
                _session.Execute(queryELU);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public bool ObtenerUsuarios()
        {
            try
            {
                conectar();

                string query = "SELECT \"Nombre\", \"Correo\" FROM \"Usuario\"";

                // Execute a query on a connection synchronously 
                var rs = _session.Execute(query);

                // Iterate through the RowSet 
                foreach (var row in rs)
                {
                    var value = row.GetValue<string>("Nombre");
                    // Do something with the value 
                    var texto = row.GetValue<string>("Correo");
                    // Do something with the value 

                    //MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    RowSet rsUsers = _session.Execute(query);

                    ////////////////////////////////////////////////
                    //var users = new List<UserModel>();
                    //foreach (var userRow in rsUsers)
                    //{
                    //    //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
                    //}

                    //foreach (UserModel user in users)
                    //{
                    //    Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
                    //}

                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return false;
        }

        public bool login(string correo, string contrasenia, int puesto) { 
            int logAttempts = 0;
            usCantLog.cantError = 0;
            List <Usuario> lista = ListarUsuario();
            foreach (Usuario row in lista){
                if (correo == row.Correo && contrasenia == row.Contrasenia) {
                    return true;
                }
                else {
                    logAttempts++;
                }
            }
            return false;
        }

        public List<Servicio> ListarServicios() {
            string queryServ = "Select \"NombreServicio\",\"DescripcionServicio\",\"PrecioServicio\" FROM \"PIA_AAVD\".\"Servicio\"";
            List<Servicio> listaServ = new List<Servicio>();
            conectar();
            var ResultadoServ = _session.Execute(queryServ);
            foreach (var row in ResultadoServ) {
                Servicio servicios = new Servicio();
                servicios.NombreServicio = row.GetValue<string>("NombreServicio");
                servicios.DescripcionServicio = row.GetValue<string>("DescripcionServicio");
                servicios.PrecioServicio = row.GetValue<decimal>("PrecioServicio");

                listaServ.Add(servicios);
            }
            desconectar();
            return listaServ;
        }

        public bool InsertarServicios(Servicio param) {
            var err = true;
            try
            {
                conectar();
                var queryIS = "Insert into \"PIA_AAVD\".\"Servicio\"(\"NombreServicio\", \"DescripcionServicio\", \"PrecioServicio\") " +
                    "VALUES('{0}','{1}', {2}) If not exists;";
                queryIS = string.Format(queryIS, param.NombreServicio, param.DescripcionServicio, param.PrecioServicio);
                int i = -1;
                _session.Execute(queryIS);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally {
                desconectar();
            }
            return err;
        }
        public bool EditarServicios(Servicio param) {
            var err = true;
            try {
                conectar();
                var queryES = "Update \"PIA_AAVD\".\"Servicio\" set \"DescripcionServicio\" = '{0}', \"PrecioServicio\" = {1} where \"NombreServicio\" = '{2}' ;";
                queryES=string.Format(queryES, param.DescripcionServicio, param.PrecioServicio, param.NombreServicio);
                int i = -1;
                _session.Execute(queryES);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EliminarServicios(Servicio param){
            var err = true;
            try {
                conectar();
                var queryELS = "Delete from \"PIA_AAVD\".\"Servicio\" Where \"NombreServicio\" = '{0}';";
                queryELS = string.Format(queryELS, param.NombreServicio);
                int i = -1;
                _session.Execute(queryELS);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public List<Habitacion> ListarHabitacion() {
            string queryHab = "Select \"NombreHab\", \"DescripcionHab\", \"NumeroCamas\", \"CostoPersona\", \"TipoHabitacion\", \"Estado\", \"FechaRegistroHab\" FROM \"PIA_AAVD\".\"Habitacion\"";
            List<Habitacion> listahab = new List<Habitacion>();
            conectar();
            var ResultadoHab = _session.Execute(queryHab);
            foreach (var row in ResultadoHab) {
                Habitacion habitaciones = new Habitacion();
                habitaciones.NombreHab = row.GetValue<string>("NombreHab");
                habitaciones.DescripcionHab = row.GetValue<string>("DescripcionHab");
                habitaciones.NumeroCamas = row.GetValue<int>("NumeroCamas");
                habitaciones.CostoPersona = row.GetValue<decimal>("CostoPersona");
                habitaciones.TipoHabitacion = row.GetValue<int>("TipoHabitacion");
                habitaciones.Estado = row.GetValue<Nullable<bool>>("Estado") == null ? false : row.GetValue<bool>("Estado");
                habitaciones.FechaRegistroHab = row.GetValue<object>("FechaRegistroHab") == null ? "" : row.GetValue<object>("FechaRegistroHab").ToString();

                listahab.Add(habitaciones);
            }
            desconectar();
            return listahab;
        }

        public bool InsertarHabitacion(Habitacion param) {
            var err = true;
            try
            {
                conectar();
                var queryIH = "Insert into \"PIA_AAVD\".\"Habitacion\"(\"NombreHab\", \"DescripcionHab\", \"NumeroCamas\", \"CostoPersona\", \"TipoHabitacion\", \"Estado\", \"FechaRegistroHab\") " +
                    "VALUES('{0}','{1}', {2}, {3}, {4}, {5},'{6}') If not exists; ";
                queryIH = string.Format(queryIH, param.NombreHab, param.DescripcionHab, param.NumeroCamas, param.CostoPersona, param.TipoHabitacion, param.Estado, param.FechaRegistroHab);
                int i = -1;
                _session.Execute(queryIH);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EditarHabitacion(Habitacion param)
        {
            var err = true;
            try
            {
                conectar();
                var queryEH = "Update \"PIA_AAVD\".\"Habitacion\" set \"DescripcionHab\" = '{0}', \"NumeroCamas\" = {1}, \"CostoPersona\" = {2}, \"TipoHabitacion\" = {3}, \"Estado\" = {4} where \"NombreHab\"= '{5}';";
                queryEH = string.Format(queryEH, param.DescripcionHab, param.NumeroCamas, param.CostoPersona, param.TipoHabitacion, param.Estado, param.NombreHab);
                int i = -1;
                _session.Execute(queryEH);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EliminarHabitacion(Habitacion param) {
            var err = true;
            try
            {
                conectar();
                var queryELH = "Delete from \"PIA_AAVD\".\"Habitacion\" Where \"NombreHab\" = '{0}';";
                queryELH = string.Format(queryELH, param.NombreHab);
                int i = -1;
                _session.Execute(queryELH);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public List<Hotel> ListarHotel() {
            string queryHotel = "Select \"NombreHotel\",\"DescripcionHotel\",\"DireccionHotel\",\"Estado\",\"FechaRegistroHotel\",\"NumHabitaciones\",\"Pisos\" FROM \"PIA_AAVD\".\"Hotel\"";
            List<Hotel> listahot = new List<Hotel>();
            conectar();
            var ResultadoHot = _session.Execute(queryHotel);
            foreach (var row in ResultadoHot) {
                Hotel hoteles = new Hotel();
                hoteles.NombreHotel = row.GetValue<string>("NombreHotel");
                hoteles.DescripcionHotel = row.GetValue<string>("DescripcionHotel");
                hoteles.DireccionHotel = row.GetValue<string>("DireccionHotel");
                hoteles.Estado = row.GetValue<Nullable<bool>>("Estado") == null ? false : row.GetValue<bool>("Estado");
                hoteles.NumHabitaciones = row.GetValue<int>("NumHabitaciones");
                hoteles.Pisos = row.GetValue<int>("Pisos");
                hoteles.FechaRegistroHotel = row.GetValue<object>("FechaRegistroHotel") == null ? "" : row.GetValue<object>("FechaRegistroHotel").ToString();

                listahot.Add(hoteles);
            }
            desconectar();
            return listahot;
        }
        public bool InsertarHotel(Hotel param) {
            var err = true;
            try
            {
                conectar();
                var queryIH = "Insert into \"PIA_AAVD\".\"Hotel\"(\"NombreHotel\",\"DescripcionHotel\", \"DireccionHotel\", \"Estado\",\"NumHabitaciones\",\"Pisos\", \"FechaRegistroHotel\") " +
                    "VALUES('{0}','{1}','{2}', {3}, {4}, {5},'{6}') If not exists;";
                queryIH = string.Format(queryIH, param.NombreHotel, param.DescripcionHotel, param.DireccionHotel, param.Estado, param.NumHabitaciones, param.Pisos, param.FechaRegistroHotel);
                int i = -1;
                _session.Execute(queryIH);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EditarHotel(Hotel param)
        {
            var err = true;
            try
            {
                conectar();
                var queryEH = "Update \"PIA_AAVD\".\"Hotel\" set \"DescripcionHotel\" = '{0}', \"DireccionHotel\" = '{1}', \"Estado\" = {2}, \"NumHabitaciones\" = {3}, \"Pisos\" = {4} where \"NombreHotel\" = '{5}';";
                queryEH = string.Format(queryEH, param.DescripcionHotel, param.DireccionHotel,param.Estado, param.NumHabitaciones, param.Pisos, param.NombreHotel);
                int i = -1;
                _session.Execute(queryEH);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EliminarHotel(Hotel param) {
            var err = true;
            try
            {
                conectar();
                var queryELH = "Delete from \"PIA_AAVD\".\"Hotel\" Where \"NombreHotel\" = '{0}';";
                queryELH = string.Format(queryELH, param.NombreHotel);
                int i = -1;
                _session.Execute(queryELH);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }












        public List<Reservacion> Obtener_Reservacion()
        {
            //Para el idReservacion lo converti a int en vez de uuid en DevCenter por que no aceptaba el valor, esto lo hice para los 3
            string query = "select \"IdReservacion\", \"HotelReservacion\", \"TipoHabitacion\",\"NumeroPersonasR\", \"ServicioAdicionalR\", \"NombreCliente\", \"Precio\", \"MontoPagado\", \"MetodoPago\", \"CartaResponsiva\", \"CheckIn\", \"CheckOut\", \"FechaModificacion\" FROM \"Reservacion\"";
            List<Reservacion> lista = new List<Reservacion>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Reservacion reservacion = new Reservacion();
                reservacion.IdReservacion = row.GetValue<int>("IdReservacion");
                reservacion.HotelReservacion = row.GetValue<string>("HotelReservacion");
                reservacion.TipoHabitacion = row.GetValue<int>("TipoHabitacion");
                reservacion.NumeroPersonasR = row.GetValue<int>("NumeroPersonasR");
                reservacion.ServicioAdicionalR = row.GetValue<int>("ServicioAdicionalR");
                reservacion.NombreCliente = row.GetValue<string>("NombreCliente");
                reservacion.Precio = row.GetValue<decimal>("Precio");
                reservacion.MontoPagado = row.GetValue<decimal>("MontoPagado");
                reservacion.MetodoPago = row.GetValue<int>("MetodoPago");
                reservacion.CartaResponsiva = row.GetValue<string>("CartaResponsiva");
                //reservacion.CheckIn = row.GetValue<DateTime>("CheckIn");

                reservacion.CheckIn = row.GetValue<object>("CheckIn") == null ? "" : row.GetValue<object>("CheckIn").ToString();
                reservacion.CheckOut = row.GetValue<object>("CheckOut") == null ? "" : row.GetValue<object>("CheckOut").ToString();
                reservacion.FechaModificacion = row.GetValue<object>("FechaModificacion") == null ? "" : row.GetValue<object>("FechaModificacion").ToString();
                //reservacion.FechaModificacion = row.GetValue<DateTime>("FechaModificacion");
                lista.Add(reservacion);
            }
            desconectar();
            return lista;
        }

        public List<Factura> Obtener_Factura()
        {
            string query = "select \"IdFactura\", \"NombreClienteFactura\", \"TipoCambio\", \"FechaVencimiento\", \"CantidadPersonas\", \"TipoPieza\", \"Precio\", \"Subtotal\", \"Total\" FROM \"Factura\"";
            List<Factura> lista = new List<Factura>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Factura factura = new Factura();
                factura.IdFactura = row.GetValue<int>("IdFactura");
                factura.NombreClienteFactura = row.GetValue<string>("NombreClienteFactura");
                factura.TipoCambio = row.GetValue<int>("TipoCambio");
                factura.CantidadPersonas = row.GetValue<int>("CantidadPersonas");
                factura.TipoPieza = row.GetValue<string>("TipoPieza");
                factura.Precio = row.GetValue<decimal>("Precio");
                factura.Subtotal = row.GetValue<decimal>("Subtotal");
    
                factura.Total = row.GetValue<decimal>("Total");

                factura.FechaVencimiento = row.GetValue<object>("FechaVencimiento") == null ? "" : row.GetValue<object>("FechaVencimiento").ToString();
                lista.Add(factura);
            }
            desconectar();
            return lista;
        }

        public List<Reservacion> GetReportes() //Deberia llamar a todas las partes de las tablas pero no lo hace o mas bien las llama como 0
        {
            string query = "select \"IdReservacion\", \"HotelReservacion\", \"TipoHabitacion\",\"NumeroPersonasR\", \"ServicioAdicionalR\", \"NombreCliente\", \"Precio\", \"MontoPagado\", \"MetodoPago\", \"CartaResponsiva\", \"CheckIn\", \"CheckOut\", \"FechaModificacion\" FROM \"Reservacion\"";

            List<Reservacion> listas = new List<Reservacion>();

            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                /*Reporte reporte = new Reporte();*/
                Reservacion reservacion = new Reservacion();

                //reporte.IdReporte = row.GetValue<int>("IdReporte");
                reservacion.IdReservacion = row.GetValue<int>("IdReservacion");
                reservacion.HotelReservacion = row.GetValue<string>("HotelReservacion");
                reservacion.TipoHabitacion = row.GetValue<int>("TipoHabitacion");
                reservacion.NumeroPersonasR = row.GetValue<int>("NumeroPersonasR");
                reservacion.ServicioAdicionalR = row.GetValue<int>("ServicioAdicionalR");
                reservacion.NombreCliente = row.GetValue<string>("NombreCliente");
                reservacion.Precio = row.GetValue<decimal>("Precio");
                reservacion.MontoPagado = row.GetValue<decimal>("MontoPagado");
                reservacion.MetodoPago = row.GetValue<int>("MetodoPago");
                reservacion.CartaResponsiva = row.GetValue<string>("CartaResponsiva");


                reservacion.CheckIn = row.GetValue<object>("CheckIn") == null ? "" : row.GetValue<object>("CheckIn").ToString();
                reservacion.CheckOut = row.GetValue<object>("CheckOut") == null ? "" : row.GetValue<object>("CheckOut").ToString();
                reservacion.FechaModificacion = row.GetValue<object>("FechaModificacion") == null ? "" : row.GetValue<object>("FechaModificacion").ToString();

                listas.Add(reservacion);
            }

            desconectar();
            return listas;
        }

        public bool InsertarReservacion(Reservacion param)
        {
            var err = true;

            try
            {
                conectar();
                //Reservacion dbConection = Reservacion.GetInstance();

                var query = "INSERT INTO \"Reservacion\"(\"IdReservacion\", \"HotelReservacion\", \"TipoHabitacion\",\"NumeroPersonasR\", \"ServicioAdicionalR\", \"NombreCliente\", \"Precio\", \"MontoPagado\", \"MetodoPago\", \"CartaResponsiva\", \"CheckIn\", \"CheckOut\", \"FechaModificacion\")"
                    + "VALUES( {0}, '{1}', {2}, {3}, {4}, '{5}', {6}, {7}, {8}, '{9}', '{10}', '{11}', '{12}') if not exists; ";
                query = string.Format(query, param.IdReservacion, param.HotelReservacion, param.TipoHabitacion, param.NumeroPersonasR, param.ServicioAdicionalR,
                    param.NombreCliente, param.Precio, param.MontoPagado, param.MetodoPago, param.CartaResponsiva, param.CheckIn, param.CheckOut, param.FechaModificacion);

                  int i = -1;
                _session.Execute(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {

                desconectar();

            }
            return err;
        }

        public bool InsertarFactura(Factura param)
        {
            var err = true;
            try
            {
                conectar();

                var query = "INSERT INTO \"Factura\"(\"IdFactura\", \"NombreClienteFactura\", \"TipoCambio\", \"FechaVencimiento\", \"CantidadPersonas\", \"TipoPieza\", \"Precio\", \"Subtotal\", \"Total\")"
                    + "VALUES( {0}, '{1}', {2}, '{3}', {4}, '{5}', {6}, {7},  {8}) if not exists; ";

                query = string.Format(query, param.IdFactura, param.NombreClienteFactura, param.TipoCambio, param.FechaVencimiento, param.CantidadPersonas, param.TipoPieza,
                    param.Precio,  param.Subtotal, param.Total);

                _session.Execute(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {

                desconectar();

            }
            return err;
        }

        public bool EditarReservacion(Reservacion param)
        {
            var err = true;
            try
            {
                conectar();
                var query = "Update \"PIA_AAVD\".\"Reservacion\" set \"HotelReservacion\" = '{1}', \"TipoHabitacion\" = {2}, \"NumeroPersonasR\" = {3}, \"ServicioAdicionalR\" = {4}, \"NombreCliente\" = '{5}', \"Precio\" = {6}, \"MontoPagado\" = {7}, \"MetodoPago\" = {8}, \"CartaResponsiva\" = '{9}', \"CheckIn\" = '{10}', \"CheckOut\" = '{11}', \"FechaModificacion\" = '{12}' where \"IdReservacion\" = {0};";
                query = string.Format(query, param.IdReservacion, param.HotelReservacion, param.TipoHabitacion, param.NumeroPersonasR, param.ServicioAdicionalR,
                    param.NombreCliente, param.Precio, param.MontoPagado, param.MetodoPago, param.CartaResponsiva, param.CheckIn, param.CheckOut, param.FechaModificacion);
                int i = -1;
                _session.Execute(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public bool EliminarReservacion(Reservacion param)
        {
            var err = true;
            try
            {
                conectar();
                var query = "Delete from \"PIA_AAVD\".\"Reservacion\" Where \"IdReservacion\" = {0};";
                query = string.Format(query, param.IdReservacion);
                int i = -1;
                _session.Execute(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }
        public bool EliminarFactura(Factura param)
        {
            var err = true;
            try
            {
                conectar();
                var query = "Delete from \"PIA_AAVD\".\"Factura\" Where \"IdFactura\" = {0};";
                query = string.Format(query, param.IdFactura);
                int i = -1;
                _session.Execute(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                err = false;
                throw e;
            }
            finally
            {
                desconectar();
            }
            return err;
        }


    }
}

