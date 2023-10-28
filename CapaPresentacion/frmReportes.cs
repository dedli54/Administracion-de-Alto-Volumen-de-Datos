using Cassandra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaDatos;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        EnlaceCassandra cass = new EnlaceCassandra();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUser3.Columns[e.ColumnIndex].Name == "btnRepSelect")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    cboDep.Text = dataUser3.Rows[indice].Cells["HotelReservacion"].Value.ToString();
                    cboCaja.Text = dataUser3.Rows[indice].Cells["TipoHabitacion"].Value.ToString();
                    dtpFecha1.Text = dataUser3.Rows[indice].Cells["CheckIn"].Value.ToString();
                    dtpFecha2.Text = dataUser3.Rows[indice].Cells["CheckOut"].Value.ToString();
                }
            }

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            //dataUser3.DataSource = cass.GetReportes();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            dataUser3.DataSource = cass.GetReportes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void frmReportes_Load_1(object sender, EventArgs e)
        {

        }
    }
}