using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace _3tierexample
{
    public partial class presentation : System.Web.UI.Page
    {
        CLSBussLayer obj = new CLSBussLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
           
         obj.InsertDetails(txtaddressid.Text,txtfirstname.Text,txtlastname.Text,txtemail.Text,txtphonenumber.Text);
            GridView1.DataSource = obj.SelectDetails();
            GridView1.DataBind();

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            obj.UpdateDetails(txtaddressid.Text, txtfirstname.Text, txtlastname.Text, txtemail.Text, txtphonenumber.Text);
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            obj.DeleteDetails(txtaddressid.Text);
        }
    }
}