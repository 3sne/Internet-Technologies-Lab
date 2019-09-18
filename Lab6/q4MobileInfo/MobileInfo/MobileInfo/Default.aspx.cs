using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    private readonly string[] phoneList = { "OnePlus 3", "iPhone X", "Google Pixel 3" };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        foreach (string s in phoneList) ddl1.Items.Add(new ListItem(s));
    }

    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddl1.SelectedIndex == 0) return;
        Session["phone"] = ddl1.SelectedItem.Text;
    }
}