using System;
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
            datos.mostrarproveedor(DGVVERLPRODUCTO);
            if (TipoUsuario == "CAJERO")
            {
                VER.TabPages.Remove(VER_EMPLEADO); // No puede ver empleados


            }
            else if (TipoUsuario == "ENCARGADO DE ALMACÉN")
            {
                VER.TabPages.Remove(VER_EMPLEADO); // No puede ver empleados
                
            }
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
    }
}
