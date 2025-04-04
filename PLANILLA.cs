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
    public partial class PLANILLA : Form
    {

        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idplanilla = 1;
        public PLANILLA()
        {
            InitializeComponent();
        }

        private void PLANILLA_Load(object sender, EventArgs e)
        {
            cargarempleado();
            TXTIDPLANILLA.Text = idplanilla.ToString();
            datos.mostrarplanilla(DGVPLANILLA);

        }

        private void cargarempleado()//funciones 
        {
            DataTable dt = query.obteneridempleado();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrecompletoe"] = "SELECCIONE EL EMPLEADO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBEMPLEADOSPLANI.DataSource = dt;
            CMBEMPLEADOSPLANI.DisplayMember = "nombrecompletoe";
            CMBEMPLEADOSPLANI.ValueMember = "idempleado";
            CMBEMPLEADOSPLANI.SelectedIndex = 0;

        }

        private void BTNAGREGARPLANI_Click(object sender, EventArgs e)
        {
            idplanilla++;
            TXTIDPLANILLA.Text = idplanilla.ToString();

            int fkidempleado = Convert.ToInt32(CMBEMPLEADOSPLANI.SelectedValue);
            DateTime fechainicio = DTPFECHAINICIO.Value;
            DateTime fechafin = DTPFECHAFIN.Value;
            float montopago = Convert.ToSingle(TXTMONTOPLANI.Text);

            datos.registrarplanilla(fkidempleado, fechainicio, fechafin, montopago);
            datos.mostrarplanilla(DGVPLANILLA);
        }

        private void BTNELIMINARPLANI_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();


            int id = Convert.ToInt32(DGVPLANILLA.CurrentRow.Cells["idplanilla"].Value);
            int fkidempleado = Convert.ToInt32((DGVPLANILLA.CurrentRow.Cells["fkidempleado"].Value));
            DateTime fechainicio = Convert.ToDateTime(DGVPLANILLA.CurrentRow.Cells["fechainicio"].Value);
            DateTime fechafin = Convert.ToDateTime(DGVPLANILLA.CurrentRow.Cells["fechafin"].Value);
            float montopago = Convert.ToSingle(DGVPLANILLA.CurrentRow.Cells["montopago"].Value);

            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (id != 0)
                {
                    datos.eliminarplanilla(id, fkidempleado, fechainicio, fechafin, montopago);

                    datos.mostrarplanilla(DGVPLANILLA);
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

        private void DGVPLANILLA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTIDPLANILLA.Text =DGVPLANILLA.CurrentRow.Cells[0].Value.ToString();
            CMBEMPLEADOSPLANI.Text = DGVPLANILLA.CurrentRow.Cells[1].Value.ToString();
            DTPFECHAINICIO.Text = DGVPLANILLA.CurrentRow.Cells[2].Value.ToString();
            DTPFECHAFIN.Text = DGVPLANILLA.CurrentRow.Cells[3].Value.ToString();
            TXTMONTOPLANI.Text = DGVPLANILLA.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void BTNACTUALIZARPLANI_Click(object sender, EventArgs e)
        {
           
            int id, fkidempleado;
            DateTime fechainicio, fechafin;
            float montopago;


            id = Convert.ToInt32(TXTIDPLANILLA.Text);
            fkidempleado = Convert.ToInt32(CMBEMPLEADOSPLANI.SelectedValue);
            fechainicio = DTPFECHAINICIO.Value;
            fechafin = DTPFECHAFIN.Value;
            
            montopago = Convert.ToSingle(TXTMONTOPLANI.Text);

            datos.actualizarplanilla(id, fkidempleado, fechainicio, fechafin, montopago);
            datos.mostrarplanilla(DGVPLANILLA);
        }

        private void DGVPLANILLA_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGVPLANILLA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void CMBEMPLEADOSPLANI_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CMBEMPLEADOSPLANI.SelectedIndex != -1)  // Asegúrate de que haya un empleado seleccionado
            {
                // Obtener la fila correspondiente al empealdo seleccionado
                DataRowView rowView = CMBEMPLEADOSPLANI.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    if (rowView["sueldo"] != DBNull.Value)
                    {
                        // Obtener el sueldo  como float
                        float sueldo = Convert.ToSingle(rowView["sueldo"]);

                        sueldo = sueldo / 2;
                        // Mostrar el sueldo en el TextBox con 2 decimales
                        TXTMONTOPLANI.Text =sueldo.ToString("F2");  // Muestra el sueldo con 2 decimales
                    }
                    else
                    {
                        // Si el sueldo es nulo, mostrar 0 o algún otro valor predeterminado
                       TXTMONTOPLANI.Text = "$0.00";
                    }
                }
            }
            else
            {
                // Limpiar el TextBox si no hay selección válida
                TXTMONTOPLANI.Clear();
            }


        }
    }
}
