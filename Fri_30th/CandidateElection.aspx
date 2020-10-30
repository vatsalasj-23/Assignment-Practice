<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateElection.aspx.cs" Inherits="Election.CandidateElection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 243px;
		}
		.auto-style2 {
			width: 491px;
		}
	</style>
</head>
<body style="background-color:seashell">
    <form id="form1" runat="server">
        <div>
        </div>
    	<table style="width:100%;">
			<tr>
				<td class="auto-style1">Candidate Name&nbsp;</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox1" runat="server" ForeColor="Blue" BorderColor="Black" BorderWidth="1px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
				
					<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="**Enter Your Name" ForeColor="#CC0000"></asp:RegularExpressionValidator>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style1">House</td>
				<td class="auto-style2">
					<asp:RadioButton ID="RadioButton1" runat="server" ForeColor="#CC0000" Text="Red" />
					<asp:RadioButton ID="RadioButton2" runat="server" ForeColor="#000099" Text="Blue" />
					<asp:RadioButton ID="RadioButton3" runat="server" ForeColor="#FF9933" Text="Yellow" />
					<asp:RadioButton ID="RadioButton4" runat="server" ForeColor="#006600" Text="Green" />
				</td>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style1">Class</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox3" runat="server" BorderColor="Black" BorderWidth="1px" ForeColor="#0066FF"></asp:TextBox>
				
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="**Enter Educational Qualification" ForeColor="#CC0000"></asp:RequiredFieldValidator>
				</td>
				<td>
					<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="**Should be between 6 to 12" ForeColor="#CC0000" MaximumValue="12" MinimumValue="6" ControlToValidate="TextBox3" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Email</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox2" runat="server" BorderColor="Black" BorderWidth="1px" ForeColor="Blue"></asp:TextBox>
				
					<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="**Enter Valid Email Address" ForeColor="#CC0000"></asp:RegularExpressionValidator>
				</td>
				<td>&nbsp;</td>
			</tr>
		</table>
		<asp:Button ID="Button1" runat="server" Height="22px" Text="Submit" Width="81px" BorderColor="Black" BorderWidth="1px" ForeColor="#006600" />
    	<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
