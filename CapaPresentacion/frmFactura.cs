using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmFactura : Form
    {

        EnlaceCassandra cass = new EnlaceCassandra();

        Factura factura = new Factura();
        public frmFactura()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            factura.IdFactura = int.Parse(textBox8.Text);
            factura.NombreClienteFactura = textBox2.Text;

            factura.TipoCambio= Convert.ToInt32(((OpcionCombo)comboBox1.SelectedItem).Valor);


            factura.CantidadPersonas = int.Parse(textBox6.Text);
            factura.TipoPieza = textBox10.Text;
            factura.Precio = decimal.Parse(textBox12.Text);
            //reservacion.Importe=textbox.Text;
            factura.Subtotal = decimal.Parse(textBox9.Text);
            //factura.Iva = int.Parse(textBox11.Text);
            factura.Total = decimal.Parse(textBox11.Text);


            string theDate = dateTimePicker1.Text;
            String.Format("{0:yyyy-MM-dd}", theDate);
            factura.FechaVencimiento = theDate;


            var success = cass.InsertarFactura(factura);
            if (success)

                MessageBox.Show("Se agrego la Reservacion", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dataUser1.DataSource = cass.Obtener_Factura();
        }





        private void frmFactura_Load_1(object sender, EventArgs e)
        {
            dataUser1.DataSource = cass.Obtener_Factura();

            comboBox1.Items.Add(new OpcionCombo { Valor = 4, Texto = "Yen" });
            comboBox1.Items.Add(new OpcionCombo { Valor = 3, Texto = "Peso" });
            comboBox1.Items.Add(new OpcionCombo { Valor = 2, Texto = "Euro" });
            comboBox1.Items.Add(new OpcionCombo { Valor = 1, Texto = "Dolar" });
            comboBox1.DisplayMember = "Texto";
            comboBox1.ValueMember = "Valor";
            comboBox1.SelectedIndex = 0;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            dataUser1.DataSource = cass.Obtener_Factura();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la Factura?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                factura.IdFactura = int.Parse(textBox8.Text); ;
                var respuesta = cass.EliminarFactura(factura);

                if (respuesta)
                {
                    MessageBox.Show("Factura eliminado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            dataUser1.DataSource = cass.Obtener_Factura();
        }

        private void dataUser1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUser1.Columns[e.ColumnIndex].Name == "btnfactselect")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox8.Text = dataUser1.Rows[indice].Cells["IdFactura"].Value.ToString();
                    textBox2.Text = dataUser1.Rows[indice].Cells["NombreClienteFactura"].Value.ToString();

            
                    foreach (OpcionCombo oc in comboBox1.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataUser1.Rows[indice].Cells["TipoCambio"].Value))
                        {
                            int indice_combo = comboBox1.Items.IndexOf(oc);
                            comboBox1.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    textBox6.Text = dataUser1.Rows[indice].Cells["CantidadPersonas"].Value.ToString();
                    textBox10.Text = dataUser1.Rows[indice].Cells["TipoPieza"].Value.ToString();
                    textBox12.Text = dataUser1.Rows[indice].Cells["Precio"].Value.ToString();
                    textBox9.Text = dataUser1.Rows[indice].Cells["Subtotal"].Value.ToString();
                    textBox11.Text = dataUser1.Rows[indice].Cells["Total"].Value.ToString();
                }
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
