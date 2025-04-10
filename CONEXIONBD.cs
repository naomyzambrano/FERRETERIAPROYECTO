using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

class CONEXIONBD
{
    string cadenaConexion = "Data Source = DESKTOP-LTCAMHT\\SQLEXPRESS; Initial Catalog = ferreteriabd; Integrated Security = True; TrustServerCertificate=True";
    
    public SqlConnection cn = new SqlConnection();

    public CONEXIONBD()
    {
        cn.ConnectionString = cadenaConexion;

    }

    public void Abrir()
    {
        try
        {

            cn.Open();
            Console.WriteLine("CONEXION ABIERTA");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR AL ABRIR BASE DE DATOS", ex.ToString());
            
        }
        

    }
    public void Cerrar()
    {
        if (cn.State == System.Data.ConnectionState.Open)
        {
            cn.Close();
        }
    }



}




namespace FERRETERIAPROYECTO
{
   /* internal class CONEXIONBD
    {
    }*/
}
