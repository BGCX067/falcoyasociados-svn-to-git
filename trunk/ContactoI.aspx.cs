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

public partial class NegociosInmobiliarios_Contacto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        string nombreAsunto = txtApe.Text +" "+ txtAsunto.Text;
        EnviarMail.SendMail(txtMail.Text, nombreAsunto, txtMsj.Text);
        limpiarCampos();



    }
    private void limpiarCampos()
    {
        txtApe.Text = "";
        txtAsunto.Text = "";
        txtMail.Text = "";
        txtMsj.Text = "";
    }
}
