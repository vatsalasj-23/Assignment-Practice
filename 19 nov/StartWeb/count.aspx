<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="count.aspx.cs" Inherits="startweb.count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Button ID="Button1" runat="server" Text="HiddenButton" BorderColor="Black" BorderWidth="1px" OnClick="Button1_Click" />
			<asp:Button ID="Button2" runat="server" Text="Another Page" BorderColor="Black" BorderWidth="1px" PostBackUrl="~/HiddenFields.aspx" />
			<asp:HiddenField ID="Hidden" runat="server" Value="0" />

        </div>
    </form>
</body>
</html>
