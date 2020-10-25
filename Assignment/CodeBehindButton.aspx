<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeBehindButton.aspx.cs" Inherits="CodeBehindButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="Label1" runat="server" Text="FULLNAME"  ForeColor="SteelBlue" Font-Bold="true"></asp:Label>
			<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="24px" Width="133px" ></asp:TextBox><br/><br/>

			<asp:Label ID="Label2" runat="server" Text="Aadhar Card"  ForeColor="SteelBlue" Font-Bold="true"></asp:Label>
			<asp:TextBox ID="TextBox2" runat="server" Height="22px" OnTextChanged="TextBox2_TextChanged" Width="130px" ></asp:TextBox><br/><br/>

			
			<asp:Button ID="Button1" runat="server" Text="Click me" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
