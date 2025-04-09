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
    public partial class PRODUCTO : Form
    {
        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        int idprod = 1;
        public PRODUCTO()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GBPRODUCTO_Enter(object sender, EventArgs e)
        {
            

        }
       

        private void PRODUCTO_Load(object sender, EventArgs e)
        {
            
            cargarcate();
            cargarproveedor();
            //datos.mostrarproducto(DGVPRODUCTO);
            TXTIDPRODUCTO.Text = idprod.ToString();
            DGVPRODUCTO.DataSource = datos.MostrarProductosConNombres();
        }

        private void CMBCATEGORIAPRODU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cargarcate()//funciones 
        {
            DataTable dt = query.obtenercategorias();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrecate"] = "SELECCIONE LA CATEGORIA";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBCATEGORIAPRODU.DataSource = dt;
            CMBCATEGORIAPRODU.DisplayMember = "nombrecate";
            CMBCATEGORIAPRODU.ValueMember = "idcategoria";
           CMBCATEGORIAPRODU.SelectedIndex = 0;
        }

        private void cargarproveedor()//funciones 
        {
            DataTable dt = query.obtenercprove();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombreprov"] = "SELECCIONE EL PROVEEDOR";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBPROVE.DataSource = dt;
            CMBPROVE.DisplayMember = "nombreprov";
            CMBPROVE.ValueMember = "idproveedor";
            CMBPROVE.SelectedIndex = 0;
        }

        private void BTNAGREGARPRODU_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXTNOMBREPRODU.Text) &&
                !string.IsNullOrEmpty(TXTSTOCK.Text) &&
                !string.IsNullOrEmpty(TXTDESCRIPCIONPRODU.Text) &&
                CMBCATEGORIAPRODU.SelectedItem != null &&
                CMBPROVE.SelectedItem != null &&
                !string.IsNullOrEmpty(TXTPRECIOCOMPRA.Text) &&
                !string.IsNullOrEmpty(TXTPRECIOVENTA.Text))
            {
                // Incrementar el idprod
                idprod++;
                TXTIDPRODUCTO.Text = idprod.ToString();

                // Obtener los valores de los controles
                string nombre = TXTNOMBREPRODU.Text;
                int stock = Convert.ToInt32(TXTSTOCK.Text);
                string descripcion = TXTDESCRIPCIONPRODU.Text;
                int fkidcategoria = Convert.ToInt32(CMBCATEGORIAPRODU.SelectedValue);
                int fkidproveedor = Convert.ToInt32(CMBPROVE.SelectedValue);
                float precioc = Convert.ToSingle(TXTPRECIOCOMPRA.Text);
                float preciov = Convert.ToSingle(TXTPRECIOVENTA.Text);

                // Agregar el producto
                datos.agregarproducto(nombre, stock, descripcion, fkidcategoria, fkidproveedor, precioc, preciov);
                datos.mostrarproducto(DGVPRODUCTO);

                // Limpiar los campos después de agregar
                TXTNOMBREPRODU.Clear();
                TXTSTOCK.Clear();
                TXTDESCRIPCIONPRODU.Clear();
                TXTPRECIOCOMPRA.Clear();
                TXTPRECIOVENTA.Clear();
                CMBCATEGORIAPRODU.SelectedIndex = -1;
                CMBPROVE.SelectedIndex = -1;
            }
            else
            {
                // Mostrar mensaje si hay campos vacíos
                MessageBox.Show("Por favor, complete todos los campos del producto.");
            }

        }

        private void BTNELIMINARPRODU_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();


            int id = Convert.ToInt32(DGVPRODUCTO.CurrentRow.Cells["idproducto"].Value);
            string nombre = DGVPRODUCTO.CurrentRow.Cells["nombrep"].Value?.ToString();
            int stock = Convert.ToInt32(DGVPRODUCTO.CurrentRow.Cells["stock"].Value);
            string descripcion = DGVPRODUCTO.CurrentRow.Cells["descripcion"].Value?.ToString();
            int fkidcategoria = Convert.ToInt32((DGVPRODUCTO.CurrentRow.Cells["fkidcategoria"].Value));
            int fkidproveedor = Convert.ToInt32((DGVPRODUCTO.CurrentRow.Cells["fkidproveedor"].Value));
            float precioc = Convert.ToSingle((DGVPRODUCTO.CurrentRow.Cells["precioc"].Value));
            float preciov = Convert.ToSingle((DGVPRODUCTO.CurrentRow.Cells["preciov"].Value));


            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(descripcion))
                {
                    datos.eliminarproducto(id, TXTNOMBREPRODU.Text, stock, TXTDESCRIPCIONPRODU.Text, fkidcategoria, fkidproveedor, precioc, preciov);

                    datos.mostrarproducto(DGVPRODUCTO);
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

        private void DGVPRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVPRODUCTO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBREPRODU.Text = DGVPRODUCTO.CurrentRow.Cells[1].Value.ToString();
            TXTSTOCK.Text = DGVPRODUCTO.CurrentRow.Cells[2].Value.ToString();
            TXTDESCRIPCIONPRODU.Text = DGVPRODUCTO.CurrentRow.Cells[3].Value.ToString();
            CMBCATEGORIAPRODU.Text = DGVPRODUCTO.CurrentRow.Cells[4].Value.ToString();
            CMBPROVE.Text = DGVPRODUCTO.CurrentRow.Cells[5].Value.ToString();
            TXTPRECIOCOMPRA.Text = DGVPRODUCTO.CurrentRow.Cells[6].Value.ToString();
            TXTPRECIOVENTA.Text = DGVPRODUCTO.CurrentRow.Cells[7].Value.ToString();

            //int fkidcategoria = Convert.ToInt32(DGVPRODUCTO.CurrentRow.Cells[4].Value);
            //int fkidproveedor = Convert.ToInt32(DGVPRODUCTO.CurrentRow.Cells[5].Value);

            

        }

        private void BTNACTUALIZARC_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNACTUALIZARPRODU_Click(object sender, EventArgs e)
        {
            int id, stock, fkidcategoria, fkidproveedor;
            string nombre, descripcion;
            float precioc, preciov;


            id = Convert.ToInt32(TXTIDPRODUCTO.Text);
            nombre = TXTNOMBREPRODU.Text;
            stock = Convert.ToInt32(TXTSTOCK.Text);
            descripcion = TXTDESCRIPCIONPRODU.Text;
            fkidcategoria = Convert.ToInt32(CMBCATEGORIAPRODU.SelectedValue);
            fkidproveedor = Convert.ToInt32(CMBPROVE.SelectedValue);
            //ARREGLAR QUE AL MOSTRAR APAREZCAN LAS CATEGORIAS Y PROVEEDORES NO LOS NUMEROS
            //fkidcategoria = Convert.ToInt32(CMBCATEGORIAPRODU.SelectedValue); 
            //fkidproveedor = Convert.ToInt32(CMBPROVE.SelectedValue);
            precioc = Convert.ToSingle(TXTPRECIOCOMPRA.Text);
            preciov = Convert.ToSingle(TXTPRECIOVENTA.Text);
            datos.actualizarproducto(id, nombre, stock, descripcion, fkidcategoria, fkidproveedor, precioc, preciov);
            datos.mostrarproducto(DGVPRODUCTO);


        }

        private void CMBPROVE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }
    }
}
