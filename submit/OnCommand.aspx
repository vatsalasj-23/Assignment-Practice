<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OnCommand.aspx.cs" Inherits="LinkButton.OnCommand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>OnCommand Link Button</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:LinkButton ID="LinkButton1" runat="server" OnCommand="LinkButton1_Command" Text="OrderItems1" CommandName="dxc texchnology" CommandArgument="order1" OnClick="LinkButton1_Click"></asp:LinkButton>
			<%--<asp:LinkButton ID="LinkButton2" runat="server" OnCommand="LinkButton2_Command" Text="OrderItems2" CommandName="dxc texchnology" CommandArgument="order2" OnClick="LinkButton2_Click"></asp:LinkButton>--%>

        </div>
		<asp:Label ID="label1" runat="server"></asp:Label>
    </form>
</body>
</html>
