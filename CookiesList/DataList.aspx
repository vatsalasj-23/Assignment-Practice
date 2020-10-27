<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="Cookies.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<p>The datalist shows data of the datatable</p>

			<asp:DataList ID="datalist1" runat="server" Height="231px" Width="518px">
				<ItemTemplate>
					<asp:Table ID="TABLE1" runat="server" CellPadding="2" CellSpacing="0" BorderStyle="Groove" style="width:200px ;height:100px" />
					<tr>
						<td>
							<strong>ID</strong> <span class ="city"><%# Eval("ID") %></span><br/>
							<strong>name</strong><span class="PostalAddress"><%# Eval("Name") %></span><br />
							<strong>Email</strong><span class="Country"><%# Eval("Email") %></span><br />
						</td>
					</tr>
				</ItemTemplate>
			</asp:DataList>
        </div>
    </form>
</body>
</html>
