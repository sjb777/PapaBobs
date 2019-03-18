using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDays.Items.Add("Monday");
                ddlDays.Items.Add("Tuesday");
                ddlDays.Items.Add("Wednesday");

                rbList.Items.Add("Workday");
                rbList.Items.Add("Non-Workday");

                chList.Items.Add("Morning");
                chList.Items.Add("Afternoon");

            }

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Hey "+txtName.Text;

            string chosenDay = ddlDays.SelectedItem.ToString();

            lblDisplay.Text += "<br/> You have chosen " + chosenDay;
            List<String> times = new List<String>();

            foreach(ListItem item in chList.Items)
            {
                if (item.Selected)
                {
                lblDisplay.Text += "<br/>";
                lblDisplay.Text += item.Text;
                }

            }
            lblDisplay.Text += "<br/>";
        }

        protected void ddlDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}