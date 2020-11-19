<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webcount.aspx.cs" Inherits="webstartdemo.Webcount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
			<asp:Button ID="Button3" runat="server" Text="OpenAnotherWebpage" PostBackUrl="~/GetHiddenFieldValues.aspx" />			
			<asp:HiddenField ID="HFCount" runat="server" Value="0" />
			
        </div>
    </form>
</body>
</html>
