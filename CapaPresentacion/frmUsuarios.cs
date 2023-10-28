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
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {

        public frmUsuarios()
        {
            InitializeComponent();
        }
        EnlaceCassandra cass = new EnlaceCassandra();
        Usuario usu = new Usuario();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string pass = txtContrasenia.Text;
            string confpass = txtConfirmContra.Text;

            string nom = txtNombre.Text;
            string apePat = txtApePat.Text;
            string apeMat = txtApeMat.Text;
            string tel = txtTel.Text;
            string curp = txtCURP.Text;
            string nomina = textNomina.Text;
            int pues = Convert.ToInt32(((OpcionCombo)cbopuesto.SelectedItem).Valor);
            bool est = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) != 1 ? false : true;




        if ((nom == "")||(apePat == "")||(apeMat == "")||(tel == "")||(curp == "")||(nomina == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pass != confpass)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validarEmail(txtCorreo.Text) == false) {
                MessageBox.Show("Formato de correo no valido", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (validarContrasenia(txtContrasenia.Text) == false)
            {
                MessageBox.Show("Formato de contraseña no valido (Debe contener al menos una mayuscula, minuscula, numero, caracter especial y der mayor a 8 digitos)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                usu.Nombre = txtNombre.Text;
                usu.ApePaterno = txtApePat.Text;
                usu.ApeMaterno = txtApeMat.Text;
                usu.Telefono = txtTel.Text;
                usu.CURP = txtCURP.Text;
                usu.Correo = txtCorreo.Text;
                usu.Contrasenia = txtContrasenia.Text;
                usu.NumeroNomina = textNomina.Text;
                usu.Puesto = Convert.ToInt32(((OpcionCombo)cbopuesto.SelectedItem).Valor);
                usu.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;
                usu.FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd");

                var success = cass.InsertarUsuario(usu);
                if (success)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }     
            }
        }

        public static bool validarEmail(string email){
            string emailFormato= "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, emailFormato))
            {
                if (Regex.Replace(email, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else {
                return false;
            }
        }

        public static bool validarContrasenia(string contrasenia){
            bool mayus = false, minus = false, num = false, charesp = false;
            for (int i = 0; i < contrasenia.Length; i++) {
                if (char.IsUpper(contrasenia, i)) {
                    mayus = true;
                }
                else if (char.IsLower(contrasenia, i)) {
                    minus = true;
                }
                else if (char.IsDigit(contrasenia, i)) {
                    num = true;
                }
                else {
                    charesp = true;
                }
            }
            if (mayus && minus && num && charesp && contrasenia.Length >= 8) {
                return true;
            }
            return false;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtindice.Text = "-1";
            textId.Text = "-1";
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
            txtTel.Text = "";
            txtCorreo.Text = "";
            txtCURP.Text = "";
            txtContrasenia.Text = "";
            txtConfirmContra.Text = "";
            textNomina.Text = "";
            cbopuesto.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }

        private void textNomina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
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

            cbopuesto.Items.Add(new OpcionCombo { Valor = 2, Texto = "EMPLEADO" });
            cbopuesto.Items.Add(new OpcionCombo { Valor = 1, Texto = "ADMINISTRADOR" });
            cbopuesto.DisplayMember = "Texto";
            cbopuesto.ValueMember = "Valor";
            cbopuesto.SelectedIndex = 0;

            List<Usuario> lista = cass.ListarUsuario();
            cass.ListarUsuario();
            foreach (Usuario item in lista)
            {
                dataUser.Rows.Add(new object[] {"",
                    item.Nombre, item.ApePaterno, item.ApeMaterno, item.Telefono, item.CURP, item.Correo, item.Contrasenia, item.NumeroNomina, 
                    item.Puesto,
                    item.Puesto.ToString(),
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",

                    item.FechaRegistro.ToString()

                });
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

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUser.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    textId.Text = dataUser.Rows[indice].Cells["Correo"].Value.ToString();

                    txtNombre.Text = dataUser.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApePat.Text = dataUser.Rows[indice].Cells["ApePaterno"].Value.ToString();
                    txtApeMat.Text = dataUser.Rows[indice].Cells["ApeMaterno"].Value.ToString();
                    txtTel.Text = dataUser.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = dataUser.Rows[indice].Cells["Correo"].Value.ToString();
                    txtCURP.Text = dataUser.Rows[indice].Cells["CURP"].Value.ToString();
                    txtContrasenia.Text = dataUser.Rows[indice].Cells["Contrasenia"].Value.ToString();
                    txtConfirmContra.Text = dataUser.Rows[indice].Cells["Contrasenia"].Value.ToString();
                    textNomina.Text = dataUser.Rows[indice].Cells["NumNomina"].Value.ToString();

                    foreach (OpcionCombo oc in cbopuesto.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataUser.Rows[indice].Cells["IdPuesto"].Value))
                        {
                            int indice_combo = cbopuesto.Items.IndexOf(oc);
                            cbopuesto.SelectedIndex = indice_combo;
                            break;
                        }
                    }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textId.Text) != "-1")
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usu.Correo = textId.Text;
                    var respuesta = cass.EliminarUsuario(usu);

                    if (respuesta)
                    {
                        MessageBox.Show("Usuario eliminado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string pass = txtContrasenia.Text;
            string confpass = txtConfirmContra.Text;

            string nom = txtNombre.Text;
            string apePat = txtApePat.Text;
            string apeMat = txtApeMat.Text;
            string tel = txtTel.Text;
            string curp = txtCURP.Text;
            string nomina = textNomina.Text;
            int pues = Convert.ToInt32(((OpcionCombo)cbopuesto.SelectedItem).Valor);
            bool est = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) != 1 ? false : true;




            if ((nom == "") || (apePat == "") || (apeMat == "") || (tel == "") || (curp == "") || (nomina == ""))
            {
                MessageBox.Show("Favor de llenar todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pass != confpass)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validarEmail(txtCorreo.Text) == false)
            {
                MessageBox.Show("Formato de correo no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validarContrasenia(txtContrasenia.Text) == false)
            {
                MessageBox.Show("Formato de contraseña no valido (Debe contener al menos una mayuscula, minuscula, numero, caracter especial y der mayor a 8 digitos)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                usu.Nombre = txtNombre.Text;
                usu.ApePaterno = txtApePat.Text;
                usu.ApeMaterno = txtApeMat.Text;
                usu.Telefono = txtTel.Text;
                usu.CURP = txtCURP.Text;
                usu.Contrasenia = txtContrasenia.Text;
                usu.NumeroNomina = textNomina.Text;
                usu.Puesto = Convert.ToInt32(((OpcionCombo)cbopuesto.SelectedItem).Valor);
                usu.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                usu.Correo = textId.Text;

                var success = cass.EditarUsuario(usu);
                if (success)
                {
                    MessageBox.Show("Usuario editado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


    }
}

