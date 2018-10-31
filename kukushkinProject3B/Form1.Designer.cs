namespace kukushkinProject3A
{
    partial class frmDebtRatio
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLiability = new System.Windows.Forms.Label();
            this.lblAssets = new System.Windows.Forms.Label();
            this.txtLiability = new System.Windows.Forms.TextBox();
            this.txtAssets = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(87, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(223, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLiability
            // 
            this.lblLiability.AutoSize = true;
            this.lblLiability.Location = new System.Drawing.Point(81, 126);
            this.lblLiability.Name = "lblLiability";
            this.lblLiability.Size = new System.Drawing.Size(79, 13);
            this.lblLiability.TabIndex = 2;
            this.lblLiability.Text = "Total Liabilities:";
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Location = new System.Drawing.Point(82, 183);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(68, 13);
            this.lblAssets.TabIndex = 3;
            this.lblAssets.Text = "Total Assets:";
            this.lblAssets.Click += new System.EventHandler(this.lblAssets_Click);
            // 
            // txtLiability
            // 
            this.txtLiability.Location = new System.Drawing.Point(198, 123);
            this.txtLiability.Name = "txtLiability";
            this.txtLiability.Size = new System.Drawing.Size(100, 20);
            this.txtLiability.TabIndex = 2;
            // 
            // txtAssets
            // 
            this.txtAssets.Location = new System.Drawing.Point(198, 180);
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.Size = new System.Drawing.Size(100, 20);
            this.txtAssets.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 1;
            // 
            // frmDebtRatio
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(371, 325);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAssets);
            this.Controls.Add(this.txtLiability);
            this.Controls.Add(this.lblAssets);
            this.Controls.Add(this.lblLiability);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmDebtRatio";
            this.Text = "Debt Ratio Calculator";
            this.Load += new System.EventHandler(this.frmDebtRatio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLiability;
        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.TextBox txtLiability;
        private System.Windows.Forms.TextBox txtAssets;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}

