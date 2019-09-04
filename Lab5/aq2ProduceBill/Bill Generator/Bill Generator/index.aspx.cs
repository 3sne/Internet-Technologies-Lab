using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bill_Generator
{
    public partial class index : System.Web.UI.Page
    {
        private readonly string[] manList = { "HP", "Nokia", "Samsung", "Motorola", "Apple" };
        private readonly string[] devType = { "Mobile", "Laptop" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            foreach(string s in manList) manuf_ddl.Items.Add(new ListItem(s));
            foreach (string s in devType) dev_type_cbl.Items.Add(new ListItem(" " + s));
        }

        protected void btn_make_bill_Click(object sender, EventArgs e)
        {
            BillHolder bh = new BillHolder();
            bh.manufacturerName = manuf_ddl.SelectedItem.Text;
            bh.quantity = int.Parse(quantity_tb.Text);
            bh.deviceType = dev_type_cbl.SelectedItem.Text;
            bh.rate = double.Parse(rate_tb.Text);
            Session["_bill"] = bh;
            Response.Redirect("bill.aspx");
        }
    }
}