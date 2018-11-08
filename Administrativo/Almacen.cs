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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
            funciones n = new funciones();
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());
            //cargando datos de la bd, se muestra tabla de usuarios
            n.BD_mostrarDispositivos(dataGridView1, this);
        }

        //boton regresar menu
        private void button4_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaMenu(this);
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //boton agregar dispositivo
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //boton asignar dispositivo
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //boton ajustar inventario
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //boton recibir dispositivo
        private void button5_Click(object sender, EventArgs e)
        {

        }
        //boton baja dispositivo
        private void button6_Click(object sender, EventArgs e)
        {

        }
        //boton buscar
        private void button7_Click(object sender, EventArgs e)
        {

        }
        //textbos buscar
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
