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
    public partial class VER_PROVEEDORES: Form
    {
        QUERY datos = new QUERY();
        public VER_PROVEEDORES()
        {
            InitializeComponent();
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }

        private void VER_PROVEEDORES_Load(object sender, EventArgs e)
        {
            datos.mostrarproveedor(DGVVERPROVEEDOR);
        }
    }
}
