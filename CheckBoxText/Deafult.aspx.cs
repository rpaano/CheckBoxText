using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxText
{
    public partial class Deafult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CheckBoxList1.Items.Add("C");
                CheckBoxList1.Items.Add("C++");
                CheckBoxList1.Items.Add("C#");
                CheckBoxList1.Items.Add("Visual Studio 6.0");
                CheckBoxList1.Items.Add("VB.NET");
                CheckBoxList1.Items.Add("Pascal");
            }
            //or
            /*
            if (Page.IsPostBack == false)
            {
                CheckBoxList1.Items.Add("C");
                CheckBoxList1.Items.Add("C++");
                CheckBoxList1.Items.Add("C#");
                CheckBoxList1.Items.Add("Visual Studio 6.0");
                CheckBoxList1.Items.Add("VB.NET");
                CheckBoxList1.Items.Add("Pascal");
            }
            */
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            lblResult.Text = "You chose: <b>";

            foreach(ListItem listItem in CheckBoxList1.Items)
            {
                if(listItem.Selected == true)
                {
                    lblResult.Text += " <br />" + listItem.Text;
                }
            }

            lblResult.Text += "</b>";
        }
    }
}