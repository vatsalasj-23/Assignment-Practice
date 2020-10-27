using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Cookies
{
	public partial class DataList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataTable table = new DataTable();
			table.Columns.Add("ID");
			table.Columns.Add("NAME");
			table.Columns.Add("Email");

			table.Rows.Add(101, "Sachin Tendulkar", "sachint@hotmail.com");
			table.Rows.Add(102, "vatsala SJ", "vatsalasj@hotmail.com");
			table.Rows.Add(103, "Darshan SJ", "darshansj@hotmail.com");
			table.Rows.Add(103, "lalitha", "lalitha@hotmail.com");
			table.Rows.Add(103, "Ganga", "ganga1234@hotmail.com");

			datalist1.DataSource = table;
			datalist1.DataBind();

		}
	}
}