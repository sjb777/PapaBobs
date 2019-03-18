using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ChallengeDaysBetweenDates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            DateTime date1 = Calendar1.SelectedDate;
            DateTime date2 = Calendar2.SelectedDate;
            int days;

            if (date1 < date2)
            {
                 days = (date2 - date1).Days;
            }
            else
            {
                 days = (date1 - date2).Days;
            }

            lblAnswer.Text = "The number of days between is " + days;
        }
    }
}