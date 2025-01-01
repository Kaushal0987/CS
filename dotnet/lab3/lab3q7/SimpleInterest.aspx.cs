using System;

namespace WebApplication1
{
    public partial class SimpleInterest : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse inputs
                double principal = double.Parse(txtPrincipal.Text);
                double rate = double.Parse(txtRate.Text);
                double time = double.Parse(txtTime.Text);

                // Calculate Simple Interest
                double interest = (principal * rate * time) / 100;

                // Display result
                lblResult.Text = "The Simple Interest is: " + interest.ToString("F2");
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: Please enter valid numbers.";
            }
        }
    }
}
