using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProBAL;

namespace ProNTier
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            bool isAdult = false;
            if (!string.IsNullOrWhiteSpace(Request.QueryString["get"]))
            {
                if (Request.QueryString["get"].Equals("adults"))
                {
                    isAdult = true;
                }
            }

            DataView view = new PersonalDetailBAL().LoadAll(isAdult);

            GridView1.DataSource = view;
            GridView1.DataBind();
        }
    }
}