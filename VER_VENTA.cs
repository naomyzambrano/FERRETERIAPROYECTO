using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FERRETERIAPROYECTO.CREAR_VENTA;

namespace FERRETERIAPROYECTO
{
    public partial class VER_VENTA: Form
    {
        QUERY datos = new QUERY();
        CONEXIONBD cxn = new CONEXIONBD();
        QUERY query = new QUERY();
        QUERY cn = new QUERY();
        public string CodigoFactura { get; set; }
        public List<DetalleVenta> DetallesVenta
        {
            get; set;
        }
        public VER_VENTA()
        {
            InitializeComponent();
        }

        private void VER_VENTA_Load(object sender, EventArgs e)
        {
            DGVVENTA.DataSource = DetallesVenta;
            TXTFACTURA.Text = CodigoFactura;
            datos.mostrarventa(DGVVENTA);
            

            
        }

        private void DGVVENTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CLIENTE frm = new CLIENTE();
            frm.ShowDialog();
        }

        private void DGVVENTA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
