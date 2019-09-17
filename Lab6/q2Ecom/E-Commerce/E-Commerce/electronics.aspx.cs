using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class electronics : System.Web.UI.Page
{
    private readonly string[] category_names = { "Choose", "Mobiles", "Laptops", "Printers" };
    private readonly string[] mobiles = { "Samsung", "OnePlus", "Xiaomi", "Nokia" };
    private readonly string[] laps = { "HP", "Dell", "MSI", "Sager"};
    private readonly string[] printers = { "Epson", "HP", "Canon", "Xerox" };

    protected void Page_Load(object sender, EventArgs e)
    {
        answers.Visible = false;
        if (IsPostBack) return;
        foreach (string s in category_names) DropDownList1.Items.Add(new ListItem(s));
    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ind = DropDownList1.SelectedIndex;
        if (ind == 0 || ind >= 4)
        {
            answers.Visible = false;
            return;
        }
        answers.Visible = true;
        string html_const = "";
        string[] cat_local = { };
        if (ind == 1) cat_local = mobiles;
        if (ind == 2) cat_local = laps;
        if (ind == 3) cat_local = printers;
        foreach (string s in cat_local) html_const += "<li class=\"list-group-item\">" + s + "</li>";
        li_pool.InnerHtml = html_const;
    }
}