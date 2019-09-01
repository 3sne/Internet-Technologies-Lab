using System;
using System.Collections;
using System.Web;

public partial class secondPage : System.Web.UI.Page
{
    public int _Counter { get; set; }
    HttpCookie curr;
    protected void Page_Load(object sender, EventArgs e)
    {
        curr = Request.Cookies.Get("counter_cookie");
        if (curr != null)
        {
            int temp;
            int.TryParse(curr["counter"], out temp);
            _Counter = temp;
        }
        else
        {
            _Counter = 0;
        }
        _counter_holder.InnerText = _Counter.ToString();
        if (IsPostBack)   return;
        
        if (Session["StudentInst"] != null)
        {
            Hashtable ht;
            ht = (Hashtable)Session["StudentInst"];
            name_holder.InnerText = string.Format("Name: {0}", (string)ht["name"]);
            regno_holder.InnerText = string.Format("RegNo: {0}", (string)ht["regNo"]);
            subject_holder.InnerText = string.Format("Subject: {0}", (string)ht["selectedSubject"]);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        _Counter += 1;
        if (curr == null)
        {
            curr = new HttpCookie("counter_cookie");
        }
        curr["counter"] = _Counter.ToString();
        Response.Cookies.Add(curr);
        _counter_holder.InnerText = _Counter.ToString();
    }
}