namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000005 RID: 5
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000F49C File Offset: 0x0000D69C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000F4BC File Offset: 0x0000D6BC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_7th_Dragon_III_Code_VFD.Main));
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.makeBackupsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.generalButton = new global::System.Windows.Forms.Button();
			this.characterButton = new global::System.Windows.Forms.Button();
			this.inventoryButton = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem1, this.helpToolStripMenuItem1 });
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(264, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.openToolStripMenuItem1, this.makeBackupsToolStripMenuItem, this.saveToolStripMenuItem1, this.exitToolStripMenuItem1 });
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new global::System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem1.Text = "File";
			this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
			this.openToolStripMenuItem1.Size = new global::System.Drawing.Size(150, 22);
			this.openToolStripMenuItem1.Text = "Open";
			this.openToolStripMenuItem1.Click += new global::System.EventHandler(this.openToolStripMenuItem1_Click);
			this.makeBackupsToolStripMenuItem.Name = "makeBackupsToolStripMenuItem";
			this.makeBackupsToolStripMenuItem.Size = new global::System.Drawing.Size(150, 22);
			this.makeBackupsToolStripMenuItem.Text = "Make Backups";
			this.makeBackupsToolStripMenuItem.Click += new global::System.EventHandler(this.makeBackupsToolStripMenuItem_Click);
			this.saveToolStripMenuItem1.Enabled = false;
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new global::System.Drawing.Size(150, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			this.saveToolStripMenuItem1.Click += new global::System.EventHandler(this.saveToolStripMenuItem1_Click);
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new global::System.Drawing.Size(150, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.exitToolStripMenuItem1.Click += new global::System.EventHandler(this.exitToolStripMenuItem1_Click);
			this.helpToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.aboutToolStripMenuItem1 });
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new global::System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem1.Text = "Help";
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new global::System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new global::System.EventHandler(this.aboutToolStripMenuItem1_Click);
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.openToolStripMenuItem, this.saveToolStripMenuItem, this.exitToolStripMenuItem });
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new global::System.Drawing.Size(67, 22);
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new global::System.Drawing.Size(67, 22);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(67, 22);
			this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.aboutToolStripMenuItem });
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new global::System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(67, 22);
			this.generalButton.Enabled = false;
			this.generalButton.Location = new global::System.Drawing.Point(12, 61);
			this.generalButton.Name = "generalButton";
			this.generalButton.Size = new global::System.Drawing.Size(75, 23);
			this.generalButton.TabIndex = 1;
			this.generalButton.Text = "General";
			this.generalButton.UseVisualStyleBackColor = true;
			this.generalButton.Click += new global::System.EventHandler(this.generalButton_Click);
			this.characterButton.Enabled = false;
			this.characterButton.Location = new global::System.Drawing.Point(93, 61);
			this.characterButton.Name = "characterButton";
			this.characterButton.Size = new global::System.Drawing.Size(75, 23);
			this.characterButton.TabIndex = 2;
			this.characterButton.Text = "Character";
			this.characterButton.UseVisualStyleBackColor = true;
			this.characterButton.Click += new global::System.EventHandler(this.characterButton_Click);
			this.inventoryButton.Enabled = false;
			this.inventoryButton.Location = new global::System.Drawing.Point(174, 61);
			this.inventoryButton.Name = "inventoryButton";
			this.inventoryButton.Size = new global::System.Drawing.Size(75, 23);
			this.inventoryButton.TabIndex = 3;
			this.inventoryButton.Text = "Inventory";
			this.inventoryButton.UseVisualStyleBackColor = true;
			this.inventoryButton.Click += new global::System.EventHandler(this.inventoryButton_Click);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(82, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "File Not Loaded";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(264, 96);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.inventoryButton);
			base.Controls.Add(this.characterButton);
			base.Controls.Add(this.generalButton);
			base.Controls.Add(this.menuStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "7D3 Editor 0.1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000068 RID: 104
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Button generalButton;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Button characterButton;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Button inventoryButton;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.ToolStripMenuItem makeBackupsToolStripMenuItem;
	}
}
