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
        CONEXIONBD cxn = new CONEXIONBD();

        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idventa = 1;
        public VENTAS()
        {
            InitializeComponent();
        }

        private (float subtotal, float isv, float total) calculartotales(int cantidad, float preciounitario, float descuento)
        {
            
            float subtotal = cantidad * preciounitario;

            subtotal -= descuento;

            float isv = subtotal * 0.15f;

            float total = subtotal + isv;
            return (subtotal, isv, total); 
        }

        private void actualizarvalores()
        {
            
            int cantidad;
            if (!int.TryParse(TXTCANTIDADDV.Text, out cantidad))
            {
                // MessageBox.Show("Por favor ingrese un número entero válido para la cantidad.");
                return;
            }

            
            float preciounitario;
            if (!float.TryParse(TXTPRECIOUDV.Text, out preciounitario)) //permite verificar si la conversión es posible sin lanzar excepciones
            {
                //MessageBox.Show("Por favor ingrese un precio unitario válido.");
                //return;
            }

            float descuento;
            if (!float.TryParse(TXTDESCUENTOV.Text, out descuento))
            {
                //MessageBox.Show("Por favor ingrese un valor numérico válido para el descuento.");
                return;
            }

           

           
            var totales = calculartotales(cantidad, preciounitario, descuento);

            
            float subtotal = totales.subtotal;
            float isv = totales.isv;
            float total = totales.total;

           
            TXTSUBTOTALV.Text = subtotal.ToString("F2");
            TXTISVVENTA.Text = isv.ToString("F2");
            TXTTOTALVENTA.Text = total.ToString("F2");
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
            
            cargarclientes();
            cargarproducto();
            cargarempleado();
            cargarmetodo();
            datos.mostrarventa(DGVVENTAssssssssssssssssss);
        }

        private void TXTCREDITOVENTA_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVVENTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXTSUBTOTALV_TextChanged(object sender, EventArgs e)
        {
            actualizarvalores();
        }

        private void BTNAGREGARVENTA_Click(object sender, EventArgs e)
        {
           /* try
            {
                int idProducto = Convert.ToInt32(CMBIDPRODUCTOVENTA.SelectedValue); // ID del producto
                int cantidadVenta = Convert.ToInt32(TXTCANTIDADDV.Text);     // Cantidad a vender

                int stockActual = query.ObtenerStockDisponible(idProducto);

                if (stockActual <= 2)
                {
                    MessageBox.Show("PRODUCTO INSUFICIENTE. Solo quedan " + stockActual + " unidades.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cantidadVenta > stockActual)
                {
                    MessageBox.Show("No hay suficiente stock para completar la venta. Solo quedan " + stockActual + " unidades.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
               // query.ActualizarStock(idProducto, cantidadVenta);

                MessageBox.Show("Venta registrada y stock actualizado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la venta: " + ex.Message);
            }
            actualizarvalores();

            //int escredito = 0;  // Por defecto, si el RadioButton "No" está seleccionado, el valor es 0

            int cantidad = Convert.ToInt32(TXTCANTIDADDV.Text);

            //float preciouni = Convert.ToSingle(TXTPRECIOUDV.Text);  

            if (!float.TryParse(TXTPRECIOUDV.Text, out float preciouni))
            {
                MessageBox.Show("Por favor ingrese un precio unitario válido.");
                return;
            }
            // Verificamos cuál RadioButton está seleccionado

            DateTime fecha = DTPVENTA.Value;
            int fkidcliente = Convert.ToInt32(CMBIDCLIENTEV.SelectedValue);
            int fkidempleado = Convert.ToInt32(CMBIDEMPLEADOV.SelectedValue);
            int fkidmetodo = Convert.ToInt32(CMBMETODO.SelectedValue);
            //bool credito = (RBSI1.Checked) ? true : false;
            bool credito = RBSI1.Checked;

            //credito = (escredito == 1);
            bool esCredito = RBSI1.Checked;

            float subtotal = Convert.ToSingle(TXTSUBTOTALV.Text);
            if (!float.TryParse(TXTISVVENTA.Text, out float isv))
            {
                //MessageBox.Show("Por favor ingrese un valor válido para el ISV.");
                return;
            }
            //float isv = Convert.ToSingle(TXTISVVENTA.Text);
            float total = Convert.ToSingle(TXTTOTALVENTA.Text);
            float descuento = Convert.ToSingle(TXTDESCUENTOV.Text);


            //int fkidventa = Convert.ToInt32(TXTIDVENTA.Text);
            int fkidproducto = Convert.ToInt32(CMBIDPRODUCTOVENTA.SelectedValue);
            int idventa = datos.agregarventa(fecha, fkidcliente, fkidempleado, fkidmetodo, credito, subtotal, descuento, isv, total);



            // Si la venta es a crédito, actualizar el saldo del cliente
            if (esCredito)
            {
                datos.actualizarsaldo(fkidcliente, total);  // Actualizar el saldo
            }

            // Obtener el ID del producto y agregar el detalle de la venta
            fkidproducto = Convert.ToInt32(CMBIDPRODUCTOVENTA.SelectedValue);

            // Agregar detalle de venta
            datos.agregardetalleventa(idventa, fkidproducto, cantidad, subtotal, preciouni);


            // Mostrar la venta en el DataGridView
            datos.mostrarventa(DGVVENTAssssssssssssssssss);*/


        }

        private void CANTIDAD_Click(object sender, EventArgs e)
        {

        }

        private void cargarclientes()//funciones 
        {
            DataTable dt = query.obteneridclientes();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrecompleto"] = "SELECCIONE EL CLIENTE";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBIDCLIENTEV.DataSource = dt;
            CMBIDCLIENTEV.DisplayMember = "nombrecompleto";
            CMBIDCLIENTEV.ValueMember = "idcliente";
            CMBIDCLIENTEV.SelectedIndex = 0;

            //CMBIDCLIENTEV.AutoCompleteMode = AutoCompleteMode.Suggest;
            //CMBIDCLIENTEV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //CMBIDCLIENTEV.AutoCompleteCustomSource = new AutoCompleteStringCollection();
        }

        private void cargarproducto()//funciones 
        {
            DataTable dt = query.obtenerproducto();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrep"] = "SELECCIONE EL PRODUCTO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBIDPRODUCTOVENTA.DataSource = dt;
            CMBIDPRODUCTOVENTA.DisplayMember = "nombrep";
            CMBIDPRODUCTOVENTA.ValueMember = "idproducto";
            CMBIDPRODUCTOVENTA.SelectedIndex = 0;


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


        private void cargarmetodo()//funciones 
        {
            DataTable dt = query.obtenermetodo();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombremetodo"] = "SELECCIONE EL METODO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBMETODO.DataSource = dt;
            CMBMETODO.DisplayMember = "nombremetodo";
            CMBMETODO.ValueMember = "idmetodo";
            CMBMETODO.SelectedIndex = 0;

        }

        private void CMBIDPRODUCTOVENTA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBIDPRODUCTOVENTA.SelectedIndex != -1)  // Asegúrate de que haya un producto seleccionado
            {
                // Obtener la fila correspondiente al producto seleccionado
                DataRowView rowView = CMBIDPRODUCTOVENTA.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    if (rowView["preciov"] != DBNull.Value)
                    {
                        // Obtener el precio del producto como float
                        float precio = Convert.ToSingle(rowView["preciov"]);

                        // Mostrar el precio en el TextBox con 2 decimales
                        TXTPRECIOUDV.Text = precio.ToString("F2");  // Muestra el precio con 2 decimales
                    }
                    else
                    {
                        // Si el precio es nulo, mostrar 0 o algún otro valor predeterminado
                        TXTPRECIOUDV.Text = "$0.00";
                    }
                }
            }
            else
            {
                // Limpiar el TextBox si no hay selección válida
                TXTPRECIOUDV.Clear();
            }
        }

        /*private void cargarventas()
        {
            DataTable dt = query.obtenerventas(); // query = instancia de tu clase QUERY
            DGVVENTA.DataSource = dt;
        }*/


        private void BTNELIMINARVENTA_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();

            DateTime fecha = Convert.ToDateTime(DGVVENTAssssssssssssssssss.CurrentRow.Cells["fecha"].Value);
            int id = Convert.ToInt32(DGVVENTAssssssssssssssssss.CurrentRow.Cells["idventa"].Value);
            int fkidcliente = Convert.ToInt32((DGVVENTAssssssssssssssssss.CurrentRow.Cells["fkidcliente"].Value));
            int fkidempleado = Convert.ToInt32((DGVVENTAssssssssssssssssss.CurrentRow.Cells["fkidempleado"].Value));
            int fkidmetodo = Convert.ToInt32((DGVVENTAssssssssssssssssss.CurrentRow.Cells["fkidmetodo"].Value));
            bool credito = Convert.ToBoolean(DGVVENTAssssssssssssssssss.CurrentRow.Cells["escredito"].Value);
            float subtotal = Convert.ToSingle((DGVVENTAssssssssssssssssss.CurrentRow.Cells["subtotal"].Value));
            float descuento = Convert.ToSingle((DGVVENTAssssssssssssssssss.CurrentRow.Cells["descuento"].Value));
            float isv = Convert.ToSingle((DGVVENTAssssssssssssssssss.CurrentRow.Cells["isv"].Value));
            float total = Convert.ToSingle((DGVVENTAssssssssssssssssss.CurrentRow.Cells["total"].Value));

            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (id != 0)
                {
                    datos.eliminarventa(id, fecha, fkidcliente, fkidempleado, fkidmetodo, credito, subtotal, descuento, isv, total);

                    datos.mostrarventa(DGVVENTAssssssssssssssssss);
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

        private void DGVVENTA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DTPVENTA.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[1].Value.ToString();
            CMBIDCLIENTEV.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[2].Value.ToString();
            CMBIDEMPLEADOV.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[3].Value.ToString();
            CMBMETODO.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[4].Value.ToString();
            int valor = Convert.ToInt32(DGVVENTAssssssssssssssssss.CurrentRow.Cells[5].Value);

            if (valor == 1)
            {
                RBSI1.Checked = true;  // Marca el RadioButton "Sí"
                RBNO0.Checked = false; // Desmarca el RadioButton "No"
            }
            else if (valor == 0)
            {
                RBNO0.Checked = true;  // Marca el RadioButton "No"
                RBSI1.Checked = false; // Desmarca el RadioButton "Sí"
            }
            else
            {
                // Si el valor es distinto de 0 o 1, puedes manejarlo aquí (por ejemplo, desmarcar ambos)
                RBSI1.Checked = false;
                RBNO0.Checked = false;
            }

            TXTSUBTOTALV.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[6].Value.ToString();
            TXTDESCUENTOV.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[7].Value.ToString();
            TXTTOTALVENTA.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[8].Value.ToString();
            TXTISVVENTA.Text = DGVVENTAssssssssssssssssss.CurrentRow.Cells[9].Value.ToString();
            
            
        }

        public (float subtotal, float isv, float total) calcular(int cantidad, float preciounitario, float descuento)
        {
            float subtotal = cantidad * preciounitario;

            // Aplicar descuento (si es que el descuento es un porcentaje o valor fijo)
            subtotal -= descuento; // Suponiendo que el descuento es un valor fijo

            // Calcular ISV (15% de subtotal)
            float isv = subtotal * 0.15f;

            // Calcular total (subtotal + ISV)
            float total = subtotal + isv;

            return (subtotal, isv, total); // Devuelve los resultados como una tupla
        }

        private void TXTCANTIDADDV_TextChanged(object sender, EventArgs e)
        {
            actualizarvalores();
        }

        private void TXTDESCUENTOV_TextChanged(object sender, EventArgs e)
        {
            actualizarvalores();
        }

        private void TXTTOTALVENTA_TextChanged(object sender, EventArgs e)
        {
            actualizarvalores();
        }

        private void TXTISVVENTA_TextChanged(object sender, EventArgs e)
        {
            actualizarvalores();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Show();
            this.Close();

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTNAGREAGARCLIENTEVEN_Click(object sender, EventArgs e)
        {
            CLIENTE frm = new CLIENTE();
            frm.ShowDialog();

        }

        private void GBVENTA_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void CMBIDEMPLEADOV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
