using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERRETERIAPROYECTO
{
    public partial class VER_TABLAS: Form
    {
        QUERY datos = new QUERY();
        CONEXIONBD cxn = new CONEXIONBD();
        QUERY query = new QUERY();
        QUERY cn = new QUERY();
        public string TipoUsuario { get; set; }
        public VER_TABLAS()
        {
            InitializeComponent();
        }

        private void VER_PRO_Click(object sender, EventArgs e)
        {
           
        }

        private void VER_TABLAS_Load(object sender, EventArgs e)
        {
            datos.mostrarproducto(DGVVERLPRODUCTO);
            datos.mostrarclientes(DGVVERCLEIENTE);

           
        }
        public void SeleccionarPestana(string nombrePestana)
        {
            foreach (TabPage tab in VER.TabPages)
            {
                if (tab.Name == nombrePestana)
                {
                    VER.SelectedTab = tab;
                    break;
                }
            }
        }

        private void VER_EMPLEADO_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }

        private void DGVVERLPRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGVVERLPRODUCTO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el valor de la cantidad del producto en la fila seleccionada
                int stock = Convert.ToInt32(DGVVERLPRODUCTO.Rows[e.RowIndex].Cells["stock"].Value);

                // Verificar si la cantidad es menor o igual a 2
                if (stock <= 2)
                {
                    // Mostrar el mensaje
                    MessageBox.Show("Este producto tiene poca cantidad, es necesario comprar más.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void BTNHACERPEDIDO_Click(object sender, EventArgs e)
        {
            PRODUCTO frm = new PRODUCTO();
            frm.Show();
            this.Close();
        }
    }
}
