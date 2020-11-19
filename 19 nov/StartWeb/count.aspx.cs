using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace startweb
{
	public partial class count : System.Web.UI.Page
	{
		int Count;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Count = int.Parse(Hidden.Value);
			Count += 1;
			Response.Write("The no of webcounts are: " + Count);
			Hidden.Value = Count.ToString();

		}
	}
}