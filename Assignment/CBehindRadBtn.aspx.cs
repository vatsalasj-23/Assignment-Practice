﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CBehindRadBtn : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}



	protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		Response.Write("This is red in color");
	}

	protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		Response.Write("This is blue in color");
	}

	protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		Response.Write("This is green in color");
	}
}