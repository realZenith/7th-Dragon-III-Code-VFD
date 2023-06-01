namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000003 RID: 3
	public partial class ItemEditDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000D38A File Offset: 0x0000B58A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(45, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(209, 21);
			this.comboBox1.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(260, 13);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(46, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Quantity";
			this.numericUpDown1.Location = new global::System.Drawing.Point(312, 11);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 15;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 3;
			this.button1.Location = new global::System.Drawing.Point(150, 37);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Location = new global::System.Drawing.Point(231, 37);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			base.ClientSize = new global::System.Drawing.Size(444, 71);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "ItemEditDialog";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item Editor";
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000045 RID: 69
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Button button2;
	}
}
