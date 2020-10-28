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
	public partial class CString : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//Establishing the database connection
			using (SqlConnection connect = new SqlConnection("server=IN-PG00N5QA\\MSSQLSERVER01; dataBase = model;Integrated security=true"))
			{
				SqlDataAdapter sql = new SqlDataAdapter("select * from student1",connect);//Retrieving the data from the students 
																						 //In order to retrieve the data from the dtabase we will write for a connect for an object
				DataSet dataSet = new DataSet();// to convert the data into the grid
				sql.Fill(dataSet);

				DataGRid1.DataSource = dataSet;
				DataGRid1.DataBind();

				
				//SqlDataAdapter sql2 = new SqlDataAdapter("select * from Employee", connect);//Retrieving the data from the students 
				//																		   //In order to retrieve the data from the dtabase we will write for a connect for an object
				//DataSet dataSet2 = new DataSet();// to convert the data into the grid
				//sql.Fill(dataSet2);

				//DataGRid1.DataSource = dataSet2;
				//DataGRid1.DataBind();

				//SqlDataAdapter sql3 = new SqlDataAdapter("select * from TrainSystem1", connect);//Retrieving the data from the students 
				//																		   //In order to retrieve the data from the dtabase we will write for a connect for an object
				//DataSet dataSet3 = new DataSet();// to convert the data into the grid
				//sql.Fill(dataSet3);

				//DataGRid1.DataSource = dataSet3;
				//DataGRid1.DataBind();

				//SqlDataAdapter sql4 = new SqlDataAdapter("select * from Team", connect);//Retrieving the data from the students 
				//																		   //In order to retrieve the data from the dtabase we will write for a connect for an object
				//DataSet dataSet4 = new DataSet();// to convert the data into the grid
				//sql.Fill(dataSet4);

				//DataGRid1.DataSource = dataSet4;
				//DataGRid1.DataBind();
			}

		}
	}
}