using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuestionNO2
{
    public partial class Chocolates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs m)
        {
            if (!Page.IsPostBack)
            {



                string[] str = new string[] { "dairy milk", "DarkChocolate", "kit kat", "munch chocolate" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs m)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".JFIF";
            if (DropDownList1.Items.FindByText("dairy milk").Selected == true)
            {
                Label.Text = "Price: 550/-";
            }
            else if (DropDownList1.Items.FindByText("DarkChocolate").Selected == true)
            {
                Label.Text = "Price: 999/-";
            }
            else if (DropDownList1.Items.FindByText("kit kat").Selected == true)
            {
                Label.Text = "Price: 450/-";
            }

            else
            {
                Label.Text = "Price: 250/-";
            }
        }
    }
}