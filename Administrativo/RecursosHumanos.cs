using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Administrativo
{
    public partial class RecursosHumanos : Form
    {
        funciones n= new funciones();
        public RecursosHumanos()
        {
            
            InitializeComponent();

            
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());
            //cargando datos de la bd, se muestra tabla de usuarios
            n.BD_mostrarOperadores(dataGridView1,this);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void RecursosHumanos_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }


        //boton para regresar al menu
        private void button4_Click_1(object sender, EventArgs e)
        {
            n.VentanaMenu(this);
        }
        //boton para agregar usuario nuevo
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            n.VentanaAgregarRH(this);
        }
        //boton para modificar usuario 
        private void button2_Click(object sender, EventArgs e)
        {
            n.VentanaModificarRH(this);
        }
        //boton para eliminar usuario 
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar usuario?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                
            }
        }
        //textBox Buscar usuario
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecursosHumanos_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cargando datos de la bd, se muestra tabla de usuarios
           
        }
    }
}
