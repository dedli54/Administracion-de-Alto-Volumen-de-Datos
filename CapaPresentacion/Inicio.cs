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
using FontAwesome.Sharp;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
        }
        EnlaceCassandra cass = new EnlaceCassandra();

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }



        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }
        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmHotel());
        }
        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmHabitacion());
        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmServicios());
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReservacion());
        }

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmFactura());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
