using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryBonus
{
    public partial class Form1 : Form
    {
        static int mSalary;
        static float[] salLevelWeight = { 999, 0.1F, 0.09F, 0.09F, 0.09F, 0.07F, 0.07F, 0.07F, 0.05F, 0.05F, 0.05F };
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetFields()
        {
            textBox1.ResetText();
            comboBox1.ResetText();
            bonusBox.ResetText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string raw_in = textBox1.Text;
            if (comboBox1.SelectedItem == null)
            {
                resetFields();
                return;
            }
            string raw_combo = comboBox1.SelectedItem.ToString();
            int sal_amt, sal_level;
            if (Int32.TryParse(raw_in, out sal_amt) == false)
            {
                resetFields();
                return;
            }
            if (Int32.TryParse(raw_combo, out sal_level) == false)
            {
                resetFields();
                return;
            }
            mSalary = sal_amt;
            float bonus = salLevelWeight[sal_level] * sal_amt;
            bonusBox.Text = bonus.ToString();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
