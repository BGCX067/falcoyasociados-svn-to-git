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
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

public partial class AgregarInmueble : System.Web.UI.Page
{
   
    private static ArrayList listaBytes;
    private int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        if (!IsPostBack)
        {
           
            ddls.cargar("EstadoInmueble", ddlTipo, "nombre", "idEstado"); //Carga los combos
            ddls.cargar("Habitacion", ddlHab, "nombre", "idHabitacion"); //Carga los combos
            ddls.cargar("Ciudad", ddlCiudad, "nombre", "idCiudad"); //Carga los combos
            
            listaBytes = new ArrayList();
          
        
        }
        
    }

    protected void btnCargar_Click(object sender, EventArgs e)
   {
      
        SqlConnection con = Datos.obtenerConexion();
        SqlCommand cmd = new SqlCommand("usp_NuevoInmueble", con);
        
        try
        {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pId = cmd.Parameters.Add("@id", SqlDbType.Int, 4);
                pId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@direccion", txtDir.Text));
                int nroDir= Convert.ToInt32(txtNroDir.Text);
                cmd.Parameters.Add(new SqlParameter ("@nroDireccion", nroDir));
                DateTime fecha = Convert.ToDateTime(DateTime.Today);
                cmd.Parameters.Add(new SqlParameter("@fechaIngreso",fecha));
                cmd.Parameters.Add(new SqlParameter("@habitacion", ddlHab.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@estado", ddlTipo.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@ciudad", ddlCiudad.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@descripcion", txtDesc.Text));
                
                id = Convert.ToInt32(pId.Value);
             
                cmd.ExecuteNonQuery();
                cargarFotos(Datos.obtenerUltimoNro());
          }
         catch (SqlException ex) { txtDesc.Text = ex.Message; }
        
        
       
         
         con.Close();
         
        
    }

    protected void cargarFotos(int idFoto)
    {

        SqlConnection con1 = Datos.obtenerConexion();
        SqlCommand cmd1 = new SqlCommand("usp_cargarFotos", con1);

        
        try
        {
            if(listaBytes.Count>0) 
            {
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add(new SqlParameter("id", idFoto));
            byte[] foto = System.Text.Encoding.Unicode.GetBytes(listaBytes[0].ToString());
            cmd1.Parameters.Add(new SqlParameter("foto", foto));
            listaBytes.Remove(0);
            cmd1.ExecuteNonQuery();
            

         }
        }
        catch (SqlException ex) { txtDesc.Text = ex.Message; }
        con1.Close();

    }
    public void btnCargarFoto_Click(object sender, EventArgs e)
    {
        try{
            string carpeta=txtDir.Text+txtNroDir.Text;
            string path = "~/Fotos/" + carpeta;

        if (Directory.Exists(Server.MapPath(path))==false)
        {
        Directory.CreateDirectory(path);
        }
        else

        {cargarFoto.SaveAs(Server.MapPath(path));
        }
       
        
        
        }

        catch (Exception ex) { txtDesc.Text = ex.ToString(); }
        /*int tam;
      
        if (cargarFoto.HasFile)

        {    tam=cargarFoto.PostedFile.ContentLength;
           FileUpload1.SaveAs(Server.MapPath("~/Upload"));
             byte[] foto = new byte[tam];
             foto = cargarFoto.FileBytes;
             listaBytes.Add(foto);
             int i = listaBytes.Count;
        }*/
    }
}
