using System;
using System.Collections;
using System.Web.UI.WebControls;

public partial class firstPage : System.Web.UI.Page
{
    private string[] subList = { "Meth", "Chem" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        foreach (string s in subList) sub_ddl.Items.Add(new ListItem(s));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = name_tb.Text;
        string regNo = regno_tb.Text;
        string selectedSubject = sub_ddl.SelectedItem.Text;
        Hashtable tempHt = new Hashtable();
        tempHt.Add("name", name);
        tempHt.Add("regNo", regNo);
        tempHt.Add("selectedSubject", selectedSubject);
        Session["StudentInst"] = tempHt;
        Response.Redirect("secondPage.aspx");
    }
}