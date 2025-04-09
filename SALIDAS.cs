using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERRETERIAPROYECTO
{
    public partial class SALIDAS : Form
    {


        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idsalida = 1;
        public SALIDAS()
        {
            InitializeComponent();
        }

        private void SALIDAS_Load(object sender, EventArgs e)
        {
            cargarclientes();
            cargarproducto();
            cargarempleado();
            datos.mostrarsalidas(DGVSALIDAS);
            TXTIDSALIDA.Text = idsalida.ToString();
        }

        private void cargarclientes()//funciones 
        {
            DataTable dt = query.obteneridclientes();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrecompleto"] = "SELECCIONE EL CLIENTE";
            dt.Rows.InsertAt(nuevaFila, 0);

           CMBCLIENTESAL.DataSource = dt;
           CMBCLIENTESAL.DisplayMember = "nombrecompleto";
           CMBCLIENTESAL.ValueMember = "idcliente";
           CMBCLIENTESAL.SelectedIndex = 0;

            //CMBIDCLIENTEV.AutoCompleteMode = AutoCompleteMode.Suggest;
            //CMBIDCLIENTEV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //CMBIDCLIENTEV.AutoCompleteCustomSource = new AutoCompleteStringCollection();
        }

        private void cargarproducto()//funciones 
        {
            DataTable dt = query.obtenerproducto();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrep"] = "SELECCIONE EL PRODUCTO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBPRODUCTOSAL.DataSource = dt;
            CMBPRODUCTOSAL.DisplayMember = "nombrep";
            CMBPRODUCTOSAL.ValueMember = "idproducto";
            CMBPRODUCTOSAL.SelectedIndex = 0;


        }

        private void cargarempleado()//funciones 
        {
            DataTable dt = query.obteneridempleado();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrecompletoe"] = "SELECCIONE EL EMPLEADO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBEMPLEADOSAL.DataSource = dt;
            CMBEMPLEADOSAL.DisplayMember = "nombrecompletoe";
            CMBEMPLEADOSAL.ValueMember = "idempleado";
            CMBEMPLEADOSAL.SelectedIndex = 0;

        }

        private void BTNAGREGARSAL_Click(object sender, EventArgs e)
        {
            idsalida++;
            TXTIDSALIDA.Text = idsalida.ToString();

            int fkidempleado = Convert.ToInt32(CMBEMPLEADOSAL.SelectedValue);
            int fkidcliente = Convert.ToInt32(CMBCLIENTESAL.SelectedValue);
            int fkidproducto = Convert.ToInt32(CMBPRODUCTOSAL.SelectedValue);
            DateTime fechasalida = DTPFECHASAL.Value;
            string observacion = TXTOBSERVACION.Text;
            int cantidad = int.Parse(NUPCANTIDADSALI.Text);

            datos.agregarsalidas(fkidempleado,fkidcliente,fkidproducto,fechasalida,observacion,cantidad);
            datos.mostrarsalidas(DGVSALIDAS);

        }

        private void BTNELIMINARSAL_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();


            int id = Convert.ToInt32(DGVSALIDAS.CurrentRow.Cells["idsalidas"].Value);
            int fkidempleado = Convert.ToInt32((DGVSALIDAS.CurrentRow.Cells["fkidempleado"].Value));
            int fkidcliente = Convert.ToInt32((DGVSALIDAS.CurrentRow.Cells["fkidcliente"].Value));
            int fkidproducto = Convert.ToInt32((DGVSALIDAS.CurrentRow.Cells["fkidproducto"].Value));
            DateTime fechasalida = Convert.ToDateTime(DGVSALIDAS.CurrentRow.Cells["fechasalida"].Value);
            string observacion = DGVSALIDAS.CurrentRow.Cells["observacion"].Value?.ToString();
            int cantidad = Convert.ToInt32(DGVSALIDAS.CurrentRow.Cells["cantidad"].Value);

            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(observacion) )
                {
                    datos.eliminarsalidas(id,fkidempleado,fkidcliente,fkidproducto,fechasalida,observacion,cantidad);

                    datos.mostrarsalidas(DGVSALIDAS);
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

        private void BTNACTUALIZARSAL_Click(object sender, EventArgs e)
        {
            int id, fkidempleado,fkidcliente,fkidproducto, cantidad;
            string observacion;
            DateTime fechasalida;


            id = Convert.ToInt32(TXTIDSALIDA.Text);
            fkidempleado = Convert.ToInt32(CMBEMPLEADOSAL.SelectedValue);
            fkidcliente = Convert.ToInt32(CMBCLIENTESAL.SelectedValue);
            fkidproducto = Convert.ToInt32(CMBPRODUCTOSAL.SelectedValue);
            observacion = TXTOBSERVACION.Text;
            fechasalida = DTPFECHASAL.Value;
            cantidad = Convert.ToInt32(NUPCANTIDADSALI.Text);

            datos.actualizarsalidas(id,fkidempleado,fkidcliente,fkidproducto,fechasalida,observacion,cantidad);
            datos.mostrarsalidas(DGVSALIDAS);

        }

        private void DGVSALIDAS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CMBEMPLEADOSAL.Text = DGVSALIDAS.CurrentRow.Cells[1].Value.ToString();
            CMBCLIENTESAL.Text = DGVSALIDAS.CurrentRow.Cells[2].Value.ToString();
            CMBPRODUCTOSAL.Text = DGVSALIDAS.CurrentRow.Cells[3].Value.ToString();
            DTPFECHASAL.Text = DGVSALIDAS.CurrentRow.Cells[4].Value.ToString();
            TXTOBSERVACION.Text = DGVSALIDAS.CurrentRow.Cells[5].Value.ToString();
            NUPCANTIDADSALI.Text = DGVSALIDAS.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }
    }
}
