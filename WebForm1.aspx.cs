using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ajax_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(!IsPostBack)
            {
                string query = "selected country_id, country_name from country";
                BinddropDownList(ddlcountries, query, "country_name", "country_id", "Select country");
                ddlstate.Enabled = false;
                ddlCity.Enabled = false;
                ddlstate.Item.Insert()
            }

        }

        private void BinddropDownList(DropDownList ddl, string text, string value,string defaulttext)
        {
            string constring = ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            using(SqlDataAdapter sda= new SqlDataAdapter())
            {
                cmd
            }
        }
    }
}