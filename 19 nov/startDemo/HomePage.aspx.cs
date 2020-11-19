using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Queries
{
	public partial class HomePage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string name = Request.QueryString["UserName"];
			//string Name = Request.QueryString["TextBox2"];

			Response.Write("Hello"+"Welcome to our site ");
		}
	}
}