using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FERRETERIAPROYECTO
{
    public partial class CLIENTE : Form
    {
        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idempleado = 1;
        public CLIENTE()
        {
            InitializeComponent();
        }

        private void CLIENTE_Load(object sender, EventArgs e)
        {
            datos.mostrarclientes(DGVCLIENTE);
            TXTIDCLIENTE.Text = idempleado.ToString();
            TXTSALDOPC.Text = "0.00";

        }

        private void BTNAGREGARC_Click(object sender, EventArgs e)
        {
            idempleado++;
            TXTIDCLIENTE.Text = idempleado.ToString();

            string nombre = TXTNOMBREC.Text;
            string apellido = TXTAPELLIDOC.Text;
            string dni = TXTDNIC.Text;
            int telefono = int.Parse(TXTTELEFONOC.Text);
            string estado = TXTESTADOC.Text;
            string direccion = TXTDIRECCIONC.Text;
            decimal saldo = decimal.TryParse(TXTSALDOPC.Text, out decimal result) ? result : 0.00m;


            DateTime fecha = DTPFECHAC.Value;
            datos.agregarcliente(nombre, apellido, dni, telefono, estado, direccion,saldo, fecha);
            datos.mostrarclientes(DGVCLIENTE);


        }

        private void BTNELIMINARC_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();


            int id = Convert.ToInt32(DGVCLIENTE.CurrentRow.Cells["idcliente"].Value);
            string nombre = DGVCLIENTE.CurrentRow.Cells["nombrec"].Value?.ToString();
            string apellido = DGVCLIENTE.CurrentRow.Cells["apellidoc"].Value?.ToString();
            string dni = DGVCLIENTE.CurrentRow.Cells["dnic"].Value?.ToString();
            int telefono = Convert.ToInt32((DGVCLIENTE.CurrentRow.Cells["telefonoc"].Value));
            string estado = DGVCLIENTE.CurrentRow.Cells["estado"].Value?.ToString();
            string direccion = DGVCLIENTE.CurrentRow.Cells["direccion"].Value?.ToString();
            decimal saldo = Convert.ToDecimal(DGVCLIENTE.CurrentRow.Cells["saldopendiente"].Value);
            DateTime fecha = Convert.ToDateTime(DGVCLIENTE.CurrentRow.Cells["fechac"].Value);

            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
                {
                    datos.eliminarclientes(id, TXTNOMBREC.Text, TXTAPELLIDOC.Text, TXTDNIC.Text, telefono, TXTESTADOC.Text,TXTDIRECCIONC.Text, saldo, DTPFECHAC.Value);

                    datos.mostrarclientes(DGVCLIENTE);
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

        private void DGVCLIENTE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBREC.Text = DGVCLIENTE.CurrentRow.Cells[1].Value.ToString();
            TXTAPELLIDOC.Text = DGVCLIENTE.CurrentRow.Cells[2].Value.ToString();
            TXTDNIC.Text = DGVCLIENTE.CurrentRow.Cells[3].Value.ToString();
            TXTTELEFONOC.Text = DGVCLIENTE.CurrentRow.Cells[4].Value.ToString();
            TXTESTADOC.Text = DGVCLIENTE.CurrentRow.Cells[5].Value.ToString();
            TXTDIRECCIONC.Text = DGVCLIENTE.CurrentRow.Cells[6].Value.ToString();
            TXTSALDOPC.Text = DGVCLIENTE.CurrentRow.Cells[7].Value.ToString();
            DTPFECHAC.Text = DGVCLIENTE.CurrentRow.Cells[8].Value.ToString();
        }

        private void BTNACTUALIZARC_Click(object sender, EventArgs e)
        {
            int id, telefono;
            string nombre, apellido, dni, estado, direccion;
            decimal saldo;
             DateTime fecha;

            id = Convert.ToInt32(TXTIDCLIENTE.Text);
            nombre = TXTNOMBREC.Text;
            apellido = TXTAPELLIDOC.Text;
            dni = TXTDNIC.Text;
            telefono = Convert.ToInt32(TXTTELEFONOC.Text);
            estado = TXTESTADOC.Text;
            direccion = TXTDIRECCIONC.Text;
            saldo = decimal.Parse(TXTSALDOPC.Text);
            fecha = DTPFECHAC.Value;

            datos.actualizarcliente(id, nombre, apellido, dni,telefono,estado,direccion,saldo, fecha);
            datos.mostrarclientes(DGVCLIENTE);
        }
    }
}
