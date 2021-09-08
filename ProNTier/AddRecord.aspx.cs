using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProBAL;
using ProBE;

namespace ProNTier
{
    public partial class AddRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PersonalDetail person = new PersonalDetail()
            {
                 Active = bool.Parse(radioActive.SelectedValue),
                  Age = int.Parse(txtAge.Text.Trim()),
                   FirstName = txtFirstName.Text.Trim(),
                   LastName = txtLastName.Text.Trim()
            };

            var result = new PersonalDetailBAL().AddRecord(person);

            if (result > 0)
            {
                lblMessage.Text = "Record added successfully !";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                Server.Transfer("default.aspx");
                // Response.Redirect("default.aspx");

            }
            else
            {
                lblMessage.Text = "Record didn't add successfully !";
                lblMessage.ForeColor = System.Drawing.Color.Brown;
            }

        }
    }
}