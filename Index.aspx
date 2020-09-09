<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="JSONbase.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>WELLCOME PIERO</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblNombre" runat="server" Text="Nombre"/>
            <asp:TextBox ID="txtNombre" runat="server"/><br/>

            <asp:Label ID="LblApellido" runat="server" Text="Apellido"/>
            <asp:TextBox ID="txtApellido" runat="server"/><br/>

            <asp:Label ID="LblEdad" runat="server" Text="Edad"/>
            <asp:TextBox ID="txtEdad" runat="server"/><br/>

            <asp:Label ID="LblCorreo" runat="server" Text="Correo"/>
            <asp:TextBox ID="txtCorreo" runat="server"/><br/>

            <asp:Label ID="LblNumero" runat="server" Text="Número"/> 
            <asp:TextBox ID="txtNumero" runat="server"/><br/>

            <asp:Button ID="btnAgregarPersona" runat="server" Text="Agregar Persona" OnClick="btnAgregarPersona_Click" />
            <br/>
            <asp:ListBox ID="lblPersona" runat="server"></asp:ListBox>
            <br />
            <asp:Button ID="btnJSON" runat="server" Text="Generar JSON" OnClick="btnJSON_Click" />
        </div>
    </form>
</body>
</html>
