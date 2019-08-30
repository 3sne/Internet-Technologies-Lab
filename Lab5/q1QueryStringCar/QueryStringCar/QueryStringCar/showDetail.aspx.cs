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
            string gotModelNameAs = Request.QueryString["modelName"];
            string gotCarNameAs = Request.QueryString["carName"];
            //main.InnerHtml = string.Format(@"<h2>Your selection:</h2><br><strong> {0} {1}</strong>", Request.QueryString["modelName"], Request.QueryString["carName"]);
            car_holder.InnerText = string.Format("{0} {1}", gotModelNameAs, gotCarNameAs);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("inputPage.aspx");
        }
    }
}