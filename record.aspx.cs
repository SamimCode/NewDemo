﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class record : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=20.232.185.246,1433;Initial Catalog=demo;User ID=samimadmin;Password=Samimadmin@1234");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        //Response.Write("connection ok");

        string s = "select * from student";
        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        recordgridview.DataSource = ds;
        recordgridview.DataBind();
        con.Close();
    }
}