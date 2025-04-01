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

        private void GBPRODUCTO_Enter(object sender, EventArgs e)
        {

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

        private void PLANILLA_Load(object sender, EventArgs e)
        {
            cargarempleado();
            TXTIDPLANILLA.Text = idplanilla.ToString();
            datos.mostrarplanilla(DGVPLANILLA);
        }

        private void BTNAGREGARPLANI_Click(object sender, EventArgs e)
        {
            idplanilla++;
            TXTIDPLANILLA.Text = idplanilla.ToString();

            int fkidempleado = Convert.ToInt32(CMBEMPLEADOSPLANI.SelectedValue); 
            DateTime fechainicio = DTPFECHAINICIO.Value;
            DateTime fechafin = DTPFECHAFIN.Value;
            float montopago = Convert.ToSingle(TXTMONTOPLANI.Text);

            datos.registrarplanilla(fkidempleado,fechainicio,fechafin,montopago);
            datos.mostrarplanilla(DGVPLANILLA);
        }
    }
}
