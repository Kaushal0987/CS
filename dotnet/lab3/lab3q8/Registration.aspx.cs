using System;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all fields are valid
            if (Page.IsValid)
            {
                // Display Success Message
                lblResult.Text = "Registration Successful!<br />" +
                                 "Name: " + txtName.Text + "<br />" +
                                 "Email: " + txtEmail.Text;
            }
            else
            {
                lblResult.Text = ""; // Clear success message if validation fails
            }
        }
    }
}
