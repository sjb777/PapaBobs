using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PapaBobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rbSize.Items.Add("Baby Bob Size (10\") - £10");
                rbSize.Items.Add("Mama Bob Size (13\") - £13");
                rbSize.Items.Add("Papa Bob Size (16\") - £16");

                rbCrust.Items.Add("Thin Crust");
                rbCrust.Items.Add("Deep Dish(+£2.00)");

                chTopping.Items.Add("Pepperoni(+£1.50)");
                chTopping.Items.Add("Onions(+£0.75)");
                chTopping.Items.Add("Green Peppers(+£0.50)");
                chTopping.Items.Add("Red Peppers(+£0.75)");
                chTopping.Items.Add("Anchovies(+£2.00)");
            }
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            string chosenSize = rbSize.SelectedItem.ToString();
            string chosenCrust = rbCrust.SelectedItem.ToString();
            string chosenTopping = chTopping.SelectedItem.ToString();
            double total = 0.0;

            if (chosenSize.Equals("Baby Bob Size (10\") - £10"))
            {
                total = total + 10;
            }
            else if (chosenSize.Equals("Mama Bob Size (13\") - £13"))
            {
                total = total + 13;
            }
            else if (chosenSize.Equals("Papa Bob Size (16\") - £16"))
            {
                total = total + 16;
            }

            if (chosenCrust.Equals("Deep Dish(+£2.00)"))
            {
                total = total + 2;
            }

            if (chosenTopping.Equals("Pepperoni(+£1.50)"))
            {
                total = total + 1.5;
            }
            else if (chosenTopping.Equals("Onions(+£0.75)"))
            {
                total = total + 0.75;
            }
            else if (chosenTopping.Equals("Green Peppers(+£0.50)"))
            {
                total = total + 0.5;
            }
            else if (chosenTopping.Equals("Red Peppers(+£0.75)"))
            {
                total = total + 0.75;
            }
            else if (chosenTopping.Equals("Anchovies(+£2.00)"))
            {
                total = total + 2;
            }
            

            List <String> times = new List<String>();

            foreach (ListItem item in rbSize.Items)
            {
                if (item.Selected)
                {
                    lblOrder.Text += "<br/>";
                    lblOrder.Text += item.Text;
                }

            }

            foreach (ListItem item in rbCrust.Items)
            {
                if (item.Selected)
                {
                    lblOrder.Text += "<br/>";
                    lblOrder.Text += item.Text;
                }

            }

            lblTotal.Text = "Total: " + total.ToString("c2");

        }
    }
}