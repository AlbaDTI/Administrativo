using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Administrativo
{
    class funciones
    {

        /****************************************
        *FUNCIONES PARA ABRIR VENTANAS          *
        ****************************************/
        //FUNCIÓN  ABRIR VENTANA MENU (MODULOS)
        public void VentanaMenu(object v)
        {
           
            Form ventana = v as Form;
            ventana.Hide();
            Menu NvaVentana = new Menu();
            NvaVentana.Show();


        }
        //FUNCIÓN  ABRIR MODULO CLIENTES
        public void VentanaCientes(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            Clientes NvaVentana = new Clientes();
            NvaVentana.Show();

        }
        //FUNCIÓN  ABRIR MODULO CAJA
        public void VentanaCaja(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            Caja NvaVentana = new Caja();
            NvaVentana.Show();

        }
        //FUNCIÓN  ABRIR VENTANA RECURSOS HUMANOS
        public void VentanaRH(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            RecursosHumanos NvaVentana = new RecursosHumanos();
            NvaVentana.Show();

        }
        //FUNCIÓN  ABRIR VENTANA PARA AGREGAR USUARIOS
        public void VentanaAgregarRH(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            AgregarUsuario NvaVentana = new AgregarUsuario();
            NvaVentana.Show();

        }
        public void VentanaModificarRH(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            ModificarUsuario NvaVentana = new ModificarUsuario();
            NvaVentana.Show();

        }

        public void VentanaPanelControl(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
           panelControl NvaVentana = new panelControl();
            NvaVentana.Show();

        }
        public void VentanaPanel(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            panel NvaVentana = new panel();
            NvaVentana.Show();

        }
        public void VentanaDispositivo(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            Dispositivo NvaVentana = new Dispositivo();
            NvaVentana.Show();

        }
        public void VentanaControl(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            Control NvaVentana = new Control();
            NvaVentana.Show();

        }
        public void VentanaControlCamara(object v)
        {
            Form ventana = v as Form;
            ventana.Close();
            ControlCamara NvaVentana = new ControlCamara();
            NvaVentana.Show();

        }


        /****************************************
         *FUNCIONES DE LA BARRA PPERSONALIZADA  *
         ****************************************/

        //Función para agregar la barra personalizada
        public void AgregarMenu(Panel panel1, object menu)
        {

            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
          
            Form Brr = menu as Form;
            Brr.TopLevel = false;
            Brr.Dock = DockStyle.Fill;
            panel1.Controls.Add(Brr);
            panel1.Tag = Brr;
            Brr.Show();

        }

       
        //función para cerrar programa (en la barra personalizada)
        public void CerrarPrograma(object v)
        {
            if (MessageBox.Show("¿Cerrar el programa?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //función para Minimizar programa programa (en la barra personalizada)
        public void MinimizarPrograma(object v)
        {
        }
        //función para cerrar sesión
        public void CerrarSesion(object v)
        {
            if (MessageBox.Show("¿Cerrar sesión?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Form ventana = v as Form;
                ventana.Hide();
                Loging lggng = new Loging();
                lggng.Show();
            }
        }



        /****************************************
        *FUNCIONES DE LA BASE DE DATOS *
        ****************************************/
        public void BD_mostrarUsuarios(DataGridView dataGridView1, object menu)
        {

            var consulta = "SELECT nombre, apellidos, domicilio,eMail,telefono,tel_celular FROM users;";
            var c = new MySqlConnection("server=albadti2018.ddns.net; database=InnHogar; Uid=root; pwd=Alba+2018");

            var adaptador = new MySqlDataAdapter(consulta, c);
            var commandBuilder = new MySqlCommandBuilder(adaptador);

            var ds = new DataSet();
            adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        public void BD_mostrarDispositivos(DataGridView dataGridView1, object menu)
        {
            /*
            var consulta = "SELECT nombre, apellidos, domicilio,eMail,telefono,telCelular FROM usuarios;";
            var c = new MySqlConnection("server=localhost; database=administrativos; Uid=root; pwd=");

            var adaptador = new MySqlDataAdapter(consulta, c);
            var commandBuilder = new MySqlCommandBuilder(adaptador);

            var ds = new DataSet();
            adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            */
        }
        public void BD_mostrarClientes(DataGridView dataGridView1, object menu)
        {
            /*
            var consulta = "SELECT nombre, apellidos, domicilio,eMail,telefono,telCelular FROM usuarios;";
            var c = new MySqlConnection("server=localhost; database=administrativos; Uid=root; pwd=");

            var adaptador = new MySqlDataAdapter(consulta, c);
            var commandBuilder = new MySqlCommandBuilder(adaptador);

            var ds = new DataSet();
            adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            */
        }
        public void BD_AgregarUsuarios(
            TextBox txtNombre, TextBox txtApellido, TextBox txtEdad,
            TextBox txtDomicilio, TextBox txtTelefono, TextBox txtMovil,
            TextBox txtCorreo, TextBox txtNEmpleado, TextBox txtUsuario,
            TextBox txtpassword)
        {


            MySqlConnection conexion = new MySqlConnection("server=localhost; database=administrativos; Uid=root; pwd=;");
            //utilizamos el procedimiento alamacenado insertarusuarios
            MySqlCommand cmd = new MySqlCommand("AgregarUsuario", conexion);
            //especificamos que el comando es un procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            //creamos los parametros que usaremos
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text);
            cmd.Parameters.AddWithValue("@edad", txtEdad.Text);

            cmd.Parameters.AddWithValue("@domicilio", txtDomicilio.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@celular", txtMovil.Text);
            cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@NumEmpleado", txtNEmpleado.Text);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            //abrimos conexion
            conexion.Open();
            //ejecutamos la instruccion con ExcecuteNonQuerry indicando que no retorna registros.
            cmd.ExecuteNonQuery();
            MessageBox.Show("El usuario se ha agregado", "Cerrar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNombre.Clear();

            txtApellido.Clear();
            txtEdad.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtMovil.Clear();
            txtCorreo.Clear();
            txtNEmpleado.Clear();
            txtUsuario.Clear();
            txtpassword.Clear();
            //cerramos conexion
            conexion.Close();


        }

        /*public void BD_Loggin(TextBox usser, TextBox contra, object menu)
        {
            
            var consulta = "SELECT password FROM usuarios;";
            var c = new MySqlConnection("server=localhost; database=administrativos; Uid=root; pwd=");

            var adaptador = new MySqlDataAdapter(consulta, c);
            var commandBuilder = new MySqlCommandBuilder(adaptador);

            var ds = new DataSet();
            adaptador.Fill(ds);
            
        }*/
    }
}
