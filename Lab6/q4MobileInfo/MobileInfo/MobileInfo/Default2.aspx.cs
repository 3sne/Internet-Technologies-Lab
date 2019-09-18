using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    private string currSelection;
    public string CurrSelection
    {
        set
        {
            this.currSelection = Session["phone"].ToString();
        }
        get
        {
            if (Session["phone"] != null)
            {
                return Session["phone"].ToString();
            }
            else
            {
                return "none";
            }
        }
    }

    public Dictionary<string, string[]> mob_data;
    private string[] op3 = { "3300 mAH", "5.5" };
    private string[] ipx = { "3000 mAH", "5.4" };
    private string[] gp3 = { "4200 mAH", "6.2" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        mob_data.Add("OnePlus 3", op3);
        mob_data.Add("iPhone X", ipx);
        mob_data.Add("Google Pixel 3", gp3);
        if (this.CurrSelection == "none")
        {
            lp_ans.InnerText = "No Phone Selected";
            // no valid selection
        } else
        {
            lp_ans.InnerText = CurrSelection;
            pname.InnerText = CurrSelection;
            pbattery.InnerText = mob_data[CurrSelection][0];
            pscreen.InnerText = mob_data[CurrSelection][1];
            // mob_data[CurrSelection];
        }
    }
}