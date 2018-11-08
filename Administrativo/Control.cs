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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
            funciones n = new funciones();
            //agregando barra personalizada
            n.AgregarMenu(panel1, new Barra());
        }

        private void Control_Load(object sender, EventArgs e)
        {
            /*Adaptando ell tamaño de form al de la pantalla*/
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaPanel(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.VentanaControlCamara(this);
        }
    }
}
