using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

/// <summary>
/// Descripción breve de UltimasNoticias
/// </summary>
public class UltimasNoticias
{


    public UltimasNoticias()
    {


    }
    public static String actualizarVentas()
    {

        //String nro="";
        int nro = 0;
        String venta = "";

        SqlConnection con = Datos.obtenerConexion();
        String sql = " select * from Inmueble where estado='2' ";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        SqlDataReader da = cmd.ExecuteReader();
        while (da.Read())
        {
            if (int.Parse(da["idInmueble"].ToString()) > nro)
            {
                nro = int.Parse(da["idInmueble"].ToString());
                venta = da["descripcion"].ToString();

            }
        }
        da.Close();
        //nro1 = Int32.Parse(nro);
        return venta;


    }

    public static String fechaVentas()
    {

        //String nro="";
        int nro = 0;

        String fechaVta = "";
        SqlConnection con = Datos.obtenerConexion();
        String sql = " select * from Inmueble where estado='2' ";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        SqlDataReader da = cmd.ExecuteReader();
        while (da.Read())
        {
            if (int.Parse(da["idInmueble"].ToString()) > nro)
            {
                nro = int.Parse(da["idInmueble"].ToString());
                fechaVta = da["fechaIngreso"].ToString();

            }
        }
        da.Close();
        //nro1 = Int32.Parse(nro);
        return fechaVta;


    }



    public static String actualizarAlquiler()
    {

        int nro = 0;
        String alquiler = "";

        SqlConnection con = Datos.obtenerConexion();
        String sql = " select * from Inmueble where estado='1'";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        SqlDataReader da = cmd.ExecuteReader();
        while (da.Read())
        {
            if (int.Parse(da["idInmueble"].ToString()) > nro)
            {
                nro = int.Parse(da["idInmueble"].ToString());
                alquiler = da["descripcion"].ToString();

            }
        }
        da.Close();
        //nro1 = Int32.Parse(nro);
        return alquiler;

    }
    public static String fechaAlquiler()
    {

        //String nro="";
        int nro = 0;

        String fechaAlq = "";
        SqlConnection con = Datos.obtenerConexion();
        String sql = " select * from Inmueble where estado='1' ";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        SqlDataReader da = cmd.ExecuteReader();
        while (da.Read())
        {
            if (int.Parse(da["idInmueble"].ToString()) > nro)
            {
                nro = int.Parse(da["idInmueble"].ToString());
                fechaAlq = da["fechaIngreso"].ToString();

            }
        }
        da.Close();
        //nro1 = Int32.Parse(nro);
        return fechaAlq;


    }



}
