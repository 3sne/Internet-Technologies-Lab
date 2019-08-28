using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringCar
{
    public partial class showDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            main.InnerHtml = string.Format("<strong> Model >> </strong> {0} <br> <strong> Name >> </strong> {1}", Request.QueryString["modelName"], Request.QueryString["carName"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("inputPage.aspx");
        }
    }
}