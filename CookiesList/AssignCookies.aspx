<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssignCookies.aspx.cs" Inherits="Cookies.AssignCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DXC Technology</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<p>This data are stored in database!!</p>
			<asp:DataList ID="DataList1" runat="server" Height="213px" Width="312px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
				<ItemTemplate>
					<asp:Table ID="Table1" runat="server" CellPadding="2" CellSpacing="0" BorderStyle="Groove" style="width:200px; Height:100px" />
					<tr>
						<td>
							<strong>FirstName</strong><span class="city"><%#Eval ("FirstName") %></span><br /><strong>LastName</strong><span class="PostalAddress"><%#Eval ("LastName") %></span><br /><strong>Designation</strong><span class="Country"><%#Eval ("Designation") %></span><br /><strong>Location</strong><span class="Company"><%#Eval ("Location") %></span><br /><strong>Country</strong><span class="Dream"><%#Eval ("Country") %></span><br /></td>
					</tr>
				</ItemTemplate>
			</asp:DataList>

        </div>
    </form>
</body>
</html>
