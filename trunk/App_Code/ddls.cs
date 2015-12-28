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
/// Summary description for ddls
/// </summary>
public class ddls
{
	public ddls()
	{
		
	}


    public static void cargar(String from, DropDownList ddl, String nom, String id)
    {
        SqlConnection con = Datos.obtenerConexion();
        String sql = " select * from "+ from ;
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        SqlDataReader da = cmd.ExecuteReader();
        while (da.Read())
        {
            ddl.Items.Add(new ListItem(da["" + nom + ""].ToString(), da["" + id + ""].ToString()));
          
        }
        da.Close();
        //ddl.Items.Add(new ListItem("Todos", "0"));
    }

  
}
