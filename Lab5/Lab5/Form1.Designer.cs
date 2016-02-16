namespace Lab5
{
    partial class frm_Lab5
    {
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
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lbl_Make = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.brnSubmit = new System.Windows.Forms.Button();
            this.lbl_Bevel = new System.Windows.Forms.Label();
            this.grpBox_SportsCar = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.lbl_Horsepower = new System.Windows.Forms.Label();
            this.txtBox_Horsepower = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBox_SportsCar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(12, 12);
            this.txtMake.MaxLength = 10;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 0;
            this.txtMake.Text = "Make";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(150, 12);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.Text = "Year";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(256, 12);
            this.txtColor.MaxLength = 8;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 2;
            this.txtColor.Text = "Color";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(362, 12);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "Price";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(123, 62);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(338, 20);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.Text = "Car Info";
            // 
            // lbl_Make
            // 
            this.lbl_Make.AutoSize = true;
            this.lbl_Make.Location = new System.Drawing.Point(12, 35);
            this.lbl_Make.Name = "lbl_Make";
            this.lbl_Make.Size = new System.Drawing.Size(34, 13);
            this.lbl_Make.TabIndex = 10;
            this.lbl_Make.Text = "Make";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(147, 35);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(29, 13);
            this.lbl_Year.TabIndex = 10;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(253, 35);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(31, 13);
            this.lbl_Color.TabIndex = 10;
            this.lbl_Color.Text = "Color";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(359, 35);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 10;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(9, 65);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(97, 13);
            this.lbl_Info.TabIndex = 10;
            this.lbl_Info.Text = "Vehicle Information";
            // 
            // brnSubmit
            // 
            this.brnSubmit.Location = new System.Drawing.Point(380, 150);
            this.brnSubmit.Name = "brnSubmit";
            this.brnSubmit.Size = new System.Drawing.Size(134, 56);
            this.brnSubmit.TabIndex = 6;
            this.brnSubmit.Text = "Create Object";
            this.brnSubmit.UseVisualStyleBackColor = true;
            this.brnSubmit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Bevel
            // 
            this.lbl_Bevel.AutoSize = true;
            this.lbl_Bevel.Location = new System.Drawing.Point(12, 117);
            this.lbl_Bevel.Name = "lbl_Bevel";
            this.lbl_Bevel.Size = new System.Drawing.Size(30, 13);
            this.lbl_Bevel.TabIndex = 11;
            this.lbl_Bevel.Text = "temp";
            // 
            // grpBox_SportsCar
            // 
            this.grpBox_SportsCar.Controls.Add(this.rdbNo);
            this.grpBox_SportsCar.Controls.Add(this.rdbYes);
            this.grpBox_SportsCar.Location = new System.Drawing.Point(14, 146);
            this.grpBox_SportsCar.Name = "grpBox_SportsCar";
            this.grpBox_SportsCar.Size = new System.Drawing.Size(119, 60);
            this.grpBox_SportsCar.TabIndex = 12;
            this.grpBox_SportsCar.TabStop = false;
            this.grpBox_SportsCar.Text = "Sports Car";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(74, 25);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Location = new System.Drawing.Point(6, 25);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(43, 17);
            this.rdbYes.TabIndex = 0;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            this.rdbYes.Click += new System.EventHandler(this.rdbYes_Click);
            // 
            // lbl_Horsepower
            // 
            this.lbl_Horsepower.AutoSize = true;
            this.lbl_Horsepower.Location = new System.Drawing.Point(139, 173);
            this.lbl_Horsepower.Name = "lbl_Horsepower";
            this.lbl_Horsepower.Size = new System.Drawing.Size(64, 13);
            this.lbl_Horsepower.TabIndex = 13;
            this.lbl_Horsepower.Text = "Horsepower";
            this.lbl_Horsepower.Visible = false;
            // 
            // txtBox_Horsepower
            // 
            this.txtBox_Horsepower.Location = new System.Drawing.Point(209, 170);
            this.txtBox_Horsepower.MaxLength = 3;
            this.txtBox_Horsepower.Name = "txtBox_Horsepower";
            this.txtBox_Horsepower.Size = new System.Drawing.Size(77, 20);
            this.txtBox_Horsepower.TabIndex = 4;
            this.txtBox_Horsepower.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frm_Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 276);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtBox_Horsepower);
            this.Controls.Add(this.lbl_Horsepower);
            this.Controls.Add(this.grpBox_SportsCar);
            this.Controls.Add(this.lbl_Bevel);
            this.Controls.Add(this.brnSubmit);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Make);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Name = "frm_Lab5";
            this.Text = "Lab 5";
            this.grpBox_SportsCar.ResumeLayout(false);
            this.grpBox_SportsCar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lbl_Make;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button brnSubmit;
        private System.Windows.Forms.Label lbl_Bevel;
        private System.Windows.Forms.GroupBox grpBox_SportsCar;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.Label lbl_Horsepower;
        private System.Windows.Forms.TextBox txtBox_Horsepower;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

