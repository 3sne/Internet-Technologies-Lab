using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    private readonly string[] empList = { "E1", "E2", "E3" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        foreach (string s in empList)
            DropDownList1.Items.Add(new ListItem(s));
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string doj = TextBox2.Text;
        DateTime rDoj;
        if ( !DateTime.TryParse(doj, out rDoj)) {
            eligible_answer.Text ="Enter Valid Date!";
            return;
        }
        DateTime rNow = DateTime.Now;
        double diffDays = (rNow - rDoj).TotalDays;
        double diffYears = Math.Round(diffDays / 365F , 2);
        if (diffYears >= 5)
        {
            eligible_answer.Text = "Eligible for promo!";
        } else
        {
            eligible_answer.Text = "F :(";
        }
    }
}