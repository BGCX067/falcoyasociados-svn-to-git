<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MonoAmbiente.aspx.cs" Inherits="MonoAmbiente" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="Form1" runat="server"> 
    <table style="width: 615px" id="TABLE1" onclick="return TABLE1_onclick()">

        <tr>
            <td style="width: 14px; height: 19px">
                <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Dirección:" Width="76px"></asp:Label></td>
            <td style="width: 100px; height: 19px">
                <asp:TextBox ID="txtDir" runat="server" Enabled="False" Width="158px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 14px; height: 134px;">
                <asp:Label ID="Label2" runat="server" Font-Names="Calibri" Font-Size="13px" ForeColor="WhiteSmoke"
                    Text="Descripción:" Width="75px"></asp:Label></td>
            <td style="width: 100px; height: 134px;">
                <asp:TextBox ID="txtDesc" runat="server" Height="113px" Width="452px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="width: 588px; height: 318px">

 <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"  style="width: 584px; height: 313px"> 
			
			<param name="FlashVars" value="ImageList=gallery/images.xml"/> 
		    <param name="movie" value="gallery/imgallery.swf"/> 
            <param name="quality" value="high"/> 
            <param name="bgcolor" value="#1d1917"/>
</object>
</div>
                <img id="imagen1" src="" style="width: 119px" runat="server" /></td>
        </tr>
        <tr>
            <td style="width: 14px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    
    
    </form> 
</asp:Content>

