<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AgregarInmueble.aspx.cs" Inherits="AgregarInmueble" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <form id="Form1" runat="server">  
    <br />
    <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Font-Size="16px" ForeColor="WhiteSmoke"
        Text="Cargar Nuevo Inmueble"></asp:Label><br />
    <hr />
    <br />
    <table style="width: 629px; height: 179px">
        <tr>
            <td style="width: 21px; height: 12px;">
                <asp:Label ID="Label2" runat="server" Text="Estado:" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"></asp:Label></td>
            <td style="width: 100px; height: 12px;">
                <asp:DropDownList ID="ddlTipo" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 21px; height: 12px">
                <asp:Label ID="Label6" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Habitaciones:"></asp:Label></td>
            <td style="width: 100px; height: 12px">
                <asp:DropDownList ID="ddlHab" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 21px">
                <asp:Label ID="Label3" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Dirección:"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtDir" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDir"
                    Display="Dynamic" ErrorMessage="Debe ingresar la dirección">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 21px">
                <asp:Label ID="Label4" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Nro:"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtNroDir" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNroDir"
                    ErrorMessage="Debe ingresar el número">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 21px">
                <asp:Label ID="Label7" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Ciudad:"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddlCiudad" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 21px; height: 171px;">
                <asp:Label ID="Label5" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Descripción:"></asp:Label></td>
            <td style="width: 100px; height: 171px;">
                <asp:TextBox ID="txtDesc" runat="server" Height="161px" Width="411px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 21px; height: 28px">
                <asp:Label ID="Label8" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Cargar Fotos:" Width="84px"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:FileUpload ID="cargarFoto" runat="server" Width="264px"></asp:FileUpload>
                <asp:Button ID="btnCargarFoto" runat="server" Height="21px" OnClick="btnCargarFoto_Click"
                    Text="Cargar Fotos" Width="122px" /></td>
        </tr>
        <tr>
            <td style="height: 53px; text-align: center;" colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Names="Calibri"
                    Font-Size="Smaller" Width="334px" />
                <asp:Button ID="btnCargar" runat="server" Height="26px" Text="Cargar" Width="100px" OnClick="btnCargar_Click" /></td>
        </tr>
    </table>
     </form>  
</asp:Content>

