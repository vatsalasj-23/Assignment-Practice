<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueriesState.aspx.cs" Inherits="Queries.QueriesState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	
	<style type="text/css">
		.auto-style4 {
			width: 67%;
		}
		.auto-style6 {
			width: 58%;
		}
		.auto-style7 {
			width: 277px;
		}
	</style>
	
</head>
<body>
    <form id="form1" runat="server">
       
		
    	<table class="auto-style4" border="1">
			<caption>Login Form</caption>
			<tr>
				<td class="auto-style6">
					<asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
				</td>
				<td class="auto-style7">
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
				</td>
				<td></td>
			</tr>
			<tr>
				<td class="auto-style6">
					<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
				</td>
				<td class="auto-style7">
					<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style6">
					<asp:Button ID="Button1" runat="server" Text="Login" Width="89px" OnClick="Button1_Click" />&nbsp 
					<asp:Button ID="Button2" runat="server" Text="Reset" Width="98px" OnClick="Button2_Click" />
				</td>
				<td class="auto-style7">&nbsp;</td>
				<td></td>
			</tr>
			<td colspan="2">
				<asp:Label ID="LblStatus" runat="server"></asp:Label>

			</td>
		</table>
		
    </form>
</body>
</html>
