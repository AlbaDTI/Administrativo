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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            funciones n = new funciones();
            //agregando barra personalizada
           n.AgregarMenu(panel1, new Barra());


        }


       private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }         
       private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

              


        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Loging lggng = new Loging();

            lggng.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaPanelControl(this);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Almacen NvoAlmcn = new Almacen();
            NvoAlmcn.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Caja NvoCaja = new Caja();
            NvoCaja.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RecursosHumanos RH = new RecursosHumanos();
            RH.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Clientes NvoCliente=new Clientes();
             NvoCliente.Show();
        }
        

        private void Menu_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
