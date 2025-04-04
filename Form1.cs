using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERRETERIAPROYECTO
{
    public partial class Form1: Form
    {
        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TXTUSUARI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Obtener el texto de los TextBox de usuario y contraseña
            string username = TXTUSUARI.Text;
            string password = TXTCONTRASENA.Text;

            // Obtener el tipo de usuario llamando al método 'ObtenerTipoUsuario' de 'conexionBD'
            string tipoUsuario = cn.ObtenerTipoUsuario(username, password);

            // Validar las credenciales del usuario
            if (tipoUsuario != null)
            {
                // Si el usuario es válido, abrir el formulario principal
                MENU menu= new MENU();
                menu.TipoUsuario = tipoUsuario; // Pasa el tipo de usuario al formulario principal
                menu.Show();
                this.Hide(); // Oculta el formulario de login
            }
            else
            {
                // Si las credenciales son inválidas, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña inválidos.");
            }
        }


        

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
