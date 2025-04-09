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
    public partial class ORDENCOMPRA : Form
    {

        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idcompra = 1;
        public ORDENCOMPRA()
        {
            InitializeComponent();
        }

        private void cargarproducto()//funciones 
        {
            DataTable dt = query.obtenerproducto();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrep"] = "SELECCIONE EL PRODUCTO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBPRODUCTOOCOMPRA.DataSource = dt;
            CMBPRODUCTOOCOMPRA.DisplayMember = "nombrep";
            CMBPRODUCTOOCOMPRA.ValueMember = "idproducto";
            CMBPRODUCTOOCOMPRA.SelectedIndex = 0;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ORDENCOMPRA_Load(object sender, EventArgs e)
        {
            cargarproducto();
            TXTIDOCOMPRA.Text = idcompra.ToString();
            datos.mostrarcompra(DGVOCOMPRA);

        }

        private void BTNAGREGAROCOMPRA_Click(object sender, EventArgs e)
        {
            idcompra++;
            TXTIDOCOMPRA.Text = idcompra.ToString();

            int fkidproducto = Convert.ToInt32(CMBPRODUCTOOCOMPRA.SelectedValue);
            int cantidad = Convert.ToInt32(NUPCANTIDADCOMPRA.Value);
            string estado = CMBESTADOCOMPRA.Text;
            DateTime fecha = DTPFECHACOMPRA.Value;

            datos.agregarcompra(fkidproducto, cantidad,fecha,estado);
            datos.mostrarcompra(DGVOCOMPRA);
            
        }

        private void BTNELIMINAROCOMPRA_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();


            int id = Convert.ToInt32(DGVOCOMPRA.CurrentRow.Cells["idcompra"].Value);
            int fkidproducto = Convert.ToInt32(DGVOCOMPRA.CurrentRow.Cells["fkidproducto"].Value);
            int cantidad = Convert.ToInt32((DGVOCOMPRA.CurrentRow.Cells["cantidadsolicitada"].Value));
            DateTime fecha = Convert.ToDateTime(DGVOCOMPRA.CurrentRow.Cells["fecha"].Value);
            string estado = DGVOCOMPRA.CurrentRow.Cells["estado"].Value?.ToString();

            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(estado))
                {
                    datos.eliminarorden(id,fkidproducto,cantidad,fecha,estado);

                    datos.mostrarcompra(DGVOCOMPRA);
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

        private void BTNACTUALIZAROCOMPRA_Click(object sender, EventArgs e)
        {
            int id, fkidproducto,cantidad;
            string estado;
            DateTime fecha;


            id = Convert.ToInt32(TXTIDOCOMPRA.Text);
            fkidproducto= Convert.ToInt32(CMBPRODUCTOOCOMPRA.SelectedValue);
            cantidad = Convert.ToInt32(NUPCANTIDADCOMPRA.Value);
            estado = CMBESTADOCOMPRA.Text;
            fecha = DTPFECHACOMPRA.Value;

            datos.actualizarcompra(id,fkidproducto,cantidad,fecha,estado);
            datos.mostrarcompra(DGVOCOMPRA);
        }


        private void DGVOCOMPRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGVOCOMPRA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CMBPRODUCTOOCOMPRA.Text = DGVOCOMPRA.CurrentRow.Cells[1].Value.ToString();
            NUPCANTIDADCOMPRA.Text = DGVOCOMPRA.CurrentRow.Cells[2].Value.ToString();
            CMBESTADOCOMPRA.Text = DGVOCOMPRA.CurrentRow.Cells[4].Value.ToString();
            DTPFECHACOMPRA.Text = DGVOCOMPRA.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }
    }
}
