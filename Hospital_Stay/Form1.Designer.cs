namespace Hospital_Stay
{
	partial class Form1
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
			this.lblHeading = new System.Windows.Forms.Label();
			this.txtDaysStayed = new System.Windows.Forms.TextBox();
			this.lblStayCost = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMedication = new System.Windows.Forms.TextBox();
			this.txtSurgical = new System.Windows.Forms.TextBox();
			this.txtLabFees = new System.Windows.Forms.TextBox();
			this.txtRehab = new System.Windows.Forms.TextBox();
			this.lblMiscCost = new System.Windows.Forms.Label();
			this.btnTotalCalc = new System.Windows.Forms.Button();
			this.lblTotalCost = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblHeading
			// 
			this.lblHeading.AutoSize = true;
			this.lblHeading.BackColor = System.Drawing.Color.Transparent;
			this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeading.ForeColor = System.Drawing.Color.Crimson;
			this.lblHeading.Location = new System.Drawing.Point(80, 9);
			this.lblHeading.Name = "lblHeading";
			this.lblHeading.Size = new System.Drawing.Size(228, 25);
			this.lblHeading.TabIndex = 0;
			this.lblHeading.Text = "Hospital Bill Calculator";
			// 
			// txtDaysStayed
			// 
			this.txtDaysStayed.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtDaysStayed.Location = new System.Drawing.Point(116, 57);
			this.txtDaysStayed.MaxLength = 3;
			this.txtDaysStayed.Name = "txtDaysStayed";
			this.txtDaysStayed.Size = new System.Drawing.Size(62, 20);
			this.txtDaysStayed.TabIndex = 1;
			this.txtDaysStayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblStayCost
			// 
			this.lblStayCost.AutoSize = true;
			this.lblStayCost.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblStayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStayCost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblStayCost.Location = new System.Drawing.Point(195, 87);
			this.lblStayCost.Name = "lblStayCost";
			this.lblStayCost.Size = new System.Drawing.Size(16, 16);
			this.lblStayCost.TabIndex = 2;
			this.lblStayCost.Text = "0";
			this.lblStayCost.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(195, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Days Stayed";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(195, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Medication";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(195, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Surgical Fees";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(195, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Lab Fees";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(195, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Physical Rehab";
			// 
			// txtMedication
			// 
			this.txtMedication.Location = new System.Drawing.Point(116, 136);
			this.txtMedication.Name = "txtMedication";
			this.txtMedication.Size = new System.Drawing.Size(63, 20);
			this.txtMedication.TabIndex = 10;
			this.txtMedication.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSurgical
			// 
			this.txtSurgical.Location = new System.Drawing.Point(116, 162);
			this.txtSurgical.Name = "txtSurgical";
			this.txtSurgical.Size = new System.Drawing.Size(63, 20);
			this.txtSurgical.TabIndex = 11;
			this.txtSurgical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtLabFees
			// 
			this.txtLabFees.Location = new System.Drawing.Point(116, 188);
			this.txtLabFees.Name = "txtLabFees";
			this.txtLabFees.Size = new System.Drawing.Size(63, 20);
			this.txtLabFees.TabIndex = 12;
			this.txtLabFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRehab
			// 
			this.txtRehab.Location = new System.Drawing.Point(116, 214);
			this.txtRehab.Name = "txtRehab";
			this.txtRehab.Size = new System.Drawing.Size(63, 20);
			this.txtRehab.TabIndex = 13;
			this.txtRehab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblMiscCost
			// 
			this.lblMiscCost.AutoSize = true;
			this.lblMiscCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMiscCost.Location = new System.Drawing.Point(195, 243);
			this.lblMiscCost.Name = "lblMiscCost";
			this.lblMiscCost.Size = new System.Drawing.Size(16, 16);
			this.lblMiscCost.TabIndex = 15;
			this.lblMiscCost.Text = "0";
			// 
			// btnTotalCalc
			// 
			this.btnTotalCalc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTotalCalc.Location = new System.Drawing.Point(116, 278);
			this.btnTotalCalc.Name = "btnTotalCalc";
			this.btnTotalCalc.Size = new System.Drawing.Size(63, 23);
			this.btnTotalCalc.TabIndex = 16;
			this.btnTotalCalc.Text = "Calculate";
			this.btnTotalCalc.UseVisualStyleBackColor = true;
			this.btnTotalCalc.Click += new System.EventHandler(this.btnTotalCalc_Click);
			// 
			// lblTotalCost
			// 
			this.lblTotalCost.AutoSize = true;
			this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalCost.Location = new System.Drawing.Point(195, 281);
			this.lblTotalCost.Name = "lblTotalCost";
			this.lblTotalCost.Size = new System.Drawing.Size(16, 16);
			this.lblTotalCost.TabIndex = 17;
			this.lblTotalCost.Text = "0";
			// 
			// btnReset
			// 
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.Location = new System.Drawing.Point(116, 319);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(63, 23);
			this.btnReset.TabIndex = 18;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnExit
			// 
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Location = new System.Drawing.Point(316, 319);
			this.btnExit.Name = "btnExit";
			this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnExit.Size = new System.Drawing.Size(62, 23);
			this.btnExit.TabIndex = 19;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 344);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblTotalCost);
			this.Controls.Add(this.btnTotalCalc);
			this.Controls.Add(this.lblMiscCost);
			this.Controls.Add(this.txtRehab);
			this.Controls.Add(this.txtLabFees);
			this.Controls.Add(this.txtSurgical);
			this.Controls.Add(this.txtMedication);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblStayCost);
			this.Controls.Add(this.txtDaysStayed);
			this.Controls.Add(this.lblHeading);
			this.Name = "Form1";
			this.Text = "frmHospitalCalculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHeading;
		private System.Windows.Forms.TextBox txtDaysStayed;
		private System.Windows.Forms.Label lblStayCost;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMedication;
		private System.Windows.Forms.TextBox txtSurgical;
		private System.Windows.Forms.TextBox txtLabFees;
		private System.Windows.Forms.TextBox txtRehab;
		private System.Windows.Forms.Label lblMiscCost;
		private System.Windows.Forms.Button btnTotalCalc;
		private System.Windows.Forms.Label lblTotalCost;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnExit;
	}
}

