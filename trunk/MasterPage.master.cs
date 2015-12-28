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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

       actualizarAlquiler(UltimasNoticias.actualizarAlquiler(), UltimasNoticias.fechaAlquiler());
       actualizarVentas(UltimasNoticias.actualizarVentas(),UltimasNoticias.fechaVentas());
    }

    public  void actualizarVentas(String venta, String fecha)
    {  
        lblFechaVenta.Text = fecha; 
        lblVenta.Text = venta;
    }

    public  void actualizarAlquiler(String alquiler, String fecha)
    {
        lblFechaAlq.Text = fecha;
        lblAlquiler.Text = alquiler;
    }
 
}
