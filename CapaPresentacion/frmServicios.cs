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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }
        
        EnlaceCassandra cass = new EnlaceCassandra();
        Servicio serv = new Servicio();
        private void descServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string nom = textServicio.Text;
            string desc = descServicio.Text;

            if ((nom == "") || (desc == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                serv.NombreServicio = textServicio.Text;
                serv.DescripcionServicio = descServicio.Text;
                serv.PrecioServicio = precioServicio.Value;

                var success = cass.InsertarServicios(serv);
                if (success)
                {
                    MessageBox.Show("Servicio registrado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
     
                }
                else {
                    MessageBox.Show("Algo salio mal, revisa los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

 

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUser.Columns[e.ColumnIndex].Name == "btnseleccionar") {
                int indice = e.RowIndex;
                if (indice >= 0) {
                    txtindice.Text = indice.ToString();
                    textServicio.Text = dataUser.Rows[indice].Cells["Nom_Serv"].Value.ToString();
                    descServicio.Text = dataUser.Rows[indice].Cells["Desc_Serv"].Value.ToString();
                    precioServicio.Text = dataUser.Rows[indice].Cells["Precio_Serv"].Value.ToString();
                    textId.Text = dataUser.Rows[indice].Cells["Nom_Serv"].Value.ToString();
                }
            }
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dataUser.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBuscar.DisplayMember = "Texto";
            cboBuscar.ValueMember = "Valor";
            cboBuscar.SelectedIndex = 0;



            List<Servicio> lista = cass.ListarServicios();
            cass.ListarServicios();
            foreach (Servicio item in lista) {
                dataUser.Rows.Add(new object[] {"", item.NombreServicio, 
                    "$ " + item.PrecioServicio, 
                    item.DescripcionServicio

                });
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string nom = textServicio.Text;
            string desc = descServicio.Text;

            if ((nom == "") || (desc == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                serv.DescripcionServicio = descServicio.Text;
                serv.PrecioServicio = precioServicio.Value;

                serv.NombreServicio = textId.Text;

                var success = cass.EditarServicios(serv);
                if (success)
                {
                    MessageBox.Show("Servicio editado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Algo salio mal, revisa los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textId.Text) != "-1")
            {
                if (MessageBox.Show("¿Desea eliminar el servicio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    serv.NombreServicio = textId.Text;
                    var respuesta = cass.EliminarServicios(serv);

                    if (respuesta) {
                        MessageBox.Show("Servicio eliminado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else {
                MessageBox.Show("No ha seleccionado ningun servicio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtindice.Text = "-1";
            textId.Text = "-1";
            textServicio.Text = "";
            descServicio.Text = "";
            precioServicio.Value = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).Valor.ToString();
            if (dataUser.Rows.Count > 0){
                foreach (DataGridViewRow row in dataUser.Rows){
                    if (row.Cells[columaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dataUser.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
