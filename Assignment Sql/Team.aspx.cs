using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionString
{
	public partial class Team : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			using (SqlConnection connect = new SqlConnection("server=IN-PG00N5QA\\MSSQLSERVER01; dataBase = model;Integrated security=true"))
			{
				SqlDataAdapter sql = new SqlDataAdapter("select * from Team", connect);//Retrieving the data from the students 
				//																		   //In order to retrieve the data from the dtabase we will write for a connect for an object
				DataSet dataSet = new DataSet();// to convert the data into the grid
				sql.Fill(dataSet);

				datagrid1.DataSource = dataSet;
				datagrid1.DataBind();
			}
		}

		
	}
}