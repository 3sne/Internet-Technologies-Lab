using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    private readonly string[] candidateList = { "Deepu", "Golu", "Munna" };
    private readonly string[] houseList = { "Phoenix", "Dragon", "Unicorn" };

    protected void Page_Load(object sender, EventArgs e)
    {
        status_jumbo.Visible = false;
        if (IsPostBack) return;
        foreach (string s in candidateList) ddl_can.Items.Add(new ListItem(s));
        foreach (string s in houseList) radio_house.Items.Add(new ListItem(s));
        regex_email.ValidationExpression = "[a-zA-Z0-9]+@[a-zA-Z0-9]+[.][a-zA-Z]";
    
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        status_jumbo.Visible = true;
    }

    protected void tb_email_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = false;
    }
}
