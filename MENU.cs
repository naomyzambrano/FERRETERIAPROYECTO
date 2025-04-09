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
            this.Close();
        }

        private void cREARVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CREAR_VENTA frm = new CREAR_VENTA();
            frm.Show();
            this.Close();
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
            this.Close();
        }

        private void aGREGARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODUCTO frm = new PRODUCTO();
            frm.Show();
            this.Close();
        }

        private void mverproducto_Click(object sender, EventArgs e)
        {
            VER_TABLAS frm = new VER_TABLAS();
            frm.SeleccionarPestana("VER_PRODUCTO"); // <- este es el nombre exacto de la pestaña
            frm.Show();
            this.Close();

        }

        private void aGREGAREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EMPLEADO frm = new EMPLEADO();
            frm.Show();
            this.Close();
        }

        private void mverempleado_Click(object sender, EventArgs e)
        {
            VER_EMPLEADO frm = new VER_EMPLEADO(); 
            frm.Show();
            this.Close();

        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();

        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iNGRESARPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROVEEDORES frm = new PROVEEDORES();
            frm.Show();
            this.Close();
        }

        private void vERPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VER_PROVEEDORES frm = new VER_PROVEEDORES();
            frm.Show();
            this.Close();
        }

        private void mplanilla_Click(object sender, EventArgs e)
        {
            PLANILLA frm = new PLANILLA();
            frm.Show();
            this.Close();
        }

        private void msalidaproducto_Click(object sender, EventArgs e)
        {
            SALIDAS frm = new SALIDAS();
            frm.Show();
            this.Close();
        }

        private void mentradaproducto_Click(object sender, EventArgs e)
        {
            ORDENCOMPRA frm = new ORDENCOMPRA();
            frm.Show();
            this.Close();
        }

        private void megresos_Click(object sender, EventArgs e)
        {
            EGRESOS frm = new EGRESOS();
            frm.Show();
            this.Close();
        }

        private void eDITARINVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INVENTARIO frm = new INVENTARIO();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void vERVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VER_VENTA frm = new VER_VENTA();
            frm.Show();
            this.Close();
        }

        private void rEPORTEEGRESOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORTE_EGRESOS frm = new REPORTE_EGRESOS();
            frm.Show();
            this.Close();
        }
    }
}
