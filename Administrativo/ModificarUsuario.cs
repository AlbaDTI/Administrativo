using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrativo
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();

            funciones n = new funciones();
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());
            /*Adaptando ell tamaño de form al de la pantalla*/

        }



        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ModificarUsuario_Load_1(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaRH(this);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void habilita(Boolean habilitar)
        {
            button2.Enabled = habilitar;
            button3.Enabled = habilitar;
            comboBox1.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            txtDomicilio.Enabled = habilitar;
            txtEdad.Enabled = habilitar;
            txtMovil.Enabled = habilitar;
            txtNEmpleado.Enabled = habilitar;
            txtpassword.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtUsuario.Enabled = habilitar;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            habilita(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.BD_ModificarOperador (
            txtNombre,txtApellido,txtEdad,
            txtDomicilio, txtTelefono,txtMovil,
            txtCorreo,txtNEmpleado,txtUsuario,txtpassword);
            habilita(false);
        }
    }
}
