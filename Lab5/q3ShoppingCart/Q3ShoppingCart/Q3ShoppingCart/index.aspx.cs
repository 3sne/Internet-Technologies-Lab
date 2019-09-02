using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{

    private readonly string coki_name = "_cart_cookie";
    private HttpCookie coki;

    protected void Page_Load(object sender, EventArgs e)
    {
        status_jumbo.Visible = false;

        //retrieve data from previous cookie if it exists
        coki = Request.Cookies.Get(coki_name);
        if (coki != null)
        {
            name_tb.Text = coki["_cust_name"];
            i1.Text = coki["_item_1"];
            i2.Text = coki["_item_2"];
            i3.Text = coki["_item_3"];
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //save cart data to cookie
        coki = new HttpCookie(coki_name);
        coki["_cust_name"] = name_tb.Text;
        coki["_item_1"] = i1.Text;
        coki["_item_2"] = i2.Text;
        coki["_item_3"] = i3.Text;
        Response.Cookies.Add(coki);
        status_jumbo.Visible = true;
    }
}