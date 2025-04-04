using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FERRETERIAPROYECTO
{
    public partial class INVENTARIO : Form
    {
        QUERY query = new QUERY();
        QUERY datos = new QUERY();
        QUERY cn = new QUERY();
        int idinventario = 1;
        public INVENTARIO()
        {
            InitializeComponent();
        }

        private void cargarprodu()//funciones 
        {
            DataTable dt = query.obtenerproducto();
            DataRow nuevaFila = dt.NewRow();
            nuevaFila["nombrep"] = "SELECCIONE EL PRODUCTO";
            dt.Rows.InsertAt(nuevaFila, 0);

            CMBIDPRODUINVE.DataSource = dt;
            CMBIDPRODUINVE.DisplayMember = "nombrep";
            CMBIDPRODUINVE.ValueMember = "idproducto";
            CMBIDPRODUINVE.SelectedIndex = 0;
        }

        private void cargarsali()//funciones 
        {
            DataTable dt = query.obtenersalidasid();
            DataRow nuevaFila = dt.NewRow();
            //nuevaFila["cantidad"] = "SELECCIONE";
           // dt.Rows.InsertAt(nuevaFila, 0);

            CMBSALIDAINV.DataSource = dt;
            CMBSALIDAINV.DisplayMember = "cantidad";
            CMBSALIDAINV.ValueMember = "idsalidas";
            CMBSALIDAINV.SelectedIndex = 0;
        }

        private void cargardatoscmbsal()
        {
           /* CMBSALIDAINV.Items.Clear();

            // Crear una instancia de la clase Query
            QUERY query = new QUERY();

            // Llamar al método que obtiene los datos
            DataTable dt = query.obtenersalidasid();

            // Recorrer las filas del DataTable y agregarlas al ComboBox
            foreach (DataRow row in dt.Rows)
            {
                int idSalida = Convert.ToInt32(row["idsalidas"]);
                string nombreProducto = row["nombrep"].ToString();
                int cantidad = Convert.ToInt32(row["cantidad"]);

                // Crear un nuevo objeto SalidaItem usando la clase interna de Query
                QUERY.salidas item = new QUERY.salidas (idSalida, nombreProducto, cantidad);

                // Agregar el ítem al ComboBox
                CMBSALIDAINV.Items.Add(item);

                
             }

            CMBSALIDAINV.DisplayMember = "nombreproductos";  // Lo que se mostrará
            CMBSALIDAINV.ValueMember = "idsalidas";

            // Si quieres seleccionar automáticamente el primer ítem del ComboBox
            if (CMBSALIDAINV.Items.Count > 0)
            {
                CMBSALIDAINV.SelectedIndex = 0;
            }*/
        }

        private void TXTNOMBREE_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNACTUALIZARINV_Click(object sender, EventArgs e)
        {
            int id, fkidproducto, cantidadactual,stockmin,fkidsalidas;
            string ubicacion;
            DateTime entrada;


            id = int.Parse(TXTIDINVENTARIO.Text);
            //Convert.ToInt32(TXTIDINVENTARIO.Text);
            fkidproducto = Convert.ToInt32(CMBIDPRODUINVE.SelectedValue);
            ubicacion = TXTUBIINV.Text;
            entrada = DTPFECHAINV.Value;
            cantidadactual = Convert.ToInt32(NUPCANTIDADINV.Text);
            stockmin = Convert.ToInt32(TXTSTOCKMIN.Text);
            fkidsalidas = Convert.ToInt32(CMBSALIDAINV.SelectedValue);


            datos.actualizarinventario(id,fkidproducto,cantidadactual,stockmin,ubicacion,entrada,fkidsalidas );
            datos.mostrarinventario(DGVINVENTARIO);
        }

        private void GBINVENTARIO_Enter(object sender, EventArgs e)
        {

        }

        private void INVENTARIO_Load(object sender, EventArgs e)
        {
           
            //cargardatoscmbsal();
            cargarprodu();
            cargarsali();
            datos.mostrarinventario(DGVINVENTARIO);
            TXTIDINVENTARIO.Text = idinventario.ToString();
        }

        private void CMBSALIDAINV_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (CMBSALIDAINV.SelectedIndex >= 0)
            {
                // Obtener el objeto seleccionado del ComboBox (cast a tipo QUERY.salidas)
                QUERY.salidas selectedItem = CMBSALIDAINV.SelectedItem as QUERY.salidas;

                // Verificar que el objeto seleccionado no sea null
                if (selectedItem != null)
                {
                    // Obtener el idsalidas desde el objeto seleccionado
                    int fkidsalidas = selectedItem.idsalidas;

                    // Acceder a otros datos del objeto (nombre del producto y cantidad)
                    string nombreProducto = selectedItem.nombreproductos;
                    int cantidad = selectedItem.cantidads;

                    // Mostrar los valores seleccionados, puedes usarlos como necesites
                   // MessageBox.Show($"ID de salida: {fkidsalidas}, Producto: {nombreProducto}, Cantidad: {cantidad}");
                }*/
           // }
        }

        private void BTNAGREGARINV_Click(object sender, EventArgs e)
        {
            idinventario++;
            TXTIDINVENTARIO.Text = idinventario.ToString();

            int fkidsalidas = Convert.ToInt32(CMBSALIDAINV.SelectedValue);
            int fkidproducto = Convert.ToInt32(CMBIDPRODUINVE.SelectedValue);
            int cantidadactual = int.Parse(NUPCANTIDADINV.Text);
            int stockmin = int.Parse(TXTSTOCKMIN.Text);
            DateTime entrada = DTPFECHAINV.Value;
            string ubicacion = TXTUBIINV.Text;

            datos.agregarinventario(fkidproducto, cantidadactual,stockmin,ubicacion, entrada,fkidsalidas);
            datos.mostrarinventario(DGVINVENTARIO);



        }

        private void BTNELIMINARINV_Click(object sender, EventArgs e)
        {
            QUERY query = new QUERY();

            int id = Convert.ToInt32(DGVINVENTARIO.CurrentRow.Cells["idinventario"].Value);
            int fkidproducto = Convert.ToInt32((DGVINVENTARIO.CurrentRow.Cells["fkidproducto"].Value));
            int cantidadactual = Convert.ToInt32((DGVINVENTARIO.CurrentRow.Cells["cantidadactual"].Value));
            int stockmin = Convert.ToInt32(DGVINVENTARIO.CurrentRow.Cells["stockmin"].Value);
            string ubicacion = DGVINVENTARIO.CurrentRow.Cells["ubicacion"].Value?.ToString();
            DateTime entrada = Convert.ToDateTime(DGVINVENTARIO.CurrentRow.Cells["entrada"].Value);
            int fkidsalidas = Convert.ToInt32((DGVINVENTARIO.CurrentRow.Cells["fkidsalidas"].Value));


            DialogResult result = MessageBox.Show("¿ESTA SEGURO DE ELIMNAR ESTE REGISTRO?", "CONFIRMAR ELIMINACION",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(ubicacion))
                {
                    datos.eliminarinventario(id,fkidproducto,cantidadactual,stockmin,ubicacion,entrada,fkidsalidas);

                    datos.mostrarinventario(DGVINVENTARIO);
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

        private void DGVINVENTARIO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTIDINVENTARIO.Text = DGVINVENTARIO.CurrentRow.Cells[0].Value.ToString();
            CMBIDPRODUINVE.Text = DGVINVENTARIO.CurrentRow.Cells[1].Value.ToString();
           NUPCANTIDADINV.Text = DGVINVENTARIO.CurrentRow.Cells[2].Value.ToString();
           TXTSTOCKMIN.Text = DGVINVENTARIO.CurrentRow.Cells[3].Value.ToString();
            TXTUBIINV.Text = DGVINVENTARIO.CurrentRow.Cells[4].Value.ToString();
           DTPFECHAINV.Text = DGVINVENTARIO.CurrentRow.Cells[5].Value.ToString();
            CMBSALIDAINV.Text =DGVINVENTARIO.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
