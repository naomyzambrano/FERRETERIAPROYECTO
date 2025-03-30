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
            idempleado++;
            TXTIDEMPLEADO.Text = idempleado.ToString();

            string nombre = TXTNOMBREE.Text;
            string apellido = TXTAPELLIDOE.Text;
            string dni = TXTDNIE.Text;
            //int dni = int.Parse(TXTDNIE.Text);  //CAMBIAR A STRING 
            string contraseña = TXTCONTRAE.Text;
            int telefono = int.Parse(TXTTELEFONOE.Text);
            float sueldo = float.Parse(TXTSUELDOE.Text);
            string cargo = TXTCARGOE.Text;

            DateTime fecha = DTPFECHAE.Value;
            datos.agregarempleado(nombre,apellido,dni,contraseña,telefono,sueldo,cargo,fecha);
            datos.mostrarempleados(DGVEMPLEADO);
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
                    datos.eliminarempleado(id, TXTNOMBREE.Text, TXTAPELLIDOE.Text, TXTDNIE.Text, TXTCONTRAE.Text,telefono,sueldo,TXTCARGOE.Text, DTPFECHAE.Value);

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
            TXTCARGOE.Text = DGVEMPLEADO.CurrentRow.Cells[7].Value.ToString();
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
            cargo = TXTCARGOE.Text;
            fecha = DTPFECHAE.Value;

            datos.actualizarempleado(id, nombre, apellido, dni, contraseña, telefono, sueldo, cargo, fecha);
            datos.mostrarempleados(DGVEMPLEADO);
        }
    }
}
