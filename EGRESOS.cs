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
    public partial class EGRESOS : Form
    {

        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        int idegreso = 1;
        public EGRESOS()
        {
            InitializeComponent();
        }

        private void EGRESOS_Load(object sender, EventArgs e)
        {
            cargaregreso();
            datos.mostraregreso(DGVGASTO);
            TXTIDEGRESOS.Text = idegreso.ToString();
        }

        private void cargaregreso()//funciones 
        {
            DataTable dt = query.obtenertipogasto();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombre"] = "SELECCIONE EL TIPO DE GASTO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBTIPOGASTO.DataSource = dt;
            CMBTIPOGASTO.DisplayMember = "nombre";
            CMBTIPOGASTO.ValueMember = "idtipogasto";
            CMBTIPOGASTO.SelectedIndex = 0;
        }

        private void BTNAGREGARGASTO_Click(object sender, EventArgs e)
        {
            idegreso++;
            TXTIDEGRESOS.Text = idegreso.ToString();

            string descripcion = TXTDESCRIPCIONGASTO.Text;
            int monto = int.Parse(TXTMONTOGASTO.Text);
            int fkidtipogasto = Convert.ToInt32(CMBTIPOGASTO.SelectedValue);

            DateTime fecha = DTPGASTOS.Value;
            datos.agregaregreso(descripcion, monto, fecha, fkidtipogasto);
            datos.mostraregreso(DGVGASTO);
        }

        private void BTNELIMINARGASTO_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();

            int id = Convert.ToInt32((DGVGASTO.CurrentRow.Cells["idegreso"].Value));
            string descripcion = DGVGASTO.CurrentRow.Cells["descripcion"].Value?.ToString();
            int monto = Convert.ToInt32((DGVGASTO.CurrentRow.Cells["monto"].Value));
            DateTime fecha = Convert.ToDateTime(DGVGASTO.CurrentRow.Cells["fecha"].Value);
            int fkidtipogasto = Convert.ToInt32((DGVGASTO.CurrentRow.Cells["fkidtipogasto"].Value));

            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(descripcion))
                {
                    datos.eliminaregreso(id, descripcion, monto, fecha, fkidtipogasto);

                    datos.mostraregreso(DGVGASTO);
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

        private void DGVGASTO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTDESCRIPCIONGASTO.Text = DGVGASTO.CurrentRow.Cells[1].Value.ToString();
            TXTMONTOGASTO.Text = DGVGASTO.CurrentRow.Cells[2].Value.ToString();
            DTPGASTOS.Text = DGVGASTO.CurrentRow.Cells[3].Value.ToString();
            CMBTIPOGASTO.Text = DGVGASTO.CurrentRow.Cells[4].Value.ToString();
        }

        private void BTNACTUALIZARGASTO_Click(object sender, EventArgs e)
        {
            int id, monto, fkidtipogasto = 0;
            string descripcion;
            DateTime fecha;

            id = Convert.ToInt32(TXTIDEGRESOS.Text);
            descripcion = TXTDESCRIPCIONGASTO.Text;
            monto = Convert.ToInt32(TXTMONTOGASTO.Text);
            fkidtipogasto = Convert.ToInt32(CMBTIPOGASTO.SelectedValue);
            fecha = DTPGASTOS.Value;

            datos.actualizaregreso(id, descripcion, monto, fecha, fkidtipogasto);
            datos.mostraregreso(DGVGASTO);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
