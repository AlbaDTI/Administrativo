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
    public partial class ControlCamara : Form
    {
        public ControlCamara()
        {
            InitializeComponent();

            funciones n = new funciones();
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());
        }

        private void ControlCamara_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaControl(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaControl(this);
        }
    }
}
