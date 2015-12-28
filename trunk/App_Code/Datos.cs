using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Datos
/// </summary>
public class Datos
{
	public Datos()
	{
	
	}
    public static SqlConnection obtenerConexion()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["BDFalcoConnectionString"].ConnectionString.ToString());
        con.Open();
        return con;
    }
    public static void EjecutarComando(string strSQL, SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand(strSQL, con);
        cmd.ExecuteNonQuery();
    }

    public static DataSet ObtenerDataset(string strSQL, SqlConnection con,
string dataTable)
    {
        SqlCommand cmd = new SqlCommand(strSQL, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, dataTable);
        return ds;
    }

    public static int obtenerUltimoNro()
    {   //String nro="";
        int nro = 0;
        SqlConnection con = Datos.obtenerConexion();
        String sql = " select idInmueble from Inmueble";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        SqlDataReader da = cmd.ExecuteReader();
        while (da.Read())
        {
            if (int.Parse(da["idInmueble"].ToString()) > nro)
            {
                nro = int.Parse(da["idInmueble"].ToString());
            }
        }
        da.Close();
        //nro1 = Int32.Parse(nro);
        return nro;
    }

    
}
