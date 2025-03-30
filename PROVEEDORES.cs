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
    public partial class PROVEEDORES : Form
    {
        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idprov = 1;

        public PROVEEDORES()
        {
            InitializeComponent();
        }

        private void GBCLIENTE_Enter(object sender, EventArgs e)
        {

        }

        private void BTNAGREGARPROVE_Click(object sender, EventArgs e)
        {
           

            idprov++;
            TXTIDPROVEEDOR.Text = idprov.ToString();

            string nombre = TXTNOMBREPROVE.Text;
            int telefono = int.Parse(TXTTELEFONOPROVE.Text);

            datos.insertarprovedor(nombre,telefono);
            datos.mostrarproveedor(DGVPROVEEDORES);
        }

        private void PROVEEDORES_Load(object sender, EventArgs e)
        {
            datos.mostrarproveedor(DGVPROVEEDORES);
            TXTIDPROVEEDOR.Text = idprov.ToString();
        }

        private void BTNELIMINARPROVE_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();


            int id = Convert.ToInt32(DGVPROVEEDORES.CurrentRow.Cells["idproveedor"].Value);
            string nombre = DGVPROVEEDORES.CurrentRow.Cells["nombreprov"].Value?.ToString();
            int telefono = Convert.ToInt32(DGVPROVEEDORES.CurrentRow.Cells["telefonoprov"].Value);

            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(nombre))
                {
                    datos.eliminarproveedor(id,nombre, telefono);

                    datos.mostrarproveedor(DGVPROVEEDORES);
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

        private void DGVPROVEEDORES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBREPROVE.Text = DGVPROVEEDORES.CurrentRow.Cells[1].Value.ToString();
            TXTTELEFONOPROVE.Text = DGVPROVEEDORES.CurrentRow.Cells[2].Value.ToString();
        }

        private void BTNACTUALIZARE_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNACTUALIZARPROVE_Click(object sender, EventArgs e)
        {
            int id, telefono;
            string nombre;


            id = Convert.ToInt32(TXTIDPROVEEDOR.Text);
            nombre = TXTNOMBREPROVE.Text;
            telefono = Convert.ToInt32(TXTTELEFONOPROVE.Text);

            datos.actualizarproveedor(id, nombre, telefono);
            datos.mostrarproveedor(DGVPROVEEDORES);
        }
    }
}
