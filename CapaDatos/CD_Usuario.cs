using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows;
using Cassandra.Data;
using CapaEntidad;



namespace CapaDatos
{
    public class EnlaceCassandra
    {

        Usuario usCantLog = new Usuario();
        
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
        public bool ObtenerUsuarios()
        {
            try
            {
                conectar();

                string query = "SELECT Nombre, Correo FROM usuario;";

                // Execute a query on a connection synchronously 
                var rs = _session.Execute(query);

                // Iterate through the RowSet 
                foreach (var row in rs)
                {
                    var value = row.GetValue<string>("Nombre");
                    // Do something with the value 
                    var texto = row.GetValue<string>("Correo");
                    // Do something with the value 

                   

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
    }
}

