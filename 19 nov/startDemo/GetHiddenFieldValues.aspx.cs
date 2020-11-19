using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webstartdemo
{
	public partial class GetHiddenFieldValues : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string value = Request.Form["HFCount"];
			Response.Write("Your current Hit Count is " + value);
		}
	}
}