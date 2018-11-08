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
    public partial class Loging : Form
    {
        public Loging()
        {
            InitializeComponent();
            
        }

       
      private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Loging_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; 
            
        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            funciones n = new funciones();
            n.VentanaMenu(this);
        }
    }
}
