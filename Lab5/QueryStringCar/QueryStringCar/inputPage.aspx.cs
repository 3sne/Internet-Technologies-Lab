using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringCar
{
    public partial class inputPage : System.Web.UI.Page
    {
        string[] manList = { "Albany", "Rooster", "Osiris", "Pegassi", "Reaper", "X80 Proto" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            foreach (string s in manList)
                DropDownList1.Items.Add(new ListItem(s));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string modelName = DropDownList1.SelectedItem.Text;
            string carName = TextBox1.Text;
            if (carName == "") return;
            string _rurl = string.Format("showDetail.aspx?modelName={0}&carName={1}", Server.UrlEncode(modelName), Server.UrlEncode(carName));
            Response.Redirect(_rurl);
        }
    }
}