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
    public partial class EMPLEADO : Form
    {

        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idempleado = 1;
        public EMPLEADO()
        {
            InitializeComponent();
        }

        private void EMPLEADO_Load(object sender, EventArgs e)
        {
            datos.mostrarempleados(DGVEMPLEADO);
            TXTIDEMPLEADO.Text = idempleado.ToString();
        }

        private void BTNAGREGARE_Click(object sender, EventArgs e)
        {         
            if (!string.IsNullOrEmpty(TXTNOMBREE.Text) &&
                !string.IsNullOrEmpty(TXTAPELLIDOE.Text) &&
                !string.IsNullOrEmpty(TXTDNIE.Text) &&
                !string.IsNullOrEmpty(TXTCONTRAE.Text) &&
                !string.IsNullOrEmpty(TXTTELEFONOE.Text) &&
                !string.IsNullOrEmpty(TXTSUELDOE.Text) &&
                !string.IsNullOrEmpty(cmbcargo.Text))
            {
                // Incrementar el idempleado
                idempleado++;
                TXTIDEMPLEADO.Text = idempleado.ToString();

                // Obtener los valores de los TextBox
                string nombre = TXTNOMBREE.Text;
                string apellido = TXTAPELLIDOE.Text;
                string dni = TXTDNIE.Text;
                string contraseña = TXTCONTRAE.Text;
                int telefono = int.Parse(TXTTELEFONOE.Text);
                float sueldo = float.Parse(TXTSUELDOE.Text);
                string cargo = cmbcargo.Text;
                DateTime fecha = DTPFECHAE.Value;

                // Agregar los datos al sistema
                datos.agregarempleado(nombre, apellido, dni, contraseña, telefono, sueldo, cargo, fecha);
                datos.mostrarempleados(DGVEMPLEADO);

                // Limpiar los TextBox después de agregar los datos
                TXTNOMBREE.Clear();
                TXTAPELLIDOE.Clear();
                TXTDNIE.Clear();
                TXTCONTRAE.Clear();
                TXTTELEFONOE.Clear();
                TXTSUELDOE.Clear();
                DTPFECHAE.Value = DateTime.Now; // Opcional: Resetear la fecha actual del DateTimePicker

            }
            else
            {
                // Si algún campo está vacío, mostrar un mensaje de advertencia
                MessageBox.Show("Por favor, complete todos los campos.");
            }

        }

        private void BTNELIMINARE_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();


            int id = Convert.ToInt32(DGVEMPLEADO.CurrentRow.Cells["idempleado"].Value);
            string nombre = DGVEMPLEADO.CurrentRow.Cells["nombree"].Value?.ToString();
            string apellido = DGVEMPLEADO.CurrentRow.Cells["apellidoe"].Value?.ToString();
            string dni = DGVEMPLEADO.CurrentRow.Cells["dnie"].Value?.ToString();
            string contraseña = DGVEMPLEADO.CurrentRow.Cells["contraseña"].Value?.ToString();
            int telefono = Convert.ToInt32((DGVEMPLEADO.CurrentRow.Cells["telefonoe"].Value));
            float sueldo = Convert.ToSingle(DGVEMPLEADO.CurrentRow.Cells["sueldo"].Value);
            string cargo = DGVEMPLEADO.CurrentRow.Cells["cargo"].Value?.ToString();
            DateTime fecha = Convert.ToDateTime(DGVEMPLEADO.CurrentRow.Cells["fechae"].Value);


            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
                {
                    datos.eliminarempleado(id, TXTNOMBREE.Text, TXTAPELLIDOE.Text, TXTDNIE.Text, TXTCONTRAE.Text,telefono,sueldo, cmbcargo.Text, DTPFECHAE.Value);

                    datos.mostrarempleados(DGVEMPLEADO);
                }
                else
                {
                    MessageBox.Show("ERROR, LOS DATOS SON INVALIDOS.");
                }
            }
            else
            {
                MessageBox.Show("DATOS NO ELIMINADOS.");
            }
        }

        private void DGVEMPLEADO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBREE.Text = DGVEMPLEADO.CurrentRow.Cells[1].Value.ToString();
            TXTAPELLIDOE.Text = DGVEMPLEADO.CurrentRow.Cells[2].Value.ToString();
            TXTDNIE.Text = DGVEMPLEADO.CurrentRow.Cells[3].Value.ToString();
            TXTCONTRAE.Text = DGVEMPLEADO.CurrentRow.Cells[4].Value.ToString();
            TXTTELEFONOE.Text = DGVEMPLEADO.CurrentRow.Cells[5].Value.ToString();
            TXTSUELDOE.Text = DGVEMPLEADO.CurrentRow.Cells[6].Value.ToString();
            cmbcargo.Text = DGVEMPLEADO.CurrentRow.Cells[7].Value.ToString();
            DTPFECHAE.Text = DGVEMPLEADO.CurrentRow.Cells[8].Value.ToString();
        }

        private void BTNACTUALIZARE_Click(object sender, EventArgs e)
        {
            int id, telefono;
            string nombre, apellido, dni, contraseña, cargo;
             float sueldo;
            DateTime fecha;


            id = Convert.ToInt32(TXTIDEMPLEADO.Text);  
            nombre = TXTNOMBREE.Text;
            apellido = TXTAPELLIDOE.Text;
            dni = TXTDNIE.Text;
            contraseña = TXTCONTRAE.Text;
            telefono = Convert.ToInt32(TXTTELEFONOE.Text); 
            sueldo = Convert.ToSingle(TXTSUELDOE.Text);  
            cargo = cmbcargo.Text;
            fecha = DTPFECHAE.Value;

            datos.actualizarempleado(id, nombre, apellido, dni, contraseña, telefono, sueldo, cargo, fecha);
            datos.mostrarempleados(DGVEMPLEADO);
        }

        private void GBEMP_Enter(object sender, EventArgs e)
        {

        }
    }
}
