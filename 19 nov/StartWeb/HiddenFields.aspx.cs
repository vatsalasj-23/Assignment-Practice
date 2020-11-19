using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace startweb
{
	public partial class HiddenFields : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string value = Request.Form["Hidden"];
			Response.Write("The number of count is "+ value);
		}
	}
}