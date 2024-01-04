using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonCalculateAdd_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int a = Convert.ToInt32(TextBoxA.Text);
            int b = Convert.ToInt32(TextBoxB.Text);
            ResultLabel.Text = "Output of WebService: " + webService.Add(a,b).ToString();
        }
        protected void ButtonCalculateSubtract_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int a = Convert.ToInt32(TextBoxA.Text);
            int b = Convert.ToInt32(TextBoxB.Text);
            ResultLabel.Text = "Output of WebService: " + webService.Subtract(a, b).ToString();
        }
        protected void ButtonCalculateMultiphy_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int a = Convert.ToInt32(TextBoxA.Text);
            int b = Convert.ToInt32(TextBoxB.Text);
            ResultLabel.Text = "Output of WebService: " + webService.Multiply(a, b).ToString();
        }
        protected void ButtonCalculateDivide_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int a = Convert.ToInt32(TextBoxA.Text);
            int b = Convert.ToInt32(TextBoxB.Text);
            ResultLabel.Text = "Output of WebService: " + webService.Divide(a, b).ToString();
        }
    }
}