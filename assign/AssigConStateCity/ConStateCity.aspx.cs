using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace AssigConStateCity
{
    public partial class ConStateCity : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());

        public void Country()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Country_ID,Country_Name from CountryTab", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            DDL1_Country.DataSource = dr;
       
            DDL1_Country.Items.Add("Select Country");
            DDL1_Country.DataTextField = "Country_Name";
            DDL1_Country.DataValueField = "Country_ID";
            DDL1_Country.DataBind();
            cn.Close();
        }
        public void State()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select State_ID,State_Name from StateTab where Country_ID='" + DDL1_Country.SelectedValue + "'", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            DDL2_State.DataSource = dr;
            DDL2_State.Items.Add("Select State");
            DDL2_State.DataTextField = "State_Name";
            DDL2_State.DataValueField = "State_ID";
            DDL2_State.DataBind();
            cn.Close();
        }

        public void City()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select City_ID,City_Name from CityTab where State_ID='" + DDL2_State.SelectedValue + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DDL3_City.DataSource = dr;
            DDL3_City.Items.Add("Select City");
            DDL3_City.DataTextField = "City_Name";
            DDL3_City.DataValueField = "City_ID";
            DDL3_City.DataBind();
            cn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Country();
            }
        }
        protected void DDL1_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            State();
        }

        protected void DDL2_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            City();
        }

        protected void DDL3_City_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}