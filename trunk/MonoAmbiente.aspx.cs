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

public partial class MonoAmbiente : System.Web.UI.Page
{
    private static ArrayList listaFotos;
    protected void Page_Load(object sender, EventArgs e)
    {
        listaFotos = new ArrayList();
        cargarMonoAmbienteSantaFe();
        /*if ((String)Application["Ciudad"].ToString() == "Santa Fe")
        {
            if (!IsPostBack)
            {


            }
        }
        if ((String)Application["Ciudad"].ToString() == "Rosario")
        {
            if (!IsPostBack)
            {


            }
        }*/
    }

    public void cargarMonoAmbienteSantaFe()
    {


        SqlConnection con = Datos.obtenerConexion();
        SqlCommand cmd = new SqlCommand("usp_MostrarInmueble", con);

        try
        {

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@hab", 1));
            cmd.Parameters.Add(new SqlParameter("@ciudad", 1));
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
          
               
                txtDir.Text = da["direccion"].ToString() + " Nº" + da["nroDireccion"].ToString();
                txtDesc.Text= da["descripcion"].ToString();
                byte[] foto = System.Text.Encoding.Unicode.GetBytes(da["fotos"].ToString());
                listaFotos.Add(TablaNavegar.Bytes2Image(foto));
                int i = listaFotos.Count;
                imagen1.Attributes.Add("foto",listaFotos[1].ToString());
         
                
            }

        }

        catch (Exception ex) { txtDesc.Text = ex.Message; }
        con.Close();


    }

    protected void cargarMonoAmbienteRosario()
    {
    }
}
