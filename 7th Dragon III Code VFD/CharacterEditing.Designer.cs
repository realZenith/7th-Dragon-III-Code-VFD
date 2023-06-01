namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000002 RID: 2
	public partial class CharacterEditing : global::System.Windows.Forms.Form
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0000A027 File Offset: 0x00008227
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000A048 File Offset: 0x00008248
		private void InitializeComponent()
		{
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.charPortraitPictureBox = new global::System.Windows.Forms.PictureBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.charAcc2ComboBox = new global::System.Windows.Forms.ComboBox();
			this.charAcc1ComboBox = new global::System.Windows.Forms.ComboBox();
			this.charArmComboBox = new global::System.Windows.Forms.ComboBox();
			this.charWepComboBox = new global::System.Windows.Forms.ComboBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.maxSPNumeric = new global::System.Windows.Forms.Button();
			this.maxEXPNumeric = new global::System.Windows.Forms.Button();
			this.label17 = new global::System.Windows.Forms.Label();
			this.charClassComboBox = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.charExpNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.charNameTextBox = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.charSPNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.charLevelComboBox = new global::System.Windows.Forms.ComboBox();
			this.charSlotComboBox = new global::System.Windows.Forms.ComboBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.maxMDFNumeric = new global::System.Windows.Forms.Button();
			this.maxMATNumeric = new global::System.Windows.Forms.Button();
			this.maxSPDNumeric = new global::System.Windows.Forms.Button();
			this.maxDEFNumeric = new global::System.Windows.Forms.Button();
			this.maxATKNumeric = new global::System.Windows.Forms.Button();
			this.maxMANNumeric = new global::System.Windows.Forms.Button();
			this.maxHPNumeric = new global::System.Windows.Forms.Button();
			this.label16 = new global::System.Windows.Forms.Label();
			this.bonusMDFNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.bonusMATNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.bonusSPDNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.bonusDEFNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.bonusATKNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.bonusManaNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.label10 = new global::System.Windows.Forms.Label();
			this.bonusHPNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.charPortraitPictureBox).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.charExpNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.charSPNumericUpDown).BeginInit();
			this.groupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bonusMDFNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusMATNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusSPDNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusDEFNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusATKNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusManaNumericUpDown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusHPNumericUpDown).BeginInit();
			base.SuspendLayout();
			this.groupBox3.Controls.Add(this.charPortraitPictureBox);
			this.groupBox3.Location = new global::System.Drawing.Point(12, 44);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(220, 220);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Character Portrait";
			this.charPortraitPictureBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.charPortraitPictureBox.Location = new global::System.Drawing.Point(3, 16);
			this.charPortraitPictureBox.Name = "charPortraitPictureBox";
			this.charPortraitPictureBox.Size = new global::System.Drawing.Size(214, 201);
			this.charPortraitPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.charPortraitPictureBox.TabIndex = 7;
			this.charPortraitPictureBox.TabStop = false;
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.charAcc2ComboBox);
			this.groupBox2.Controls.Add(this.charAcc1ComboBox);
			this.groupBox2.Controls.Add(this.charArmComboBox);
			this.groupBox2.Controls.Add(this.charWepComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new global::System.Drawing.Point(238, 267);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(200, 150);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Equipment";
			this.groupBox2.Visible = false;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 108);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(35, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Acc 2";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 82);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(35, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Acc 1";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(6, 56);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(34, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Armor";
			this.charAcc2ComboBox.Enabled = false;
			this.charAcc2ComboBox.FormattingEnabled = true;
			this.charAcc2ComboBox.Location = new global::System.Drawing.Point(60, 105);
			this.charAcc2ComboBox.Name = "charAcc2ComboBox";
			this.charAcc2ComboBox.Size = new global::System.Drawing.Size(121, 21);
			this.charAcc2ComboBox.TabIndex = 4;
			this.charAcc1ComboBox.Enabled = false;
			this.charAcc1ComboBox.FormattingEnabled = true;
			this.charAcc1ComboBox.Location = new global::System.Drawing.Point(60, 79);
			this.charAcc1ComboBox.Name = "charAcc1ComboBox";
			this.charAcc1ComboBox.Size = new global::System.Drawing.Size(121, 21);
			this.charAcc1ComboBox.TabIndex = 3;
			this.charArmComboBox.Enabled = false;
			this.charArmComboBox.FormattingEnabled = true;
			this.charArmComboBox.Location = new global::System.Drawing.Point(60, 53);
			this.charArmComboBox.Name = "charArmComboBox";
			this.charArmComboBox.Size = new global::System.Drawing.Size(121, 21);
			this.charArmComboBox.TabIndex = 2;
			this.charWepComboBox.Enabled = false;
			this.charWepComboBox.FormattingEnabled = true;
			this.charWepComboBox.Location = new global::System.Drawing.Point(60, 27);
			this.charWepComboBox.Name = "charWepComboBox";
			this.charWepComboBox.Size = new global::System.Drawing.Size(121, 21);
			this.charWepComboBox.TabIndex = 1;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 30);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(48, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Weapon";
			this.groupBox1.Controls.Add(this.maxSPNumeric);
			this.groupBox1.Controls.Add(this.maxEXPNumeric);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.charClassComboBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.charExpNumericUpDown);
			this.groupBox1.Controls.Add(this.charNameTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.charSPNumericUpDown);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.charLevelComboBox);
			this.groupBox1.Location = new global::System.Drawing.Point(238, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(200, 217);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General";
			this.maxSPNumeric.Location = new global::System.Drawing.Point(137, 95);
			this.maxSPNumeric.Name = "maxSPNumeric";
			this.maxSPNumeric.Size = new global::System.Drawing.Size(44, 23);
			this.maxSPNumeric.TabIndex = 13;
			this.maxSPNumeric.Text = "Max";
			this.maxSPNumeric.UseVisualStyleBackColor = true;
			this.maxSPNumeric.Click += new global::System.EventHandler(this.maxSPNumeric_Click);
			this.maxEXPNumeric.Location = new global::System.Drawing.Point(137, 69);
			this.maxEXPNumeric.Name = "maxEXPNumeric";
			this.maxEXPNumeric.Size = new global::System.Drawing.Size(44, 23);
			this.maxEXPNumeric.TabIndex = 12;
			this.maxEXPNumeric.Text = "Max";
			this.maxEXPNumeric.UseVisualStyleBackColor = true;
			this.maxEXPNumeric.Click += new global::System.EventHandler(this.maxEXPNumeric_Click);
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(7, 127);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(32, 13);
			this.label17.TabIndex = 11;
			this.label17.Text = "Class";
			this.charClassComboBox.Enabled = false;
			this.charClassComboBox.FormattingEnabled = true;
			this.charClassComboBox.Location = new global::System.Drawing.Point(46, 124);
			this.charClassComboBox.Name = "charClassComboBox";
			this.charClassComboBox.Size = new global::System.Drawing.Size(135, 21);
			this.charClassComboBox.TabIndex = 10;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.charExpNumericUpDown.Location = new global::System.Drawing.Point(46, 72);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.charExpNumericUpDown;
			int[] array = new int[4];
			array[0] = 16777215;
			numericUpDown.Maximum = new decimal(array);
			this.charExpNumericUpDown.Name = "charExpNumericUpDown";
			this.charExpNumericUpDown.Size = new global::System.Drawing.Size(85, 20);
			this.charExpNumericUpDown.TabIndex = 9;
			this.charExpNumericUpDown.ThousandsSeparator = true;
			this.charNameTextBox.Location = new global::System.Drawing.Point(46, 19);
			this.charNameTextBox.MaxLength = 8;
			this.charNameTextBox.Name = "charNameTextBox";
			this.charNameTextBox.Size = new global::System.Drawing.Size(135, 20);
			this.charNameTextBox.TabIndex = 1;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 100);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(21, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "SP";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(7, 48);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(33, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Level";
			this.charSPNumericUpDown.Location = new global::System.Drawing.Point(46, 98);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.charSPNumericUpDown;
			int[] array2 = new int[4];
			array2[0] = 16777215;
			numericUpDown2.Maximum = new decimal(array2);
			this.charSPNumericUpDown.Name = "charSPNumericUpDown";
			this.charSPNumericUpDown.Size = new global::System.Drawing.Size(85, 20);
			this.charSPNumericUpDown.TabIndex = 5;
			this.charSPNumericUpDown.ThousandsSeparator = true;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 74);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(28, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "EXP";
			this.charLevelComboBox.FormattingEnabled = true;
			this.charLevelComboBox.Items.AddRange(new object[]
			{
				"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
				"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
				"21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
				"31", "32", "33", "34", "35", "36", "37", "38", "39", "40",
				"41", "42", "43", "44", "45", "46", "47", "48", "49", "50",
				"51", "52", "53", "54", "55", "56", "57", "58", "59", "60",
				"61", "62", "63", "64", "65", "66", "67", "68", "69", "70",
				"71", "72", "73", "74", "75", "76", "77", "78", "79", "80",
				"81", "82", "83", "84", "85", "86", "87", "88", "89", "90",
				"91", "92", "93", "94", "95", "96", "97", "98", "99"
			});
			this.charLevelComboBox.Location = new global::System.Drawing.Point(46, 45);
			this.charLevelComboBox.Name = "charLevelComboBox";
			this.charLevelComboBox.Size = new global::System.Drawing.Size(135, 21);
			this.charLevelComboBox.TabIndex = 6;
			this.charSlotComboBox.FormattingEnabled = true;
			this.charSlotComboBox.Location = new global::System.Drawing.Point(57, 16);
			this.charSlotComboBox.Name = "charSlotComboBox";
			this.charSlotComboBox.Size = new global::System.Drawing.Size(55, 21);
			this.charSlotComboBox.TabIndex = 16;
			this.charSlotComboBox.SelectedIndexChanged += new global::System.EventHandler(this.charSlotComboBox_SelectedIndexChanged);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(17, 19);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(25, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Slot";
			this.groupBox4.Controls.Add(this.maxMDFNumeric);
			this.groupBox4.Controls.Add(this.maxMATNumeric);
			this.groupBox4.Controls.Add(this.maxSPDNumeric);
			this.groupBox4.Controls.Add(this.maxDEFNumeric);
			this.groupBox4.Controls.Add(this.maxATKNumeric);
			this.groupBox4.Controls.Add(this.maxMANNumeric);
			this.groupBox4.Controls.Add(this.maxHPNumeric);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.bonusMDFNumericUpDown);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.bonusMATNumericUpDown);
			this.groupBox4.Controls.Add(this.bonusSPDNumericUpDown);
			this.groupBox4.Controls.Add(this.bonusDEFNumericUpDown);
			this.groupBox4.Controls.Add(this.bonusATKNumericUpDown);
			this.groupBox4.Controls.Add(this.bonusManaNumericUpDown);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.bonusHPNumericUpDown);
			this.groupBox4.Location = new global::System.Drawing.Point(444, 44);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(200, 217);
			this.groupBox4.TabIndex = 18;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Bonus Stats";
			this.maxMDFNumeric.Location = new global::System.Drawing.Point(138, 172);
			this.maxMDFNumeric.Name = "maxMDFNumeric";
			this.maxMDFNumeric.Size = new global::System.Drawing.Size(56, 23);
			this.maxMDFNumeric.TabIndex = 20;
			this.maxMDFNumeric.Text = "Max";
			this.maxMDFNumeric.UseVisualStyleBackColor = true;
			this.maxMDFNumeric.Click += new global::System.EventHandler(this.maxMDFNumeric_Click);
			this.maxMATNumeric.Location = new global::System.Drawing.Point(138, 146);
			this.maxMATNumeric.Name = "maxMATNumeric";
			this.maxMATNumeric.Size = new global::System.Drawing.Size(56, 23);
			this.maxMATNumeric.TabIndex = 19;
			this.maxMATNumeric.Text = "Max";
			this.maxMATNumeric.UseVisualStyleBackColor = true;
			this.maxMATNumeric.Click += new global::System.EventHandler(this.maxMATNumeric_Click);
			this.maxSPDNumeric.Location = new global::System.Drawing.Point(138, 121);
			this.maxSPDNumeric.Name = "maxSPDNumeric";
			this.maxSPDNumeric.Size = new global::System.Drawing.Size(56, 23);
			this.maxSPDNumeric.TabIndex = 18;
			this.maxSPDNumeric.Text = "Max";
			this.maxSPDNumeric.UseVisualStyleBackColor = true;
			this.maxSPDNumeric.Click += new global::System.EventHandler(this.maxSPDNumeric_Click);
			this.maxDEFNumeric.Location = new global::System.Drawing.Point(138, 95);
			this.maxDEFNumeric.Name = "maxDEFNumeric";
			this.maxDEFNumeric.Size = new global::System.Drawing.Size(56, 23);
			this.maxDEFNumeric.TabIndex = 17;
			this.maxDEFNumeric.Text = "Max";
			this.maxDEFNumeric.UseVisualStyleBackColor = true;
			this.maxDEFNumeric.Click += new global::System.EventHandler(this.maxDEFNumeric_Click);
			this.maxATKNumeric.Location = new global::System.Drawing.Point(138, 69);
			this.maxATKNumeric.Name = "maxATKNumeric";
			this.maxATKNumeric.Size = new global::System.Drawing.Size(56, 23);
			this.maxATKNumeric.TabIndex = 16;
			this.maxATKNumeric.Text = "Max";
			this.maxATKNumeric.UseVisualStyleBackColor = true;
			this.maxATKNumeric.Click += new global::System.EventHandler(this.maxATKNumeric_Click);
			this.maxMANNumeric.Location = new global::System.Drawing.Point(138, 42);
			this.maxMANNumeric.Name = "maxMANNumeric";
			this.maxMANNumeric.Size = new global::System.Drawing.Size(56, 23);
			this.maxMANNumeric.TabIndex = 15;
			this.maxMANNumeric.Text = "Max";
			this.maxMANNumeric.UseVisualStyleBackColor = true;
			this.maxMANNumeric.Click += new global::System.EventHandler(this.maxMANNumeric_Click);
			this.maxHPNumeric.Location = new global::System.Drawing.Point(138, 16);
			this.maxHPNumeric.Name = "maxHPNumeric";
			this.maxHPNumeric.Size = new global::System.Drawing.Size(56, 23);
			this.maxHPNumeric.TabIndex = 14;
			this.maxHPNumeric.Text = "Max";
			this.maxHPNumeric.UseVisualStyleBackColor = true;
			this.maxHPNumeric.Click += new global::System.EventHandler(this.maxHPNumeric_Click);
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(6, 177);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(30, 13);
			this.label16.TabIndex = 13;
			this.label16.Text = "MDF";
			this.bonusMDFNumericUpDown.Location = new global::System.Drawing.Point(52, 175);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.bonusMDFNumericUpDown;
			int[] array3 = new int[4];
			array3[0] = 300;
			numericUpDown3.Maximum = new decimal(array3);
			this.bonusMDFNumericUpDown.Name = "bonusMDFNumericUpDown";
			this.bonusMDFNumericUpDown.Size = new global::System.Drawing.Size(80, 20);
			this.bonusMDFNumericUpDown.TabIndex = 12;
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(6, 47);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(38, 13);
			this.label15.TabIndex = 11;
			this.label15.Text = "MANA";
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(6, 21);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(22, 13);
			this.label14.TabIndex = 10;
			this.label14.Text = "HP";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(5, 151);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(30, 13);
			this.label13.TabIndex = 9;
			this.label13.Text = "MAT";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(6, 126);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(29, 13);
			this.label12.TabIndex = 8;
			this.label12.Text = "SPD";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(5, 100);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(28, 13);
			this.label11.TabIndex = 7;
			this.label11.Text = "DEF";
			this.bonusMATNumericUpDown.Location = new global::System.Drawing.Point(52, 149);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.bonusMATNumericUpDown;
			int[] array4 = new int[4];
			array4[0] = 500;
			numericUpDown4.Maximum = new decimal(array4);
			this.bonusMATNumericUpDown.Name = "bonusMATNumericUpDown";
			this.bonusMATNumericUpDown.Size = new global::System.Drawing.Size(80, 20);
			this.bonusMATNumericUpDown.TabIndex = 6;
			this.bonusSPDNumericUpDown.Location = new global::System.Drawing.Point(52, 124);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.bonusSPDNumericUpDown;
			int[] array5 = new int[4];
			array5[0] = 255;
			numericUpDown5.Maximum = new decimal(array5);
			this.bonusSPDNumericUpDown.Name = "bonusSPDNumericUpDown";
			this.bonusSPDNumericUpDown.Size = new global::System.Drawing.Size(80, 20);
			this.bonusSPDNumericUpDown.TabIndex = 5;
			this.bonusDEFNumericUpDown.Location = new global::System.Drawing.Point(52, 98);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.bonusDEFNumericUpDown;
			int[] array6 = new int[4];
			array6[0] = 300;
			numericUpDown6.Maximum = new decimal(array6);
			this.bonusDEFNumericUpDown.Name = "bonusDEFNumericUpDown";
			this.bonusDEFNumericUpDown.Size = new global::System.Drawing.Size(80, 20);
			this.bonusDEFNumericUpDown.TabIndex = 4;
			this.bonusATKNumericUpDown.Location = new global::System.Drawing.Point(52, 72);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.bonusATKNumericUpDown;
			int[] array7 = new int[4];
			array7[0] = 500;
			numericUpDown7.Maximum = new decimal(array7);
			this.bonusATKNumericUpDown.Name = "bonusATKNumericUpDown";
			this.bonusATKNumericUpDown.Size = new global::System.Drawing.Size(80, 20);
			this.bonusATKNumericUpDown.TabIndex = 3;
			this.bonusManaNumericUpDown.Location = new global::System.Drawing.Point(52, 45);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.bonusManaNumericUpDown;
			int[] array8 = new int[4];
			array8[0] = 300;
			numericUpDown8.Maximum = new decimal(array8);
			this.bonusManaNumericUpDown.Name = "bonusManaNumericUpDown";
			this.bonusManaNumericUpDown.Size = new global::System.Drawing.Size(80, 20);
			this.bonusManaNumericUpDown.TabIndex = 2;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(5, 74);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(28, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "ATK";
			this.bonusHPNumericUpDown.Location = new global::System.Drawing.Point(52, 19);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.bonusHPNumericUpDown;
			int[] array9 = new int[4];
			array9[0] = 500;
			numericUpDown9.Maximum = new decimal(array9);
			this.bonusHPNumericUpDown.Name = "bonusHPNumericUpDown";
			this.bonusHPNumericUpDown.Size = new global::System.Drawing.Size(80, 20);
			this.bonusHPNumericUpDown.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(664, 431);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.charSlotComboBox);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "CharacterEditing";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Character Editor";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.CharacterEditing_FormClosing);
			this.groupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.charPortraitPictureBox).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.charExpNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.charSPNumericUpDown).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bonusMDFNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusMATNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusSPDNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusDEFNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusATKNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusManaNumericUpDown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bonusHPNumericUpDown).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.PictureBox charPortraitPictureBox;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ComboBox charAcc2ComboBox;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ComboBox charAcc1ComboBox;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ComboBox charArmComboBox;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ComboBox charWepComboBox;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ComboBox charClassComboBox;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.NumericUpDown charExpNumericUpDown;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.TextBox charNameTextBox;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.NumericUpDown charSPNumericUpDown;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ComboBox charLevelComboBox;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ComboBox charSlotComboBox;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.NumericUpDown bonusManaNumericUpDown;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.NumericUpDown bonusHPNumericUpDown;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.NumericUpDown bonusMATNumericUpDown;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.NumericUpDown bonusSPDNumericUpDown;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.NumericUpDown bonusDEFNumericUpDown;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.NumericUpDown bonusATKNumericUpDown;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.NumericUpDown bonusMDFNumericUpDown;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button maxSPNumeric;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Button maxEXPNumeric;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button maxMDFNumeric;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button maxMATNumeric;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Button maxSPDNumeric;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button maxDEFNumeric;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Button maxATKNumeric;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button maxMANNumeric;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Button maxHPNumeric;
	}
}
