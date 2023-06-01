namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000004 RID: 4
	public partial class ItemEditing1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000EF41 File Offset: 0x0000D141
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000EF60 File Offset: 0x0000D160
		private void InitializeComponent()
		{
			this.listViewItemBox = new global::System.Windows.Forms.ListView();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.columnHeaderSlot = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeaderItemName = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeaderItemType = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeaderItemQuantity = new global::System.Windows.Forms.ColumnHeader();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.listViewItemBox.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeaderSlot, this.columnHeaderItemName, this.columnHeaderItemType, this.columnHeaderItemQuantity });
			this.listViewItemBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewItemBox.FullRowSelect = true;
			this.listViewItemBox.GridLines = true;
			this.listViewItemBox.Location = new global::System.Drawing.Point(0, 0);
			this.listViewItemBox.Name = "listViewItemBox";
			this.listViewItemBox.Size = new global::System.Drawing.Size(485, 237);
			this.listViewItemBox.TabIndex = 0;
			this.listViewItemBox.UseCompatibleStateImageBehavior = false;
			this.listViewItemBox.View = global::System.Windows.Forms.View.Details;
			this.listViewItemBox.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listViewItemBox_MouseDoubleClick);
			this.panel1.Controls.Add(this.listViewItemBox);
			this.panel1.Location = new global::System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(485, 237);
			this.panel1.TabIndex = 1;
			this.button1.Location = new global::System.Drawing.Point(219, 255);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Edit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.columnHeaderSlot.Text = "Slot";
			this.columnHeaderItemName.Text = "Name";
			this.columnHeaderItemType.Text = "Type";
			this.columnHeaderItemQuantity.Text = "Quantity";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			base.ClientSize = new global::System.Drawing.Size(509, 286);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "ItemEditing1";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item Editor";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.ItemEditing1_FormClosing);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ListView listViewItemBox;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.ColumnHeader columnHeaderSlot;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.ColumnHeader columnHeaderItemName;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.ColumnHeader columnHeaderItemType;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.ColumnHeader columnHeaderItemQuantity;
	}
}
