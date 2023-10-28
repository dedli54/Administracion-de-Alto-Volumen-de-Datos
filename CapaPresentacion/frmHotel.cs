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
    public partial class frmHotel : Form
    {
        public frmHotel()
        {
            InitializeComponent();
        }

        EnlaceCassandra cass = new EnlaceCassandra();
        Hotel hot = new Hotel();

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void iconGuardar_Click(object sender, EventArgs e)
        {
            string nom = textNombre.Text;
            string dir = txtDireccion.Text;
            string desc = txtDescripcion.Text;

            if ((nom == "") || (dir == "") || (desc == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                hot.NombreHotel = textNombre.Text;
                hot.DescripcionHotel = txtDescripcion.Text;
                hot.DireccionHotel = txtDireccion.Text;
                hot.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                hot.NumHabitaciones = Convert.ToInt32(textHab.Value);
                hot.Pisos = Convert.ToInt32(textPisos.Value);
                hot.FechaRegistroHotel = DateTime.Now.ToString("yyyy-MM-dd");

                var success = cass.InsertarHotel(hot);

                if (success)
                {
                    MessageBox.Show("Hotel registrado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void frmHotel_Load(object sender, EventArgs e)
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


            cboestado.Items.Add(new OpcionCombo { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo { Valor = 0, Texto = "Inactivo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Hotel> lista = cass.ListarHotel();
            cass.ListarHotel();
            foreach (Hotel item in lista)
            {
                dataUser.Rows.Add(new object[] {"", 
                    item.NombreHotel, 
                    item.DescripcionHotel, 
                    item.DireccionHotel,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                    item.NumHabitaciones,
                    item.Pisos,
                    item.FechaRegistroHotel.ToString()

                });
            }
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUser.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    textNombre.Text = dataUser.Rows[indice].Cells["Nom_Hot"].Value.ToString();
                    txtDireccion.Text = dataUser.Rows[indice].Cells["Dir_Hot"].Value.ToString();
                    txtDescripcion.Text = dataUser.Rows[indice].Cells["Desc_Hot"].Value.ToString();
                    textHab.Text = dataUser.Rows[indice].Cells["Habitaciones"].Value.ToString();
                    textPisos.Text = dataUser.Rows[indice].Cells["Pisos"].Value.ToString();

                    textId.Text = dataUser.Rows[indice].Cells["Nom_Hot"].Value.ToString();

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataUser.Rows[indice].Cells["Estado"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).Valor.ToString();
            if (dataUser.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataUser.Rows)
                {
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

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textId.Text) != "-1")
            {
                if (MessageBox.Show("¿Desea eliminar el Hotel?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hot.NombreHotel = textId.Text;
                    var respuesta = cass.EliminarHotel(hot);

                    if (respuesta)
                    {
                        MessageBox.Show("Hotel eliminado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun hotel", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            textNombre.Text = "";
            txtDireccion.Text = "";
            txtDescripcion.Text = "";
            textPisos.Value = 1;
            textHab.Value = 1;
            cboestado.SelectedIndex = 0;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string nom = textNombre.Text;
            string dir = txtDireccion.Text;
            string desc = txtDescripcion.Text;

            if ((nom == "") || (dir == "") || (desc == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

        
                hot.DescripcionHotel = txtDescripcion.Text;
                hot.DireccionHotel = txtDireccion.Text;
                hot.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                hot.NumHabitaciones = Convert.ToInt32(textHab.Value);
                hot.Pisos = Convert.ToInt32(textPisos.Value);

                hot.NombreHotel = textId.Text;

                var success = cass.EditarHotel(hot);
                if (success)
                {
                    MessageBox.Show("Hotel editado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Algo salio mal, revisa los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
