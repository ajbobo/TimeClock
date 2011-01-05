namespace TimeClock_CS
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.lblTime = new System.Windows.Forms.Label();
			this.cboLabel = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnIn = new System.Windows.Forms.Button();
			this.imgButtons = new System.Windows.Forms.ImageList(this.components);
			this.btnOut = new System.Windows.Forms.Button();
			this.timerUpdateDisplay = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(52, 9);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(175, 24);
			this.lblTime.TabIndex = 0;
			this.lblTime.Text = "<<<Time TBD>>>";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboLabel
			// 
			this.cboLabel.FormattingEnabled = true;
			this.cboLabel.Items.AddRange(new object[] {
            "Default"});
			this.cboLabel.Location = new System.Drawing.Point(113, 53);
			this.cboLabel.Name = "cboLabel";
			this.cboLabel.Size = new System.Drawing.Size(121, 21);
			this.cboLabel.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Time Label:";
			// 
			// btnIn
			// 
			this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnIn.FlatAppearance.BorderSize = 0;
			this.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIn.Location = new System.Drawing.Point(14, 98);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(120, 40);
			this.btnIn.TabIndex = 3;
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.MouseLeave += new System.EventHandler(this.btn_Leave);
			this.btnIn.Click += new System.EventHandler(this.btn_Click);
			this.btnIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Down);
			this.btnIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Up);
			this.btnIn.MouseEnter += new System.EventHandler(this.btn_Enter);
			// 
			// imgButtons
			// 
			this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
			this.imgButtons.TransparentColor = System.Drawing.Color.Transparent;
			this.imgButtons.Images.SetKeyName(0, "In_Active.png");
			this.imgButtons.Images.SetKeyName(1, "In_Inactive.png");
			this.imgButtons.Images.SetKeyName(2, "In_Pressed.png");
			this.imgButtons.Images.SetKeyName(3, "Out_Active.png");
			this.imgButtons.Images.SetKeyName(4, "Out_Inactive.png");
			this.imgButtons.Images.SetKeyName(5, "Out_Pressed.png");
			// 
			// btnOut
			// 
			this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnOut.FlatAppearance.BorderSize = 0;
			this.btnOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOut.Location = new System.Drawing.Point(146, 98);
			this.btnOut.Name = "btnOut";
			this.btnOut.Size = new System.Drawing.Size(120, 40);
			this.btnOut.TabIndex = 4;
			this.btnOut.UseVisualStyleBackColor = false;
			this.btnOut.MouseLeave += new System.EventHandler(this.btn_Leave);
			this.btnOut.Click += new System.EventHandler(this.btn_Click);
			this.btnOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Down);
			this.btnOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Up);
			this.btnOut.MouseEnter += new System.EventHandler(this.btn_Enter);
			// 
			// timerUpdateDisplay
			// 
			this.timerUpdateDisplay.Enabled = true;
			this.timerUpdateDisplay.Tick += new System.EventHandler(this.timerUpdateDisplay_Tick);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 150);
			this.Controls.Add(this.btnOut);
			this.Controls.Add(this.btnIn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboLabel);
			this.Controls.Add(this.lblTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Time Clock";
			this.ResumeLayout(false);
			this.PerformLayout();

 		}

		#endregion

		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.ComboBox cboLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.Button btnOut;
		private System.Windows.Forms.Timer timerUpdateDisplay;
		private System.Windows.Forms.ImageList imgButtons;
	}
}

