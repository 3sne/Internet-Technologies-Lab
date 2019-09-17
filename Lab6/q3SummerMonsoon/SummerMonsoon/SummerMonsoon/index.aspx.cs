using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Theme == "Monsoon")
        {
            theme_announce.InnerText = "This is Monsoon!";
        } else
        {
            theme_announce.InnerText = "This is Summer!";
        }
    }

    protected void Page_PreInit(object o, EventArgs e)
    {
        if (Session["theme"] == null) return;
        Page.Theme = Session["theme"].ToString();
    }

    protected void toggle_btn_Click(object sender, EventArgs e)
    {
        if (Page.Theme == "Monsoon") Session["theme"] = "Summer";
        else Session["theme"] = "Monsoon";
        Server.Transfer("index.aspx");
    }
}