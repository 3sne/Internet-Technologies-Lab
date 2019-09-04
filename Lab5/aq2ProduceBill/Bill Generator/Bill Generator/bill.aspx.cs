using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bill_Generator
{
    public partial class bill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Session["_bill"] == null)
            {
                master_table.Visible = false;
                return;
            }
            BillHolder bh = (BillHolder)Session["_bill"];
            mn.InnerText = bh.manufacturerName;
            price.InnerText = bh.rate.ToString();
            qt.InnerText = bh.quantity.ToString();
            total_qt.InnerText = (bh.quantity * bh.rate).ToString();
        }
    }
}