namespace CarThingy
{
    partial class Form1
    {
        static string[] carNames = { "Albany", "Briosa", "Enus", "Pegassi", "Ocelot", "Vapid", "Truffade" };
        static string[] colorNames = { "Galaxy Blue", "Schafter Purple", "Lime Green", "Lava Red" };
        static string[] modelNames = { "S", "3", "X", "Y", "B", "A", "E" };
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbModel = new System.Windows.Forms.ListBox();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbModel
            // 
            this.lbModel.FormattingEnabled = true;
            this.lbModel.ItemHeight = 16;
            this.lbModel.Location = new System.Drawing.Point(347, 163);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(120, 84);
            this.lbModel.TabIndex = 0;
            this.lbModel.SelectedIndexChanged += new System.EventHandler(this.LbModel_SelectedIndexChanged);
            for(int i = 0; i < modelNames.Length; i++)
            {
                lbModel.Items.Add(modelNames[i]);
            }
            //
            // cbCar
            // 
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(347, 103);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(121, 24);
            this.cbCar.TabIndex = 1;
            this.cbCar.SelectedIndexChanged += new System.EventHandler(this.CbCar_SelectedIndexChanged);
            for (int i = 0; i < carNames.Length; i++)
            {
                cbCar.Items.Add(carNames[i]);
            }
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(347, 133);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 24);
            this.cbColor.TabIndex = 2;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.CbColor_SelectedIndexChanged);
            for (int i = 0; i < colorNames.Length; i++)
            {
                cbColor.Items.Add(colorNames[i]);
            }
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Car Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(379, 300);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(88, 23);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(347, 253);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(120, 22);
            this.tbPrice.TabIndex = 10;
            this.tbPrice.TextChanged += new System.EventHandler(this.TbPrice_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.lbModel);
            this.Name = "Form1";
            this.Text = "Car Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbModel;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPrice;
    }
}

