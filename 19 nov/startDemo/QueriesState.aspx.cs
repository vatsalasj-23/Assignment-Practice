using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Queries
{
	public partial class QueriesState : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				TextBox2.Focus();//is used to keep the cursor within the textbox field
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			if (TextBox2.Text == "admin" && TextBox3.Text == "admin")
			{
				Response.Redirect("HomePage.aspx?UserName=" + TextBox2.Text+"&Password="+TextBox3.Text);
				Response.Write("Login successful!!");
				Response.Redirect("HomePage.aspx");
				
			}
			else
			{
				LblStatus.Text = "Invalid user credentials,Login failed";
			}
		}

		protected void Button2_Click(object sender, EventArgs e)
		{

		}
	}
}