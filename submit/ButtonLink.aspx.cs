using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkButton
{
	public partial class ButtonLink : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void label1_Click(object sender, EventArgs e)
		{

		}

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			label1.Text = "Welcome to Facebook";
			label1.Text = "Welcome to Instagram";
			label1.Text = "Welcome to DRDO";
			label1.Text = "Welcome to You tube";
			label1.Text = "Welcome to Skype";
			
			
		}
	}
}