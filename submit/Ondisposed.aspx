<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ondisposed.aspx.cs" Inherits="LinkButton.LinkAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Link Button OnDisposal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:LinkButton ID="LinkButton1" runat="server" OnDisposed="LinkButton1_Disposed">Vatsala SJ</asp:LinkButton>
			<asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
