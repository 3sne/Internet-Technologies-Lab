using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    private string[] fontFamilyList = { "Consolas", "Times New Roman" };
    private string[] fontSizeList = { "12", "16", "24", "40", "69" };
    private string[] bgList = { "Teal", "Red", "Yellow", "Cyan" };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        foreach (string str in fontFamilyList)
        {
            ffamDDL.Items.Add(new ListItem(str));
        }
        foreach (string str in fontSizeList)
        {
            fsizeDDL.Items.Add(new ListItem(str, str));
        }
        foreach (string str in bgList)
        {
            bgDDL.Items.Add(new ListItem(str, str));
        }
        foreach (string str in fontSizeList)
        {
            descFSDLL.Items.Add(new ListItem(str));
        }
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        string header = string.Format("<h2 style=\"font-family: {0}; font-size: {1}px\">{2}</h2>", ffamDDL.SelectedItem.Text, fsizeDDL.SelectedItem.Text, textInput.Text);
        string bodii = string.Format("<p style=\"font-size:{0}; text-align: center\">{1}</p>", descFSDLL.SelectedItem.Text, descTB.Text);
        string outerDiv = string.Format("<div style=\"border: 1px solid black; border-radius: 8px; overflow: hidden; background-color: {1}; min-height: 15rem; width:34rem; text-align: center; padding: 50px; margin:auto\">{0}{2}</div>", header, bgDDL.SelectedItem.Text, bodii);
        answer.InnerHtml = outerDiv;
    }
}