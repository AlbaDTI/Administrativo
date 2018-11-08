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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            funciones n = new funciones();
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());
            //cargando datos de la bd, se muestra tabla clientes
            n.BD_mostrarClientes(dataGridView1, this);
        }
        //boton regresar menu
        private void button4_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaMenu(this);

        }


        private void Clientes_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //boton cliente
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //label cliente
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
