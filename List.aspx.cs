using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
	

namespace DataBound
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from student", con);
			SqlDataReader rd = cmd.ExecuteReader();
			ListView1.DataSource = rd;
			ListView1.DataBind();
			con.Close();


		}

		protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}