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
    public partial class agregarRol : Form
    {
        public agregarRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.BD_AgregarRol(textBox1);
            n.BD_Roles(dataGridView1, this);
        }

        private void agregarRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'innHogarDataSet.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.innHogarDataSet.roles);

        }
    }
}
