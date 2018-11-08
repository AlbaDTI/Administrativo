using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Administrativo
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
            funciones n = new funciones();
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());


        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

    

        //boton para agregar usaurios
        private void button2_Click_1(object sender, EventArgs e)
        {
           funciones n = new funciones();
            n.BD_AgregarUsuarios(txtNombre, txtApellido,txtEdad,txtDomicilio, txtTelefono,
                                 txtMovil,txtCorreo, txtNEmpleado, txtUsuario,txtpassword);


        }
        //boton para añadir rol
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //boton para regresar
        private void button1_Click_1(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaRH(this);
        }


        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
