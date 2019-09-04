using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Captcha
{
    public partial class index : System.Web.UI.Page
    {
        private int _maxTries
        {
            get
            {
                if (this.ViewState["MT"] == null)
                    return 3;

                return (int)this.ViewState["MT"];
            }
            set
            {
                this.ViewState["MT"] = value;
            }
        }
        private string _hiddenCaptcha
        {
            get
            {
                if (this.ViewState["c"] == null)
                    return string.Empty;

                return (string)this.ViewState["c"];
            }
            set
            {
                this.ViewState["c"] = value;
            }
        }
        private readonly string[] captchaPool = { "PLZB318", "13ATA55", "MEEPM33P", "TOAST3R", "0FUXGIVN", "ICUH8N", "AD10S" };

        protected void Page_Load(object sender, EventArgs e)
        {
            jmb.Visible = false;
            if (IsPostBack) return;
            Random r = new Random();
            int idx = r.Next(0, 6);
            _hiddenCaptcha = captchaPool[idx];
            real_cepcha.InnerText = _hiddenCaptcha;
        }

        protected void btn_verify_Click(object sender, EventArgs e)
        {
            if (ni_tb.Enabled == false) return;
            jmb.Visible = true;
            if (_maxTries <= 0)
            {
                status.InnerText = "You had your chance, but now you're banned. FoReVeR.";
                ni_tb.Enabled = false;
                btn_verify.Enabled = false;
                return;
            }

            if (ni_tb.Text == _hiddenCaptcha)
            {
                status.InnerText = "Successful Match!";
            } else
            {
                status.InnerText = "Get out Noob";
                _maxTries--;
            }
        }
    }
}