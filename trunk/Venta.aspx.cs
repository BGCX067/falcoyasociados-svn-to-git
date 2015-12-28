using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class NegociosInmobiliarios_Venta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /*protected void cargarMonoAmbienteSantaFe()
    {
        SqlConnection con = Datos.obtenerConexion();
        SqlCommand cmd = new SqlCommand("usp_MostrarInmueble", con);

        try
        {

            cmd.CommandType = CommandType.StoredProcedure;
          
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {

                txtDir.Text = da["direccion"].ToString() + " Nº" + da["nroDireccion"].ToString();
                txtDesc.Text = da["descripcion"].ToString();
                byte[] foto = System.Text.Encoding.Unicode.GetBytes(da["fotos"].ToString());
                listaFotos.Add(TablaNavegar.Bytes2Image(foto));
                int i = listaFotos.Count;


            }

        }

        catch (Exception ex) { txtDesc.Text = ex.Message; }
        con.Close();


    }*/
}
