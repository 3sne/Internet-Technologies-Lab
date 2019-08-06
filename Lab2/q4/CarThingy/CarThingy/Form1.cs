using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarThingy
{

    public partial class Form1 : Form
    {
        string carName;
        string modelName;
        string colorName;
        int price;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCar.SelectedItem != null)
            {
                this.carName = cbCar.SelectedItem.ToString();
            } else
            {
                this.carName = "";
            }
        }

        private void CbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.SelectedItem != null)
            {
                this.colorName = cbColor.SelectedItem.ToString();
            } else
            {
                this.colorName = "";
            }
        }

        private void LbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbModel.SelectedItem != null)
            {
                this.modelName = lbModel.SelectedItem.ToString();
            } else
            {
                this.modelName = "";
            }
        }

        private void TbPrice_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbPrice.Text, out price) == false)
            {
                price = 0;
            }
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            //extract data
            if (carName != "" && modelName != "" && colorName != "" && price != 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(carName + " " +modelName + " | " + colorName + "\nTo Pay: $ " + price , "Car Purchased Successful!", buttons);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cbCar.ResetText();
            cbColor.ResetText();
            lbModel.ClearSelected();
            tbPrice.ResetText();
        }
    }
}
