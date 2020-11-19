using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Queries
{
	public partial class Queries : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				TextBox1.Focus();
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			if (TextBox1.Text == "UserName" && TextBox2.Text == "Password")
			{
				Response.Redirect("AddPage.aspx?UserName=" + TextBox1.Text + "Password=" + TextBox2.Text);
				Response.Write("Login successfully");
				Response.Write("AddPage.aspx");
			}
			else
			{
				Status.Text = "Invalid Username and Password";
	           
			}

		}
	}
}