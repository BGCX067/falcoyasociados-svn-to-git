<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactoI.aspx.cs" Inherits="NegociosInmobiliarios_Contacto" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">

</script>
<form id="Form1" runat="server">  
    <table style="width: 618px">
        <tr>
            <td style="width: 100px; text-align: left">
                <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Font-Size="14px" ForeColor="WhiteSmoke"
                    Text="Apellido y Nombre:" Width="119px"></asp:Label>
                <br />
                <asp:TextBox ID="txtApe" runat="server" Font-Italic="False" Font-Size="13px" Width="290px" Font-Names="Calibri"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtApe"
                    Display="Dynamic" ErrorMessage="Debe Ingresar su Apellido y Nombre">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: left">
                <asp:Label ID="Label2" runat="server" Font-Names="Calibri" Font-Size="14px" ForeColor="WhiteSmoke"
                    Text="Su Email:"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <br />
                <asp:TextBox ID="txtMail" runat="server" Width="291px" Font-Names="Calibri" Font-Size="13px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMail"
                    Display="Dynamic" ErrorMessage="Debe ingresar un email">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMail"
                    Display="Dynamic" ErrorMessage="Su e-mail no está escrito correctamente" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 26px; text-align: left">
                <asp:Label ID="Label3" runat="server" Font-Names="Calibri" Font-Size="14px" ForeColor="WhiteSmoke"
                    Text="Asunto:"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <br />
                <asp:TextBox ID="txtAsunto" runat="server" Font-Bold="False" Font-Size="13px" Width="289px" Font-Names="Calibri"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAsunto" Display="Dynamic"
                    ErrorMessage="Debe ingresar el asunto">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: left">
                <asp:Label ID="Label4" runat="server" Font-Names="Calibri" Font-Size="14px" ForeColor="WhiteSmoke"
                    Text="Mensaje:"></asp:Label>
                <asp:TextBox ID="txtMsj" runat="server" Height="199px" Width="587px" Font-Names="Calibri" Font-Size="13px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMsj"
                    Display="Dynamic" ErrorMessage="Debe ingresar el texto correspondiente al mensaje.">*</asp:RequiredFieldValidator>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 55px; text-align: left">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Names="Calibri"
                    Font-Size="Small" Width="605px" />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:Button ID="btnEnviar"
                    runat="server" OnClick="btnEnviar_Click" Text="Enviar Mensaje" /></td>
        </tr>
    </table>
        </form> 
        
</asp:Content>




