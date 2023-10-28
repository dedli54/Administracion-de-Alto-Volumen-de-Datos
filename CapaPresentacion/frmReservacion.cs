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
    public partial class frmReservacion : Form
    {
        int indexbox;
        bool selection = false;
        EnlaceCassandra cass = new EnlaceCassandra();

        Reservacion reservacion = new Reservacion();
        public frmReservacion()
        {
            InitializeComponent();
        }




        private void iconButton2_Click(object sender, EventArgs e)
        {
            reservacion.IdReservacion = int.Parse(textBox4.Text);
            reservacion.HotelReservacion = textBox15.Text;
            reservacion.CartaResponsiva = textBox1.Text;
            reservacion.TipoHabitacion = int.Parse(textBox2.Text);
            reservacion.NumeroPersonasR = (int)cantidad1.Value;
            string theDate = dateTimePicker1.Text;
            String.Format("{0:yyyy-MM-dd}", theDate);
            string salida = dateTimePicker2.Text;
            String.Format("{0:yyyy-MM-dd}", salida);
            reservacion.ServicioAdicionalR = Convert.ToInt32(((OpcionCombo)comboBox2.SelectedItem).Valor);
            reservacion.NombreCliente = textBox16.Text;
            reservacion.Precio = decimal.Parse(textBox3.Text);
            reservacion.CheckIn = theDate;
            reservacion.CheckOut = salida;
            reservacion.MontoPagado = decimal.Parse(textBox6.Text);
            reservacion.MetodoPago = Convert.ToInt32(((OpcionCombo)comboBox1.SelectedItem).Valor);
            reservacion.CartaResponsiva = textBox1.Text;
            reservacion.FechaModificacion = DateTime.Now.ToString("yyyy-MM-dd");


            //reservacion.Impuesto = decimal.Parse();


            var success = cass.InsertarReservacion(reservacion);
            if (success)

                MessageBox.Show("Se agrego la Reservacion", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dataGridView1.DataSource = cass.Obtener_Reservacion();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }









        private void frmReservacion_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = cass.Obtener_Reservacion();

            comboBox2.Items.Add(new OpcionCombo { Valor = 6, Texto = "Salon" });
            comboBox2.Items.Add(new OpcionCombo { Valor = 5, Texto = "Piscina" });
            comboBox2.Items.Add(new OpcionCombo { Valor = 4, Texto = "Manicura" });
            comboBox2.Items.Add(new OpcionCombo { Valor = 3, Texto = "Buffet" });
            comboBox2.Items.Add(new OpcionCombo { Valor = 2, Texto = "Masajista" });
            comboBox2.Items.Add(new OpcionCombo { Valor = 1, Texto = "Champagne" });
            comboBox2.DisplayMember = "Texto";
            comboBox2.ValueMember = "Valor";
            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Add(new OpcionCombo { Valor = 2, Texto = "Efectivo" });
            comboBox1.Items.Add(new OpcionCombo { Valor = 1, Texto = "Cheque" });
            comboBox1.DisplayMember = "Texto";
            comboBox1.ValueMember = "Valor";
            comboBox1.SelectedIndex = 0;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            reservacion.IdReservacion = int.Parse(textBox4.Text);
            reservacion.HotelReservacion = textBox15.Text;
            reservacion.TipoHabitacion = int.Parse(textBox2.Text);
            reservacion.NumeroPersonasR = (int)cantidad1.Value;
            string theDate = dateTimePicker1.Text;
            String.Format("{0:yyyy-MM-dd}", theDate);
            string salida = dateTimePicker2.Text;
            String.Format("{0:yyyy-MM-dd}", salida);
            reservacion.ServicioAdicionalR = Convert.ToInt32(((OpcionCombo)comboBox2.SelectedItem).Valor);
            reservacion.NombreCliente = textBox16.Text;
            reservacion.Precio = decimal.Parse(textBox3.Text);
            reservacion.CheckIn = theDate;
            reservacion.CheckOut = salida;
            reservacion.MontoPagado = decimal.Parse(textBox6.Text);
            reservacion.MetodoPago = Convert.ToInt32(((OpcionCombo)comboBox1.SelectedItem).Valor); 
            reservacion.CartaResponsiva = textBox1.Text;
            reservacion.FechaModificacion = DateTime.Now.ToString("yyyy-MM-dd");
            var success = cass.EditarReservacion(reservacion);
            if (success)
            {
                MessageBox.Show("Reservacion editada exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Algo salio mal, revisa los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = cass.Obtener_Reservacion();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la Reservacion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reservacion.IdReservacion = int.Parse(textBox4.Text); ;
                var respuesta = cass.EliminarReservacion(reservacion);

                if (respuesta)
                {
                    MessageBox.Show("Reservacion eliminado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            dataGridView1.DataSource = cass.Obtener_Reservacion();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnseleccion")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox4.Text = dataGridView1.Rows[indice].Cells["IdReservacion"].Value.ToString();
                    textBox15.Text = dataGridView1.Rows[indice].Cells["HotelReservacion"].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[indice].Cells["TipoHabitacion"].Value.ToString();
                    cantidad1.Text = dataGridView1.Rows[indice].Cells["NumeroPersonasR"].Value.ToString();

                   foreach (OpcionCombo oc in comboBox2.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["ServicioAdicionalR"].Value))
                        {
                            int indice_combo = comboBox2.Items.IndexOf(oc);
                            comboBox2.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    textBox16.Text = dataGridView1.Rows[indice].Cells["NombreCliente"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[indice].Cells["CartaResponsiva"].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[indice].Cells["Precio"].Value.ToString();
                    textBox6.Text = dataGridView1.Rows[indice].Cells["MontoPagado"].Value.ToString();

                    foreach (OpcionCombo oc in comboBox1.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["MetodoPago"].Value))
                        {
                            int indice_combo = comboBox1.Items.IndexOf(oc);
                            comboBox1.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    dateTimePicker1.Text = dataGridView1.Rows[indice].Cells["CheckIn"].Value.ToString();
                    dateTimePicker2.Text = dataGridView1.Rows[indice].Cells["CheckOut"].Value.ToString();
                }

            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
