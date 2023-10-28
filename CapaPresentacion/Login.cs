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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        EnlaceCassandra cass = new EnlaceCassandra();
        private void Login_Load(object sender, EventArgs e)
        {
            cass.ObtenerUsuarios();

            cboPuesto.Items.Add(new OpcionCombo { Valor = 1, Texto = "ADMINISTRADOR" });
            cboPuesto.Items.Add(new OpcionCombo { Valor = 2, Texto = "EMPLEADO" });
            cboPuesto.DisplayMember = "Texto";
            cboPuesto.ValueMember = "Valor";
            cboPuesto.SelectedIndex = 0;

            //Console.WriteLine("Terminado");
            //Console.ReadKey();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            

            if (cboPuesto.Text == "ADMINISTRADOR")
            {
                if (cass.login(textusuario.Text, textcontrasenia.Text, cboPuesto.SelectedIndex))
                {
                    Inicio form = new Inicio();

                    form.Show();
                    this.Hide();

                    form.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("Correo o Contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                if (cass.login(textusuario.Text, textcontrasenia.Text, cboPuesto.SelectedIndex))
                {
                    InicioEmp form = new InicioEmp();

                    form.Show();
                    this.Hide();

                    form.FormClosing += frm_closing;
                }
                else {
                    MessageBox.Show("Correo o Contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textusuario.Text = "";
            textcontrasenia.Text = "";
            this.Show();
        }
    }
}
