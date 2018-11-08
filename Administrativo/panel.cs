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
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
            funciones n = new funciones();
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaPanelControl(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaDispositivo(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaControl(this);

        }
    }
}
