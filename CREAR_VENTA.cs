using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FERRETERIAPROYECTO
{
    public partial class CREAR_VENTA: Form
    {
        CONEXIONBD cxn = new CONEXIONBD();
        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        public string TipoUsuario { get; set; }

        List<DetalleVenta> listaProductos = new List<DetalleVenta>();


        public CREAR_VENTA()
        {
            
            InitializeComponent();
        }

        private void CREAR_VENTA_Load(object sender, EventArgs e)
        {
            cargarempleado();
            CargarClientes();
            CargarProductos();
            CargarMetodosPago();
           



        }


        //}

        private void CMBIDCLIENTEV_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (CMBIDCLIENTEV.SelectedItem != null)
            {
                DataRowView row = CMBIDCLIENTEV.SelectedItem as DataRowView;
                TXTNOMBRECLIENTE.Text = row["nombrec"].ToString();
                TXTAPELLIDOCLIENTE.Text = row["apellidoc"].ToString();
                TXTDIRECCIONCLIENTE.Text = row["direccion"].ToString();
                TXTTELEFONOCLIENTE.Text = row["telefonoc"].ToString();
            }*/
            

        }

        private void CMBIDCLIENTEV_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void TXTTELEFONOCLIENTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMBIDCLIENTEV_Click(object sender, EventArgs e)
        {
        }

        private void BTNAGREGARVENTA_Click(object sender, EventArgs e)
        {


            /*if (CMBIDPRODUCTOVENTA.SelectedValue != null && !string.IsNullOrEmpty(TXTCANTIDADDV.Text))
            {
                // Crear un nuevo detalle de venta
                DetalleVenta det = new DetalleVenta();
                det.ProductoID = Convert.ToInt32(CMBIDPRODUCTOVENTA.SelectedValue);
                det.NombreProducto = CMBIDPRODUCTOVENTA.Text; // Nombre del producto 
                det.Cantidad = Convert.ToInt32(TXTCANTIDADDV.Text);
                det.PrecioUnitario = Convert.ToSingle(TXTPRECIOUDV.Text);

                // Agregar el detalle a la lista de productos
                listaProductos.Add(det);

                // Actualizar el DataGridView con la lista de productos
                ActualizarDGV();

                // Calcular los totales (subtotal, ISV, total)
                CalcularTotales();
                int idProducto = Convert.ToInt32(CMBIDPRODUCTOVENTA.SelectedValue); // Asumiendo que seleccionas el producto por ID
                int cantidad = Convert.ToInt32(TXTCANTIDADDV.Text); // Cantidad seleccionada

                // Verificar stock antes de agregar
                int stockActual = query.ObtenerStockProducto(idProducto);

                if (stockActual < cantidad || stockActual - cantidad < 2)
                {
                    MessageBox.Show("No hay suficiente stock para este producto o dejaría menos de 2 unidades en inventario.");
                }
                else
                {
                    // Si el stock es suficiente, agregamos el producto al DGVORIGEN
                    DGVVENTAtp.Rows.Add(idProducto, CMBIDPRODUCTOVENTA.Text, cantidad, stockActual - cantidad);
                }


            }*/
            if (CMBIDPRODUCTOVENTA.SelectedValue != null && !string.IsNullOrEmpty(TXTCANTIDADDV.Text))
            {
                // Obtener el ID del producto y la cantidad ingresada
                int idProducto = Convert.ToInt32(CMBIDPRODUCTOVENTA.SelectedValue);
                int cantidad = Convert.ToInt32(TXTCANTIDADDV.Text);

                // Verificar stock antes de agregar el producto
                int stockActual = query.ObtenerStockProducto(idProducto);

                // Validar si el stock es suficiente y si dejaría al menos 2 unidades en inventario
                if (stockActual < cantidad || stockActual - cantidad < 2)
                {
                    MessageBox.Show("No hay suficiente stock para este producto o dejaría menos de 2 unidades en inventario.");
                    return; // No agregar el producto si la validación falla
                }

                // Crear un nuevo detalle de venta
                DetalleVenta det = new DetalleVenta();
                det.ProductoID = idProducto;
                det.NombreProducto = CMBIDPRODUCTOVENTA.Text; // Nombre del producto
                det.Cantidad = cantidad;
                det.PrecioUnitario = Convert.ToSingle(TXTPRECIOUDV.Text);

                // Agregar el detalle a la lista de productos
                listaProductos.Add(det);

                // Actualizar el DataGridView con la lista de productos
                ActualizarDGV();

                // Calcular los totales (subtotal, ISV, total)
                CalcularTotales();
            }
        }

        public class Venta
        {
            public DateTime Fecha { get; set; }
            public int ClienteID { get; set; }
            public int EmpleadoID { get; set; }
            public int MetodoPagoID { get; set; }
            public bool EsCredito { get; set; }
            
            public float Subtotal { get; set; }
            public float Total { get; set; }
            public float ISV { get; set; }
        }

        
        public class DetalleVenta
        {
            public int ProductoID { get; set; }
            public string NombreProducto { get; set; } // NUEVO
            public int Cantidad { get; set; }
            public float PrecioUnitario { get; set; }
            public float Subtotal => PrecioUnitario * Cantidad;
        }


        private void CMBIDCLIENTEV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)CMBIDCLIENTEV.SelectedItem;
            TXTNOMBRECLIENTE.Text = drv["nombrec"].ToString();
            TXTAPELLIDOCLIENTE.Text = drv["apellidoc"].ToString();
            TXTDIRECCIONCLIENTE.Text = drv["direccion"].ToString();
            TXTTELEFONOCLIENTE.Text = drv["telefonoc"].ToString();
        }
        private void CargarProductos()
        {
            CMBIDPRODUCTOVENTA.DataSource = datos.ObtenerProductos();
            CMBIDPRODUCTOVENTA.DisplayMember = "nombrep";
            CMBIDPRODUCTOVENTA.ValueMember = "idproducto";
        }
        private void CalcularTotales()
        {
            float subtotal = listaProductos.Sum(p => p.Subtotal);
            float isv = subtotal * 0.15f;
            float total = subtotal + isv ;

            TXTSUBTOTALV.Text = subtotal.ToString("0.00");
            TXTISVVENTA.Text = isv.ToString("0.00");
            TXTTOTALVENTA.Text = total.ToString("0.00");
        }

        /*private void BTNIMRPIMIR_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.Fecha = DateTime.Now;
            v.ClienteID = Convert.ToInt32(CMBIDCLIENTEV.SelectedValue);
            v.EmpleadoID = Convert.ToInt32(CMBIDEMPLEADOV.SelectedValue);
            v.MetodoPagoID = Convert.ToInt32(CMBMETODO.SelectedValue);
            v.EsCredito = CMBMETODO.Text == "Crédito";
            v.Subtotal = float.Parse(TXTSUBTOTALV.Text);
            v.Descuento = float.Parse(TXTDESCUENTOV.Text);
            v.ISV = float.Parse(TXTISVVENTA.Text);
            v.Total = float.Parse(TXTTOTALVENTA.Text);

            QUERY q = new QUERY();
            q.GuardarVenta(v, listaProductos);

            MessageBox.Show("Venta registrada correctamente");
            listaProductos.Clear();
            DGVVENTA.DataSource = null;*/

            private void BTNIMRPIMIR_Click(object sender, EventArgs e)
            {
            // Validar si hay productos en la lista antes de guardar
            if (listaProductos.Count == 0)
            {
               MessageBox.Show("No hay productos agregados a la venta.");
               return;
            }

            // Crear una nueva venta
            Venta v = new Venta();
            v.Fecha = DateTime.Now;
            v.ClienteID = Convert.ToInt32(CMBIDCLIENTEV.SelectedValue);
            v.EmpleadoID = Convert.ToInt32(CMBIDEMPLEADOV.SelectedValue);
            v.MetodoPagoID = Convert.ToInt32(CMBMETODO.SelectedValue);
            v.EsCredito = CMBMETODO.Text == "Crédito";
            v.Subtotal = float.Parse(TXTSUBTOTALV.Text);
            v.ISV = float.Parse(TXTISVVENTA.Text);
            v.Total = float.Parse(TXTTOTALVENTA.Text);
            bool credito = RBSI1.Checked;

            //credito = (escredito == 1);
             bool esCredito = RBSI1.Checked;
           // Si la venta es a crédito, actualizar el saldo del cliente
             if (esCredito)
            {
               datos.actualizarsaldo(v.ClienteID, v.Total);  // Actualizar el saldo
            }

           // Llamar a la función GuardarVenta para guardar la venta y sus detalles
            int idVenta = datos.GuardarVenta(v, listaProductos);
            // Usar el ID de la venta como código de factura
            string codigoFactura = "F-" + idVenta.ToString("D6"); // Formato F-000001, F-000002, etc.

            // Mostrar el código de factura en el formulario (puedes agregar un control para mostrarlo)
             TXTIDVENTA.Text = codigoFactura;

             // Actualizar el stock de los productos vendidos
            foreach (var detalle in listaProductos)
            {
                datos.ActualizarStockProducto(detalle.ProductoID, detalle.Cantidad);
            }

            // Mostrar mensaje de éxito
            MessageBox.Show("Venta registrada correctamente.");

            // Limpiar los controles después de guardar
            listaProductos.Clear();
            DGVVENTAtp.DataSource = null;
            CalcularTotales(); // Resetear los totales

             // Abrir el formulario de imprimir factura y pasar los datos
             VER_VENTA frmImprimir = new VER_VENTA();

             // Asumiendo que el formulario IMPRIMIR_FACTURA tiene propiedades para recibir los datos
             frmImprimir.CodigoFactura = codigoFactura;
             frmImprimir.DetallesVenta = listaProductos;

             // Mostrar el formulario de impresión
             frmImprimir.ShowDialog();

            // Variables para almacenar los detalles de la venta
        }

        private void cargarempleado()//funciones 
        {
            DataTable dt = query.obteneridempleado();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrecompletoe"] = "SELECCIONE EL EMPLEADO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBIDEMPLEADOV.DataSource = dt;
            CMBIDEMPLEADOV.DisplayMember = "nombrecompletoe";
            CMBIDEMPLEADOV.ValueMember = "idempleado";
            CMBIDEMPLEADOV.SelectedIndex = 0;

        }
        private void CargarMetodosPago()
        {
            CMBMETODO.DataSource = datos.ObtenerMetodosPago();
            CMBMETODO.DisplayMember = "nombremetodo";
            CMBMETODO.ValueMember = "idmetodo";
        }
        private void CargarClientes()
        {

            DataTable dt = datos.ObtenerClientes(); // Este método lo defines tú
            CMBIDCLIENTEV.DataSource = dt;
            CMBIDCLIENTEV.DisplayMember = "dnic";
            CMBIDCLIENTEV.ValueMember = "idcliente";
        }

        private void TXTPRECIOUDV_TextChanged(object sender, EventArgs e)
        {


        }

        private void CMBIDPRODUCTOVENTA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CMBIDPRODUCTOVENTA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CMBIDPRODUCTOVENTA.SelectedValue != null)
            {
                int idProducto = Convert.ToInt32(CMBIDPRODUCTOVENTA.SelectedValue);
                DataTable dt = datos.ObtenerPrecioProducto(idProducto);
                if (dt.Rows.Count > 0)
                {
                    TXTPRECIOUDV.Text = dt.Rows[0]["preciov"].ToString();
                }
            }
        }

        private void ActualizarDGV()
        {
            DGVVENTAtp.DataSource = null;
            DGVVENTAtp.DataSource = listaProductos;

            DGVVENTAtp.Columns["ProductoID"].Visible = false;
            DGVVENTAtp.Columns["NombreProducto"].HeaderText = "Producto";
            DGVVENTAtp.Columns["Cantidad"].HeaderText = "Cantidad";
            DGVVENTAtp.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            DGVVENTAtp.Columns["Subtotal"].HeaderText = "Subtotal";
            
        }

        private void n(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNAGREAGARCLIENTEVEN_Click(object sender, EventArgs e)
        {
            CLIENTE frm = new CLIENTE();
            frm.Show();
            this.Close();

        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();
        }

        private void BTNELIMINARGASTO_Click(object sender, EventArgs e)
        {
            if (DGVVENTAtp.SelectedRows.Count > 0)
            {
                int index = DGVVENTAtp.SelectedRows[0].Index;

                // Eliminar de la lista
                listaProductos.RemoveAt(index);

                // Reasignar la lista al DataSource para que se actualice visualmente
                DGVVENTAtp.DataSource = null;
                DGVVENTAtp.DataSource = listaProductos;

                CalcularTotales(); // Recalcula los totales después de eliminar
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }
    }
}
