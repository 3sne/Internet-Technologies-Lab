using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    private readonly string un = "FakeNibbi";
    private readonly string pwd = "RealNibbi";
    public int _s { get; set; }
    public int _f { get; set; }


    protected void Page_Load(object sender, EventArgs e)
    {
        //initialize props
        if (Session["_s"] != null && Session["_f"] != null)
        {
            _s = (int)Session["_s"];
            _f = (int)Session["_f"];
            updateCountersInUI();
        }
        else
        {
            _s = _f = 0;
            Session["_s"] = _s;
            Session["_f"] = _f;
        }
    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        if (pwd == pw_tb.Text && un == name_tb.Text)
        {
            _s += 1;
        }
        else
        {
            _f += 1;
        }
        Session["_s"] = _s;
        Session["_f"] = _f;
        updateCountersInUI();
    }

    private void updateCountersInUI()
    {
        _success_count_holder.InnerText = _s.ToString();
        _failure_count_holder.InnerText = _f.ToString();
        if (_f > 3)
        {
            btn_login.Enabled = false;
            _failure_count_holder.Style["color"] = "red";
            derogation_handler.InnerText = "Get Locked Out Noob";
            derogation_handler.Style["color"] = "red";
        }
    }
}