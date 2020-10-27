using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Cookies
{
	public partial class AssignCookies : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataTable data = new DataTable();
			data.Columns.Add("FirstName");
			data.Columns.Add("LastName");
			data.Columns.Add("Designation");
			data.Columns.Add("Location");
			data.Columns.Add("Country");

			data.Rows.Add("Radha", "Krishna", "IT", "Chitradurga", "India");
			data.Rows.Add("Laxmi", "Srinivasa", "HR", "Chittor", "India");
			data.Rows.Add("Shankara", "Narayana", "Sales", "Davanagere", "India");
			data.Rows.Add("Vatsala", "SJ", "Engineer", "Telangana", "India");
			data.Rows.Add("Darshan","SJ","Manager","TamilNadu","India");

			DataList1.DataSource = data;
			DataBind();
		}

		protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}