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
    public partial class frmHabitacion : Form
    {
        public frmHabitacion()
        {
            InitializeComponent();
        }

        EnlaceCassandra cass = new EnlaceCassandra();
        Habitacion hab = new Habitacion();
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtdescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string nom = textNombre.Text;
            string desc = txtDescripcion.Text;

            if ((nom == "") || (desc == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                hab.NombreHab = textNombre.Text;
                hab.DescripcionHab = txtDescripcion.Text;
                hab.NumeroCamas = Convert.ToInt32(txtPR.Value);
                hab.CostoPersona = txtPersona.Value;
                hab.TipoHabitacion = Convert.ToInt32(((OpcionCombo)cbohabitacion.SelectedItem).Valor);
                hab.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;
               
                hab.FechaRegistroHab = DateTime.Now.ToString("yyyy-MM-dd");

                var success = cass.InsertarHabitacion(hab);

                if (success)
                {
                    MessageBox.Show("Habitacion registrado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
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
            cboestado.Items.Add(new OpcionCombo { Valor = true, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo { Valor = false, Texto = "Inactivo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;
            
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 8, Texto = "Master Suite" });
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 7, Texto = "Suite" });
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 6, Texto = "King" });
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 5, Texto = "Queen" });
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 4, Texto = "Quad" });
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 3, Texto = "Triple" });
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 2, Texto = "Doble" });
            cbohabitacion.Items.Add(new OpcionCombo { Valor = 1, Texto = "Individual" });
            cbohabitacion.DisplayMember = "Texto";
            cbohabitacion.ValueMember = "Valor";
            cbohabitacion.SelectedIndex = 0;


            List<Habitacion> lista = cass.ListarHabitacion();
            cass.ListarHabitacion();
            foreach (Habitacion item in lista)
            {
                dataUser.Rows.Add(new object[] {"",
                    item.NombreHab,
                    item.DescripcionHab,
                    item.CostoPersona,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                    item.NumeroCamas,

                    item.TipoHabitacion,
                    item.TipoHabitacion.ToString(),

                    item.FechaRegistroHab.ToString()

                });
            }
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                txtindice.Text = indice.ToString();


                textNombre.Text = dataUser.Rows[indice].Cells["Nom_Hab"].Value.ToString();
                txtDescripcion.Text = dataUser.Rows[indice].Cells["Desc_Hab"].Value.ToString();
                txtPR.Text = dataUser.Rows[indice].Cells["Cam_Hab"].Value.ToString();


                txtPersona.Text = dataUser.Rows[indice].Cells["Costo"].Value.ToString();


                textId.Text = dataUser.Rows[indice].Cells["Nom_Hab"].Value.ToString();

                foreach (OpcionCombo oc in cboestado.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataUser.Rows[indice].Cells["Estado"].Value))
                    {
                        int indice_combo = cboestado.Items.IndexOf(oc);
                        cboestado.SelectedIndex = indice_combo;
                        break;
                    }
                }

                foreach (OpcionCombo oc in cbohabitacion.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataUser.Rows[indice].Cells["Tipo"].Value))
                    {
                        int indice_combo = cbohabitacion.Items.IndexOf(oc);
                        cbohabitacion.SelectedIndex = indice_combo;
                        break;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtindice.Text = "-1";
            textId.Text = "-1";
            textNombre.Text = "";
            txtDescripcion.Text = "";
            txtPR.Value = 1;
            txtPersona.Value = 1;

            cboestado.SelectedIndex = 0;
            cbohabitacion.SelectedIndex = 0;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textId.Text) != "-1")
            {
                if (MessageBox.Show("¿Desea eliminar la habitacion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hab.NombreHab = textId.Text;
                    var respuesta = cass.EliminarHabitacion(hab);

                    if (respuesta)
                    {
                        MessageBox.Show("Habitacion eliminada exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna habitacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string nom = textNombre.Text;
            string desc = txtDescripcion.Text;

            if ((nom == "") || (desc == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                hab.DescripcionHab = txtDescripcion.Text;
                hab.NumeroCamas = Convert.ToInt32(txtPR.Value);
                hab.CostoPersona = txtPersona.Value;
                hab.TipoHabitacion = Convert.ToInt32(((OpcionCombo)cbohabitacion.SelectedItem).Valor);
                hab.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                hab.NombreHab = textId.Text;

                var success = cass.EditarHabitacion(hab);

                if (success)
                {
                    MessageBox.Show("Habitacion editada exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }
        }
    }
}
