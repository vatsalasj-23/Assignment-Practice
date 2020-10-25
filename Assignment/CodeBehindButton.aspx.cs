using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CodeBehindButton : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		TextBox1.Focus();
		TextBox2.Focus();
	}

	protected void TextBox1_TextChanged(object sender, EventArgs e)
	{
		string V = "Enter your fullname"+"    " + TextBox1.Text;
		Response.Write(V);
	}

	protected void TextBox2_TextChanged(object sender, EventArgs e)
	{
		string B = "Enter your Aadhar Card"+"    " + TextBox2.Text;
		Response.Write(B);

	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		Response.Write("     "+"Registered Successfully");
	}
}