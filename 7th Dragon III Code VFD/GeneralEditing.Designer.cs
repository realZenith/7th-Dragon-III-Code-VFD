namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000006 RID: 6
	public partial class GeneralEditing : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000FE17 File Offset: 0x0000E017
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000FE38 File Offset: 0x0000E038
		private void InitializeComponent()
		{
			this.label2 = new global::System.Windows.Forms.Label();
			this.azNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.dzNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.standardRadioButton = new global::System.Windows.Forms.RadioButton();
			this.casualRadioButton = new global::System.Windows.Forms.RadioButton();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.azNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dzNumericUpDown).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(107, 20);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(22, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "DZ";
			this.azNumericUpDown.Location = new global::System.Drawing.Point(39, 18);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.azNumericUpDown;
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.azNumericUpDown.Name = "azNumericUpDown";
			this.azNumericUpDown.Size = new global::System.Drawing.Size(60, 20);
			this.azNumericUpDown.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(21, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "AZ";
			this.dzNumericUpDown.Location = new global::System.Drawing.Point(135, 18);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.dzNumericUpDown;
			int[] array2 = new int[4];
			array2[0] = 999;
			numericUpDown2.Maximum = new decimal(array2);
			this.dzNumericUpDown.Name = "dzNumericUpDown";
			this.dzNumericUpDown.Size = new global::System.Drawing.Size(60, 20);
			this.dzNumericUpDown.TabIndex = 5;
			this.standardRadioButton.AutoSize = true;
			this.standardRadioButton.Location = new global::System.Drawing.Point(65, 48);
			this.standardRadioButton.Name = "standardRadioButton";
			this.standardRadioButton.Size = new global::System.Drawing.Size(68, 17);
			this.standardRadioButton.TabIndex = 6;
			this.standardRadioButton.TabStop = true;
			this.standardRadioButton.Text = "Standard";
			this.standardRadioButton.UseVisualStyleBackColor = true;
			this.casualRadioButton.AutoSize = true;
			this.casualRadioButton.Location = new global::System.Drawing.Point(139, 48);
			this.casualRadioButton.Name = "casualRadioButton";
			this.casualRadioButton.Size = new global::System.Drawing.Size(57, 17);
			this.casualRadioButton.TabIndex = 7;
			this.casualRadioButton.TabStop = true;
			this.casualRadioButton.Text = "Casual";
			this.casualRadioButton.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 50);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(47, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Difficulty";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(209, 81);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.casualRadioButton);
			base.Controls.Add(this.standardRadioButton);
			base.Controls.Add(this.dzNumericUpDown);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.azNumericUpDown);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "GeneralEditing";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "General";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.GeneralEditing_FormClosing);
			((global::System.ComponentModel.ISupportInitialize)this.azNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dzNumericUpDown).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007B RID: 123
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.NumericUpDown azNumericUpDown;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.NumericUpDown dzNumericUpDown;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.RadioButton standardRadioButton;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.RadioButton casualRadioButton;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label label3;
	}
}
