using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProBAL;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lblMessage1.Text = Resources.TollPlusResource.Name;

        if (!IsPostBack)
        {
            SearchRecords();
        }
    }

    private void SearchRecords()
    {
        DataTable table = new PersonalDetailBAL().Search(txtFirstName.Text.Trim());

        GridView1.DataSource = table;
        GridView1.DataBind();

        if (txtFirstName.Text.Trim().Length > 0)
        {
            string scriptToCall = "<script>CallMePlease('Search starting with " + txtFirstName.Text.Trim() + "')</script>";

            this.ClientScript.RegisterStartupScript(new object().GetType(),
                 "anyKey", scriptToCall);

        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SearchRecords();
    }
}