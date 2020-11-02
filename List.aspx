<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="DataBound.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
				<AlternatingItemTemplate>
					<tr style="background-color: #FAFAD2;color: #284775;">
						<td>
							<asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
						</td>
						<td>
							<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
						</td>
						<td>
							<asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
						</td>
					</tr>
				</AlternatingItemTemplate>
				<EditItemTemplate>
					<tr style="background-color: #FFCC66;color: #000080;">
						<td>
							<asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
							<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
						</td>
						<td>
							<asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
						</td>
						<td>
							<asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
						</td>
						<td>
							<asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
						</td>
					</tr>
				</EditItemTemplate>
				<EmptyDataTemplate>
					<table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
						<tr>
							<td>No data was returned.</td>
						</tr>
					</table>
				</EmptyDataTemplate>
				<InsertItemTemplate>
					<tr style="">
						<td>
							<asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
							<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
						</td>
						<td>
							<asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
						</td>
						<td>
							<asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
						</td>
						<td>
							<asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
						</td>
					</tr>
				</InsertItemTemplate>
				<ItemTemplate>
					<tr style="background-color: #FFFBD6;color: #333333;">
						<td>
							<asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
						</td>
						<td>
							<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
						</td>
						<td>
							<asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
						</td>
					</tr>
				</ItemTemplate>
				<LayoutTemplate>
					<table runat="server">
						<tr runat="server">
							<td runat="server">
								<table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
									<tr runat="server" style="background-color: #FFFBD6;color: #333333;">
										<th runat="server">Id</th>
										<th runat="server">Name</th>
										<th runat="server">Gender</th>
									</tr>
									<tr id="itemPlaceholder" runat="server">
									</tr>
								</table>
							</td>
						</tr>
						<tr runat="server">
							<td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;"></td>
						</tr>
					</table>
				</LayoutTemplate>
				<SelectedItemTemplate>
					<tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
						<td>
							<asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
						</td>
						<td>
							<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
						</td>
						<td>
							<asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
						</td>
					</tr>
				</SelectedItemTemplate>
			</asp:ListView>
			<br />
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
