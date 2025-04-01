using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FERRETERIAPROYECTO
{
    internal class QUERY
    {

        CONEXIONBD cxn = new CONEXIONBD();

        public void agregarempleado(string nombre, string apellido, string dni, string contraseña, int telefono, float sueldo,string cargo, DateTime fecha )
        {
            try
            {

                cxn.Abrir();
                string query = "insert into empleado (nombree,apellidoe,dnie,contraseña,telefonoe,sueldo,cargo,fechae) VALUES(@nombree,@apellidoe,@dnie,@contraseña,@telefonoe,@sueldo,@cargo,@fechae)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@nombree", nombre);
                cmd.Parameters.AddWithValue("@apellidoe", apellido);
                cmd.Parameters.AddWithValue("@dnie", dni);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@telefonoe", telefono);
                cmd.Parameters.AddWithValue("@sueldo", sueldo);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@fechae", fecha);

                cmd.ExecuteNonQuery();
                MessageBox.Show("EMPLEADO AGREGADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INSERTAR EMPLEADO: " + ex.ToString());
            }

        }

        public void mostrarempleados (DataGridView dgv)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from empleado", cxn.cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }


            catch (Exception ex)
            {

                MessageBox.Show("NO SE LOGRO LLENAR LA TABLA", ex.Message);



            }
        }

        public void eliminarempleado(int id ,string nombre, string apellido, string dni, string contraseña, int telefono, float sueldo, string cargo, DateTime fecha)
        {
            try
            {

                cxn.Abrir();
                string query = "delete from empleado where idempleado = @idempleado AND nombree =@nombree  AND  apellidoe= @apellidoe AND  dnie = @dnie  AND  contraseña= @contraseña AND telefonoe =@telefonoe AND sueldo =@sueldo AND cargo =@cargo AND fechae =@fechae ";
                //DELETE FROM RUTA WHERE id_viaje = @id AND origen = @origen  AND destino = @destino
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idempleado", id);
                cmd.Parameters.AddWithValue("@nombree", nombre);
                cmd.Parameters.AddWithValue("@apellidoe", apellido);
                cmd.Parameters.AddWithValue("@dnie", dni);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@telefonoe", telefono);
                cmd.Parameters.AddWithValue("@sueldo", sueldo);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@fechae", fecha);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR: " + ex.ToString());
            }

        }

        public void actualizarempleado (int id,string nombre, string apellido, string dni, string contraseña, int telefono, float sueldo, string cargo, DateTime fecha)
        {
            try
            {

                cxn.Abrir();
                string query = "update empleado set nombree =@nombree, apellidoe= @apellidoe ,dnie = @dnie ,contraseña= @contraseña ,telefonoe =@telefonoe , sueldo =@sueldo , cargo =@cargo ,fechae =@fechae  where idempleado = @idempleado";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                
               
                cmd.Parameters.AddWithValue("@nombree", nombre);
                cmd.Parameters.AddWithValue("@apellidoe", apellido);
                cmd.Parameters.AddWithValue("@dnie", dni);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@telefonoe", telefono);
                cmd.Parameters.AddWithValue("@sueldo", sueldo);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@fechae", fecha);
                cmd.Parameters.AddWithValue("@idempleado", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ACTUALIZADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE LOGRO ACTUALIZAR EL REGISTRO " + ex.ToString());
            }



        }

        public void agregarcliente(string nombre, string apellido, string dni, int telefono, string estado, string direccion, decimal saldo, DateTime fecha)
        {
            try
            {

                cxn.Abrir();
                string query = "insert into cliente (nombrec,apellidoc,dnic,telefonoc,estado,direccion,saldopendiente,fechac) VALUES(@nombrec,@apellidoc,@dnic,@telefonoc,@estado,@direccion,@saldopendiente,@fechac)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@nombrec", nombre);
                cmd.Parameters.AddWithValue("@apellidoc", apellido);
                cmd.Parameters.AddWithValue("@dnic", dni);
                cmd.Parameters.AddWithValue("@telefonoc", telefono);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@saldopendiente", saldo);
                cmd.Parameters.AddWithValue("@fechac", fecha);

                cmd.ExecuteNonQuery();
                MessageBox.Show("CLIENTE AGREGADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INSERTAR CLIENTE: " + ex.ToString());
            }

        }

        public void mostrarclientes(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from cliente", cxn.cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }


            catch (Exception ex)
            {

                MessageBox.Show("NO SE LOGRO LLENAR LA TABLA", ex.Message);



            }
        }

        public void eliminarclientes(int id, string nombre, string apellido, string dni, int telefono, string estado, string direccion, decimal saldo, DateTime fecha)
        {
            try
            {

                cxn.Abrir();
                string query = "delete from cliente where idcliente = @idcliente AND nombrec =@nombrec  AND  apellidoc= @apellidoc AND  dnic = @dnic  AND telefonoc =@telefonoc AND estado =@estado AND direccion =@direccion AND saldopendiente =@saldopendiente AND fechac =@fechac ";
                //DELETE FROM RUTA WHERE id_viaje = @id AND origen = @origen  AND destino = @destino
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idcliente", id);
                cmd.Parameters.AddWithValue("@nombrec", nombre);
                cmd.Parameters.AddWithValue("@apellidoc", apellido);
                cmd.Parameters.AddWithValue("@dnic", dni);
                cmd.Parameters.AddWithValue("@telefonoc", telefono);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@saldopendiente", saldo);
                cmd.Parameters.AddWithValue("@fechac", fecha);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR: " + ex.ToString());
            }


        }

        public void actualizarcliente(int id, string nombre, string apellido, string dni, int telefono, string estado, string direccion, decimal saldo, DateTime fecha)
        {
            try
            {

                cxn.Abrir();
                string query = "update cliente set nombrec =@nombrec, apellidoc= @apellidoc ,dnic = @dnic ,telefonoc =@telefonoc , estado = @estado, direccion=@direccion , saldopendiente =@saldopendiente ,fechac =@fechac where idcliente = @idcliente";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);


                cmd.Parameters.AddWithValue("@idcliente", id);
                cmd.Parameters.AddWithValue("@nombrec", nombre);
                cmd.Parameters.AddWithValue("@apellidoc", apellido);
                cmd.Parameters.AddWithValue("@dnic", dni);
                cmd.Parameters.AddWithValue("@telefonoc", telefono);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@saldopendiente", saldo);
                cmd.Parameters.AddWithValue("@fechac", fecha);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ACTUALIZADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE LOGRO ACTUALIZAR EL REGISTRO " + ex.ToString());
            }



        }

      
        public DataTable obtenercategorias()
        {
            //string consulta = "SELECT DISTINCT nombrecate FROM categoria";
            string consulta = "SELECT idcategoria, nombrecate FROM categoria";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cxn.cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void insertarprovedor(string nombre, int telefono)
        {
            try
            {

                cxn.Abrir();
                string query = "insert into proveedor (nombreprov, telefonoprov ) VALUES(@nombreprov, @telefonoprov)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@nombreprov", nombre);
                cmd.Parameters.AddWithValue("@telefonoprov", telefono);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO AGREGADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INSERTAR EL PROVEEDOR: " + ex.ToString());
            }

        }

        
        
        public void eliminarproveedor(int id, string nombre, int telefono)
        {
            try
            {

                cxn.Abrir();
                string query = "delete from proveedor where idproveedor = @idproveedor AND nombreprov= @nombreprov AND telefonoprov = @telefonoprov";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idproveedor", id);
                cmd.Parameters.AddWithValue("@nombreprov", nombre);
                cmd.Parameters.AddWithValue("@telefonoprov", telefono);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ELIMINADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR EL PROVEEDOR: " + ex.ToString());
            }

        }

        public void actualizarproveedor(int id, string nombre, int telefono)
        {
            try
            {

                cxn.Abrir();
                string query = "update proveedor set nombreprov= @nombreprov,telefonoprov = @telefonoprov  where idproveedor = @idproveedor";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idproveedor", id);
                cmd.Parameters.AddWithValue("@nombreprov", nombre);
                cmd.Parameters.AddWithValue("@telefonoprov", telefono);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ACTUALIZADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR EL PROVEEDOR: " + ex.ToString());
            }

        }


        public void llenarcmbprove(ComboBox cmb)
        {
           
            cxn.Abrir();
            string sqls = "select idproveedor,nombreprov from proveedor;";
           
            SqlCommand comando = new SqlCommand(sqls, cxn.cn);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb.DataSource = dt;
            cmb.DisplayMember = "nombreprov";
            cmb.ValueMember = "idproveedor";

        }

        public void mostrarproveedor(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select *from proveedor", cxn.cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE LOGRO LLENAR LA TABLA", ex.Message);
            }
        }

        public DataTable obtenercprove()
        {
            //string consulta = "SELECT nombreprov FROM proveedor";
            string consulta = "SELECT idproveedor, nombreprov FROM proveedor";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cxn.cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void agregarproducto(string nombre, int stock, string descripcion, int fkidcategoria, int fkidproveedor, float precioc, float preciov)
        {
            try
            {

                cxn.Abrir();
                string query = "insert into producto (nombrep,stock,descripcion,fkidcategoria,fkidproveedor,precioc,preciov) VALUES(@nombrep,@stock,@descripcion,@fkidcategoria,@fkidproveedor,@precioc,@preciov)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@nombrep", nombre);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@fkidcategoria", fkidcategoria);
                cmd.Parameters.AddWithValue("@fkidproveedor", fkidproveedor);
                cmd.Parameters.AddWithValue("@precioc", precioc);
                cmd.Parameters.AddWithValue("@preciov", preciov);
                cmd.ExecuteNonQuery();
                MessageBox.Show("PRODUCTO AGREGADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INSERTAR EL PRODUCTO " + ex.ToString());
            }

        }

        public void mostrarproducto(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from producto", cxn.cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }


            catch (Exception ex)
            {

                MessageBox.Show("NO SE LOGRO LLENAR LA TABLA", ex.Message);



            }
        }

        public void eliminarproducto(int id,string nombre, int stock, string descripcion, int fkidcategoria, int fkidproveedor, float precioc, float preciov)
        {
            try
            {

                cxn.Abrir();
                string query = "delete from producto where idproducto = @idproducto AND nombrep =@nombrep AND stock =@stock AND descripcion =@descripcion AND fkidcategoria =@fkidcategoria AND fkidproveedor =@fkidproveedor AND precioc =@precioc AND preciov =@preciov";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idproducto", id);
                cmd.Parameters.AddWithValue("@nombrep", nombre);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@fkidcategoria", fkidcategoria);
                cmd.Parameters.AddWithValue("@fkidproveedor", fkidproveedor);
                cmd.Parameters.AddWithValue("@precioc", precioc);
                cmd.Parameters.AddWithValue("@preciov", preciov);
                cmd.ExecuteNonQuery();
                MessageBox.Show("PRODUCTO ELIMINADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR EL PRODUCTO " + ex.ToString());
            }

        }

        public void actualizarproducto(int id, string nombre, int stock, string descripcion, int fkidcategoria, int fkidproveedor, float precioc, float preciov)
        {
            try
            {

                cxn.Abrir();
                string query = "UPDATE producto set  nombrep =@nombrep ,stock =@stock ,descripcion =@descripcion ,fkidcategoria =@fkidcategoria , fkidproveedor =@fkidproveedor , precioc =@precioc , preciov =@preciov  where idproducto = @idproducto";
               
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                
                cmd.Parameters.AddWithValue("@nombrep",nombre);
                cmd.Parameters.AddWithValue("@stock",stock);
                cmd.Parameters.AddWithValue("@descripcion",descripcion);
                cmd.Parameters.AddWithValue("@fkidcategoria",fkidcategoria);
                cmd.Parameters.AddWithValue("@fkidproveedor",fkidproveedor);
                cmd.Parameters.AddWithValue("@precioc",precioc);
                cmd.Parameters.AddWithValue("@preciov",preciov);
                cmd.Parameters.AddWithValue("@idproducto",id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("PRODUCTO ACTUALIZADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR EL PRODUCTO " + ex.ToString());
            }

        }

        public DataTable obtenermetodo()
        {
            //string consulta = "SELECT DISTINCT nombrecate FROM categoria";
            string consulta = "SELECT idmetodo, nombremetodo FROM metodopago";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cxn.cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int agregarventa(DateTime fecha, int fkidcliente, int fkidempleado, int fkidmetodo, bool credito, float subtotal, float descuento, float isv, float total)
        {
            int idventa = 0;
            try
            {
                


                cxn.Abrir();
                string query = "insert into venta (fecha,fkidcliente,fkidempleado,fkidmetodo,escredito,subtotal,descuento,total,isv) VALUES(@fecha,@fkidcliente,@fkidempleado,@fkidmetodo,@escredito,@subtotal,@descuento,@total,@isv)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@fkidcliente", fkidcliente);
                cmd.Parameters.AddWithValue("@fkidempleado", fkidempleado);
                cmd.Parameters.AddWithValue("@fkidmetodo", fkidmetodo);
                cmd.Parameters.AddWithValue("@escredito", credito);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@descuento", descuento);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@isv", isv);

                idventa = Convert.ToInt32(cmd.ExecuteScalar()); // OUTPUT INSERTED.idventa devuelve el id generado

                cmd.ExecuteNonQuery();
                MessageBox.Show("VENTA REGISTRADA.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REGISTRAR LA VENTA: " + ex.ToString());
            }

            return idventa;
        }

        public void agregardetalleventa( int idventa, int fkidproducto, int cantidad, float subtotal, float preciouni)
        {
            try
            {

                cxn.Abrir();
                string query = "insert into detalleventa (fkidventa,fkidproducto,cantidad,subtotal,preciouni) VALUES(@fkidventa,@fkidproducto,@cantidad,@subtotal,@preciouni)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@fkidventa", idventa);
                cmd.Parameters.AddWithValue("@fkidproducto", fkidproducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@preciouni", preciouni);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("VENTA REGISTRADA.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REGISTRAR LA VENTA: " + ex.ToString());
            }

        }

        public void eliminarventa(int id,DateTime fecha, int fkidcliente, int fkidempleado, int fkidmetodo, bool credito, float subtotal, float descuento, float isv, float total)
        {
            try
            {

                cxn.Abrir();
                string query = "delete from venta  where idventa =@idventa AND fecha = @fecha AND fkidcliente = @fkidcliente AND fkidempleado = @fkidempleado AND fkidmetodo = @fkidmetodo AND escredito =@escredito AND subtotal = @subtotal AND descuento =@descuento AND total= @total AND isv= @isv";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idventa", id);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@fkidcliente", fkidcliente);
                cmd.Parameters.AddWithValue("@fkidempleado", fkidempleado);
                cmd.Parameters.AddWithValue("@fkidmetodo", fkidmetodo);
                cmd.Parameters.AddWithValue("@escredito", credito);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@descuento", descuento);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@isv", isv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("VENTA ELIMINADA.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR LA VENTA: " + ex.ToString());
            }

        }

        public void mostrarventa(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from venta", cxn.cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }


            catch (Exception ex)
            {

                MessageBox.Show("NO SE LOGRO LLENAR LA TABLA", ex.Message);



            }
        }

        public void actualizarventa(int id,DateTime fecha, int fkidcliente, int fkidempleado, int fkidmetodo, bool credito, float subtotal, float descuento, float isv, float total)
        {
            try
            {
                

                cxn.Abrir();
                string query = "update venta set  fkidcliente = @fkidcliente , fkidempleado = @fkidempleado , fkidmetodo = @fkidmetodo , escredito =@escredito, subtotal = @subtotal , descuento =@descuento , total= @total , isv= @isv where fecha = @fecha";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idventa", id);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@fkidcliente", fkidcliente);
                cmd.Parameters.AddWithValue("@fkidempleado", fkidempleado);
                cmd.Parameters.AddWithValue("@fkidmetodo", fkidmetodo);
                cmd.Parameters.AddWithValue("@escredito", credito);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@descuento", descuento);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@isv", isv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("VENTA ACTUALIZADA.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR LA VENTA: " + ex.ToString());
            }

        }

        

        public DataTable obtenertipogasto()
        {
            //string consulta = "SELECT DISTINCT nombrecate FROM categoria";
            string consulta = "SELECT idtipogasto, nombre FROM tipogasto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cxn.cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public void agregaregreso(string descripcion, int monto, DateTime fecha, int fkidtipogasto)
        {
            try
            {

                cxn.Abrir();
                string query = "insert into egresos (descripcion,monto,fecha,fkidtipogasto) VALUES(@descripcion,@monto,@fecha,@fkidtipogasto)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@fkidtipogasto", fkidtipogasto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("EGRESO REGISTRADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REGSITRAR EL EGRESO: " + ex.ToString());
            }

        }

        public void mostraregreso(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from egresos", cxn.cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }


            catch (Exception ex)
            {

                MessageBox.Show("NO SE LOGRO LLENAR LA TABLA", ex.Message);



            }
        }

        public void eliminaregreso(int id,string descripcion, int monto, DateTime fecha, int fkidtipogasto)
        {
            try
            {

                cxn.Abrir();
                string query = "delete from egresos where idegreso =@idegreso AND descripcion=@descripcion AND monto=@monto AND fecha =@fecha AND fkidtipogasto=@fkidtipogasto";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idegreso", id);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@fkidtipogasto", fkidtipogasto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("EGRESO ELIMINADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR EL EGRESO: " + ex.ToString());
            }

        }

        public void actualizaregreso(int id, string descripcion, int monto, DateTime fecha, int fkidtipogasto)
        {
            try
            {

                cxn.Abrir();
                string query = "update egresos  set descripcion=@descripcion , monto=@monto ,fecha =@fecha ,fkidtipogasto=@fkidtipogasto where idegreso =@idegreso";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@idegreso", id);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@fkidtipogasto", fkidtipogasto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("EGRESO ACTUALIZADO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR EL EGRESO: " + ex.ToString());
            }

        }

        public DataTable obteneridclientes()
        {
            
            string consulta = "SELECT idcliente, CONCAT(nombrec, ' ', apellidoc) AS nombrecompleto FROM cliente";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cxn.cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable obtenerproducto()
        {
            string consulta = "SELECT idproducto, nombrep, preciov FROM producto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cxn.cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable obteneridempleado()
        {

            string consulta = "SELECT idempleado, CONCAT(nombree, ' ', apellidoe) AS nombrecompletoe FROM empleado";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cxn.cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void registrarplanilla( int fkidempleado, DateTime fechainicio, DateTime fechafin, float montopago)
        {
            try
            {

                cxn.Abrir();
                string query = "insert into planilla (fkidempleado,fechainicio,fechafin,montopago) values (@fkidempleado,@fechainicio,@fechafin,@montopago)";
                SqlCommand cmd = new SqlCommand(query, cxn.cn);
                cmd.Parameters.AddWithValue("@fkidempleado", fkidempleado);
                cmd.Parameters.AddWithValue("@fechainicio", fechainicio);
                cmd.Parameters.AddWithValue("@fechafin", fechafin);
                cmd.Parameters.AddWithValue("@montopago", montopago);
                cmd.ExecuteNonQuery();
                MessageBox.Show("PLANILLA REGISTRADA.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REGISTRAR LA PLANILLA: " + ex.ToString());
            }

        }

        public void mostrarplanilla(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from planilla", cxn.cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }


            catch (Exception ex)
            {

                MessageBox.Show("NO SE LOGRO LLENAR LA TABLA", ex.Message);



            }
        }


    }


}
