<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentReg.aspx.cs" Inherits="Student.StudentReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 197px;
		}
		.auto-style2 {
			width: 526px;
		}
		.auto-style3 {
			width: 197px;
			height: 26px;
		}
		.auto-style4 {
			width: 526px;
			height: 26px;
		}
		.auto-style5 {
			height: 26px;
			width: 255px;
		}
		.auto-style6 {
			width: 197px;
			height: 45px;
		}
		.auto-style7 {
			width: 526px;
			height: 45px;
		}
		.auto-style8 {
			height: 45px;
			width: 255px;
		}
		.auto-style9 {
			width: 97%;
		}
		.auto-style10 {
			width: 255px;
		}
	</style>
</head>
<body style="background-color:bisque">
    <form id="form1" runat="server">
        <div>
        </div>
    	<table class="auto-style9">
			<tr>
				<td class="auto-style1">FirstName</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter First Name" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style10">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style1">LastName</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
				    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Last Name" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style10"></td>
			</tr>
			<tr>
				<td class="auto-style3">Father&#39;s Name</td>
				<td class="auto-style4">
					<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Father Name" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style5"></td>
			</tr>
			<tr>
				<td class="auto-style6">Mother&#39;s Name</td>
				<td class="auto-style7">
					<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Mother Name" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style8"></td>
			</tr>
			<tr>
				<td class="auto-style1">Gender</td>
				<td class="auto-style2">
					<asp:RadioButton ID="RadioButton3" runat="server" ForeColor="Red" Text="Male" />
					<asp:RadioButton ID="RadioButton4" runat="server" ForeColor="#009933" Text="Female" />
					<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Select Gender" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style10">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style1">Aggregate</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter Aggregate % " ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style10">
					<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Aggregate % should be &gt; than 60" ForeColor="Red" MaximumValue="100" MinimumValue="59" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Course</td>
				<td class="auto-style2">
					<asp:RadioButton ID="RadioButton1" runat="server" ControlToValidate="RadioButton1" OnCheckedChanged="RadioButton1_CheckedChanged" Text="CSE" />
					<asp:CheckBox ID="CheckBox1" runat="server" Text="Computer Operating Architecture" />
					<asp:CheckBox ID="CheckBox2" runat="server" Text="Data Structures" />
					<asp:CheckBox ID="CheckBox3" runat="server" Text="Computer Network" />
					<asp:RadioButton ID="RadioButton2" runat="server" ControlToValidate="RadioButton2" OnCheckedChanged="RadioButton2_CheckedChanged" Text="ECE" />
					<asp:CheckBox ID="CheckBox4" runat="server" Text="MicroController" />
					<asp:CheckBox ID="CheckBox5" runat="server" Text="Logic Design" />
					<asp:CheckBox ID="CheckBox6" runat="server" Text="Analog Communications" />
				</td>
				<td class="auto-style10">&nbsp;</td>
			</tr>
		</table>
		<asp:Button ID="Button1" runat="server" BorderColor="Black" BorderWidth="1px" ForeColor="#0066FF" Height="26px" Text="Submit" Width="99px" />
    	<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
