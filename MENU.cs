using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERRETERIAPROYECTO
{
    public partial class MENU: Form
    {

        public string TipoUsuario { get; set; }
        public MENU()
        {
            InitializeComponent();
            

        }

        private void MENU_Load(object sender, EventArgs e)
        {
            if (TipoUsuario == "ADMINISTRADOR")
            {
                mcontabilidad.Visible = true;
                megresos.Visible = true;
                mempleados.Visible = true;
                mentradaproducto.Visible = true;
                menucliente.Visible = true;
                menuvercliente.Visible = true;
                minventario.Visible = true;
                mingreso.Visible = true;
                menuproducto.Visible = true;
                mplanilla.Visible = true;
                mreporte.Visible = true;
                msalidaproducto.Visible = true;
                mverproducto.Visible = true;
                mcrearventanad.Visible = true;
                MPROVEEDOR.Visible = true;
                mverempleado.Visible = true;

                // Se pueden agregar más configuraciones para el tipo de usuario "Cobrador" si es necesario
            }
            else if (TipoUsuario == "CAJERO")
            {
                mcontabilidad.Visible = false;
                megresos.Visible = false;
                mempleados.Visible = false;
                mentradaproducto.Visible = false;
                menucliente.Visible = true;
                menuvercliente.Visible = true;
                minventario.Visible = false;
                mingreso.Visible = false;
                menuproducto.Visible = false;
                mplanilla.Visible = false;
                mreporte.Visible = false;
                msalidaproducto.Visible = false;
                mverproducto.Visible = true;
                mcrearventanad.Visible = true;
                MPROVEEDOR.Visible = false;
                mverempleado.Visible = false;
            }
            else if (TipoUsuario == "ENCARGADO DE ALMACÉN")
            {
                mcontabilidad.Visible = false;
                megresos.Visible = false;
                mempleados.Visible = false;
                mentradaproducto.Visible = true;
                menucliente.Visible = true;
                menuvercliente.Visible = true;
                minventario.Visible = true;
                mingreso.Visible = false;
                menuproducto.Visible = true;
                mplanilla.Visible = false;
                mreporte.Visible = false;
                msalidaproducto.Visible = true;
                mverproducto.Visible = true;
                mcrearventanad.Visible = false;
                MPROVEEDOR.Visible = true;
                mverempleado.Visible = false;
            }

        }

        private void vERCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VER_TABLAS frm = new VER_TABLAS();
            frm.SeleccionarPestana("VER_CLIENTE"); // <- este es el nombre exacto de la pestaña
            frm.Show();
        }

        private void cREARVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VENTAS frm = new VENTAS();
            frm.Show();
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

      

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {         
        }

        private void minventario_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void MPROVEEDOR_Click(object sender, EventArgs e)
        {
            PROVEEDORES frm = new PROVEEDORES();
            frm.Show();

        }

        private void menuproducto_Click(object sender, EventArgs e)
        {            
        }

        private void mvenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aGREGARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENTE frm = new CLIENTE();
            frm.Show();
        }

        private void aGREGARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODUCTO frm = new PRODUCTO();
            frm.Show();
        }

        private void mverproducto_Click(object sender, EventArgs e)
        {
            VER_TABLAS frm = new VER_TABLAS();
            frm.SeleccionarPestana("VER_PRODUCTO"); // <- este es el nombre exacto de la pestaña
            frm.Show();

        }

        private void aGREGAREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EMPLEADO frm = new EMPLEADO();
            frm.Show();
        }

        private void mverempleado_Click(object sender, EventArgs e)
        {
            VER_TABLAS frm = new VER_TABLAS();
            frm.SeleccionarPestana("VER_EMPLEADO"); // <- este es el nombre exacto de la pestaña
            frm.Show();

        }
    }
}
