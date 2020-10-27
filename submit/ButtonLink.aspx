<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonLink.aspx.cs" Inherits="LinkButton.ButtonLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Link Button</title>
</head>
<body>
	<%-- syntax of link button--%>
	<asp:LinkButton ID="string" OnClick="click event handler" OnClientClick="stirng"
		 OnCommand="Command this line" OnDataBinding="binding the data" OnDisposed="Dispose event Handler"
		 OnInit="vatsalasj" OnLoad="loads the page" OnPreRender="pre reads the value" OnUnload="Unloading the page"
	  runat="server" PostBackUrl="www.dxctechnology.com"></asp:LinkButton>

    <form id="form1" runat="server">
		<h3>It is a hyper Link style button</h3>
        <div><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">facebook></asp:LinkButton></div><br /><br />
		<div><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton1_Click">Instagram></asp:LinkButton></div><br /><br />
		<div><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton1_Click">DRDO></asp:LinkButton></div><br /><br />
		<div><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton1_Click">You Tube></asp:LinkButton></div><br /><br />
		<div><asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton1_Click">Skype></asp:LinkButton></div><br /><br />

		<p><asp:Label ID="label1" runat="server" /></p>
		<asp:HyperLink ID="hypertext" runat="server" NavigateUrl="https//www.dxctechnology.com" />
    </form>
</body>
</html>
