using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkButton
{
	public partial class OnCommand : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void LinkButton1_Command(object sender, CommandEventArgs e)
		{
			label1.Text = "Welcome to Instagram  " + e.CommandName + "  item  " + e.CommandArgument;
		}

		

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			label1.Text = "Welcome to Instagram";
		}

		protected void LinkButton2_Click(object sender, EventArgs e)
		{
	
		}
	}
}