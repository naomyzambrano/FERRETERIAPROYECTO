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
    public partial class VENTAS : Form
    {

        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idventa = 1;
        public VENTAS()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void VENTAS_Load(object sender, EventArgs e)
        {

            idventa++;
            TXTIDVENTA.Text = idventa.ToString();
            TXTCREDITOVENTA.Text = " ESCRIBA (SI)1 Ó (NO)0 ";
        }

        private void TXTCREDITOVENTA_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVVENTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXTSUBTOTALV_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNAGREGARVENTA_Click(object sender, EventArgs e)
        {

        }
    }
}
