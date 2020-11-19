using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webstartdemo
{
	public partial class Webcount : System.Web.UI.Page
	{

		int COUNT;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			COUNT = int.Parse(HFCount.Value);
			COUNT += 1;
			Response.Write("Number of clicks on the button are:" + COUNT);
			HFCount.Value = COUNT.ToString();

		}

	}
}