using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _7th_Dragon_III_Code_VFD.Properties;

namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000002 RID: 2
	public partial class CharacterEditing : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public CharacterEditing()
		{
			this.InitializeComponent();
			byte[] array = new byte[]
			{
				Main.SaveData[1132],
				Main.SaveData[2240],
				Main.SaveData[3348],
				Main.SaveData[4456],
				Main.SaveData[5564],
				Main.SaveData[6672],
				Main.SaveData[7780],
				Main.SaveData[8888],
				Main.SaveData[9996],
				Main.SaveData[11104],
				Main.SaveData[12212],
				Main.SaveData[13320],
				Main.SaveData[14428],
				Main.SaveData[15536],
				Main.SaveData[16644],
				Main.SaveData[17752],
				Main.SaveData[18860],
				Main.SaveData[19968],
				Main.SaveData[21076],
				Main.SaveData[22184]
			};
			for (int i = 0; i < 20; i++)
			{
				if (array[i] != 255)
				{
					this.charSlotComboBox.Items.Add(i + 1);
				}
			}
			this.charSlotComboBox.SelectedIndex = 0;
			this.currentSlot = this.charSlotComboBox.SelectedIndex + 1;
			this.displayChar();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021EC File Offset: 0x000003EC
		private void LoadSamuraiWeapons()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("KT - Kiryu Ichimonji", 206);
			dictionary.Add("KT - Wakizashi", 220);
			dictionary.Add("KT - Masamune", 221);
			dictionary.Add("KT - Mikazuchi", 222);
			dictionary.Add("KT - Zanbatou", 223);
			dictionary.Add("KT - Chidori", 224);
			dictionary.Add("KT - Zanba Ashura", 226);
			dictionary.Add("KT - Seigan", 227);
			dictionary.Add("KT - Kokutou", 228);
			dictionary.Add("KT - Amanotsurugi", 229);
			dictionary.Add("DB - Souken", 250);
			dictionary.Add("DB - Kogarasumaru", 251);
			dictionary.Add("DB - Hizamaru", 252);
			dictionary.Add("DB - Kotetsu", 253);
			dictionary.Add("DB - Hotarumaru", 254);
			dictionary.Add("DB - Shishiou", 255);
			dictionary.Add("DB - Sealed Shichisei", 256);
			dictionary.Add("DB - Raikiri", 257);
			dictionary.Add("DB - Shichisei", 258);
			dictionary.Add("DB - Chiru + Sakei", 259);
			this.charWepComboBox.DataSource = new BindingSource(dictionary, null);
			this.charWepComboBox.DisplayMember = "Key";
			this.charWepComboBox.ValueMember = "Value";
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002374 File Offset: 0x00000574
		private void LoadGodHandWeapons()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("Twin Fist", 260);
			dictionary.Add("Knuckle Breaker", 261);
			dictionary.Add("Hero Fist", 262);
			dictionary.Add("Kaiser Knuckle", 263);
			dictionary.Add("Bone Fist", 264);
			dictionary.Add("Star Fist", 265);
			dictionary.Add("Ogre Crusher", 266);
			dictionary.Add("Dreadnought", 267);
			dictionary.Add("Almighty Hand", 268);
			dictionary.Add("Mio Gauntlet", 268);
			this.charWepComboBox.DataSource = new BindingSource(dictionary, null);
			this.charWepComboBox.DisplayMember = "Key";
			this.charWepComboBox.ValueMember = "Value";
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000245C File Offset: 0x0000065C
		private void LoadAccessories()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("Attack Ring I", 500);
			dictionary.Add("Guard Ring I", 501);
			dictionary.Add("Phazer Ring I", 502);
			dictionary.Add("Cat Tail", 503);
			dictionary.Add("Killer Band", 504);
			dictionary.Add("Gygant Medal", 505);
			dictionary.Add("Toughness Medal", 506);
			dictionary.Add("Blaster Belt", 507);
			dictionary.Add("Saint Ring", 508);
			dictionary.Add("Attack Ring II", 509);
			dictionary.Add("Guard Ring II", 510);
			dictionary.Add("Phazer Ring II", 511);
			dictionary.Add("Retreat Ring", 512);
			dictionary.Add("Shining Ring", 513);
			dictionary.Add("Guard Ring III", 514);
			dictionary.Add("Argos Medal", 515);
			dictionary.Add("Sway Ring", 516);
			dictionary.Add("Blaster Ring", 517);
			dictionary.Add("Venom Guard", 530);
			dictionary.Add("Paralyze Guard", 531);
			dictionary.Add("Burn Guard", 532);
			dictionary.Add("Frost Guard", 533);
			dictionary.Add("Blind Guard", 534);
			dictionary.Add("Mind Booster", 563);
			this.charAcc1ComboBox.DataSource = new BindingSource(dictionary, null);
			this.charAcc1ComboBox.DisplayMember = "Key";
			this.charAcc1ComboBox.ValueMember = "Value";
			this.charAcc2ComboBox.DataSource = new BindingSource(dictionary, null);
			this.charAcc2ComboBox.DisplayMember = "Key";
			this.charAcc2ComboBox.ValueMember = "Value";
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002654 File Offset: 0x00000854
		private void LoadClasses()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("Samurai", 0);
			dictionary.Add("Agent", 1);
			dictionary.Add("God Hand", 2);
			dictionary.Add("Duelist", 3);
			dictionary.Add("Rune Knight", 4);
			dictionary.Add("Fortuner", 5);
			dictionary.Add("Banisher", 6);
			dictionary.Add("Mage", 7);
			this.charClassComboBox.DataSource = new BindingSource(dictionary, null);
			this.charClassComboBox.DisplayMember = "Key";
			this.charClassComboBox.ValueMember = "Value";
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000026F9 File Offset: 0x000008F9
		private void charSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SaveCharacters();
			this.currentSlot = this.charSlotComboBox.SelectedIndex + 1;
			this.displayChar();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000271C File Offset: 0x0000091C
		private void displayChar()
		{
			this.LoadClasses();
			this.LoadAccessories();
			byte[] array = new byte[1108];
			byte[] array2 = new byte[1108];
			byte[] array3 = new byte[1108];
			byte[] array4 = new byte[1108];
			byte[] array5 = new byte[1108];
			byte[] array6 = new byte[1108];
			byte[] array7 = new byte[1108];
			byte[] array8 = new byte[1108];
			byte[] array9 = new byte[1108];
			byte[] array10 = new byte[1108];
			byte[] array11 = new byte[1108];
			byte[] array12 = new byte[1108];
			byte[] array13 = new byte[1108];
			byte[] array14 = new byte[1108];
			byte[] array15 = new byte[1108];
			byte[] array16 = new byte[1108];
			byte[] array17 = new byte[1108];
			byte[] array18 = new byte[1108];
			byte[] array19 = new byte[1108];
			byte[] array20 = new byte[1108];
			Array.Copy(Main.SaveData, 1088, array, 0, 1108);
			Array.Copy(Main.SaveData, 2196, array2, 0, 1108);
			Array.Copy(Main.SaveData, 3304, array3, 0, 1108);
			Array.Copy(Main.SaveData, 4412, array4, 0, 1108);
			Array.Copy(Main.SaveData, 5520, array5, 0, 1108);
			Array.Copy(Main.SaveData, 6628, array6, 0, 1108);
			Array.Copy(Main.SaveData, 7736, array7, 0, 1108);
			Array.Copy(Main.SaveData, 8844, array8, 0, 1108);
			Array.Copy(Main.SaveData, 9952, array9, 0, 1108);
			Array.Copy(Main.SaveData, 11060, array10, 0, 1108);
			Array.Copy(Main.SaveData, 12168, array11, 0, 1108);
			Array.Copy(Main.SaveData, 13276, array12, 0, 1108);
			Array.Copy(Main.SaveData, 14384, array13, 0, 1108);
			Array.Copy(Main.SaveData, 15492, array14, 0, 1108);
			Array.Copy(Main.SaveData, 16600, array15, 0, 1108);
			Array.Copy(Main.SaveData, 17708, array16, 0, 1108);
			Array.Copy(Main.SaveData, 18816, array17, 0, 1108);
			Array.Copy(Main.SaveData, 19924, array18, 0, 1108);
			Array.Copy(Main.SaveData, 21032, array19, 0, 1108);
			Array.Copy(Main.SaveData, 22140, array20, 0, 1108);
			if (this.charSlotComboBox.SelectedIndex == 0)
			{
				byte[] array21 = new byte[]
				{
					array[0],
					array[2],
					array[4],
					array[6],
					array[8],
					array[10],
					array[12],
					array[14]
				};
				this.charNameTextBox.Text = Encoding.UTF8.GetString(array21);
				this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array[48]) - 1);
				this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array, 60);
				this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array, 64);
				this.charClassComboBox.SelectedValue = Convert.ToInt32(array[44]);
				this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array, 72);
				this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array, 76);
				this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array, 68);
				this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array, 78);
				this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array, 70);
				this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array, 74);
				this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array, 80);
				if (Convert.ToInt32(array[44]) == 0)
				{
					this.LoadSamuraiWeapons();
					int num = (int)BitConverter.ToUInt64(array, 84);
					this.charWepComboBox.SelectedValue = num;
					if (this.charWepComboBox.Text == "")
					{
						this.charWepComboBox.Text = "Not found - " + num;
					}
				}
				else if (Convert.ToInt32(array[44]) == 2)
				{
					this.LoadGodHandWeapons();
					int num2 = (int)BitConverter.ToUInt64(array, 84);
					this.charWepComboBox.SelectedValue = num2;
					if (this.charWepComboBox.Text == "")
					{
						this.charWepComboBox.Text = "Not found - " + num2;
					}
				}
				int num3 = (int)BitConverter.ToUInt64(array, 92);
				this.charAcc1ComboBox.SelectedValue = num3;
				if (this.charAcc1ComboBox.Text == "")
				{
					this.charAcc1ComboBox.Text = "Not found - " + num3;
				}
				int num4 = (int)BitConverter.ToUInt64(array, 96);
				this.charAcc2ComboBox.SelectedValue = num4;
				if (this.charAcc2ComboBox.Text == "")
				{
					this.charAcc2ComboBox.Text = "Not found - ";
				}
				int num5 = (int)array[45];
				int num6 = (int)array[46];
				int num7 = (int)array[106];
				string text = "_" + num5.ToString() + num6.ToString() + num7.ToString();
				object @object = Resources.ResourceManager.GetObject(text);
				if (@object is Image)
				{
					this.charPortraitPictureBox.Image = (Image)@object;
					return;
				}
				this.charPortraitPictureBox.Image = null;
				return;
			}
			else
			{
				if (this.charSlotComboBox.SelectedIndex == 1)
				{
					byte[] array22 = new byte[]
					{
						array2[0],
						array2[2],
						array2[4],
						array2[6],
						array2[8],
						array2[10],
						array2[12],
						array2[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array22);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array2[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array2, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array2, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array2[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array2, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array2, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array2, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array2, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array2, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array2, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array2, 80);
					if (Convert.ToInt32(array2[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num8 = (int)BitConverter.ToUInt64(array2, 84);
						this.charWepComboBox.SelectedValue = num8;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num8;
						}
					}
					else if (Convert.ToInt32(array2[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num9 = (int)BitConverter.ToUInt64(array2, 84);
						this.charWepComboBox.SelectedValue = num9;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num9;
						}
					}
					int num10 = (int)BitConverter.ToUInt64(array2, 92);
					this.charAcc1ComboBox.SelectedValue = num10;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num10;
					}
					int num11 = (int)BitConverter.ToUInt64(array2, 96);
					this.charAcc2ComboBox.SelectedValue = num11;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num12 = (int)array2[45];
					int num13 = (int)array2[46];
					int num14 = (int)array2[106];
					string text2 = "_" + num12.ToString() + num13.ToString() + num14.ToString();
					object object2 = Resources.ResourceManager.GetObject(text2);
					this.charPortraitPictureBox.Image = (Image)object2;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 2)
				{
					byte[] array23 = new byte[]
					{
						array3[0],
						array3[2],
						array3[4],
						array3[6],
						array3[8],
						array3[10],
						array3[12],
						array3[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array23);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array3[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array3, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array3, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array3[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array3, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array3, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array3, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array3, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array3, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array3, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array3, 80);
					if (Convert.ToInt32(array3[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num15 = (int)BitConverter.ToUInt64(array3, 84);
						this.charWepComboBox.SelectedValue = num15;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num15;
						}
					}
					else if (Convert.ToInt32(array3[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num16 = (int)BitConverter.ToUInt64(array3, 84);
						this.charWepComboBox.SelectedValue = num16;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num16;
						}
					}
					int num17 = (int)BitConverter.ToUInt64(array3, 92);
					this.charAcc1ComboBox.SelectedValue = num17;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num17;
					}
					int num18 = (int)BitConverter.ToUInt64(array3, 96);
					this.charAcc2ComboBox.SelectedValue = num18;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num19 = (int)array3[45];
					int num20 = (int)array3[46];
					int num21 = (int)array3[106];
					string text3 = "_" + num19.ToString() + num20.ToString() + num21.ToString();
					object object3 = Resources.ResourceManager.GetObject(text3);
					this.charPortraitPictureBox.Image = (Image)object3;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 3)
				{
					byte[] array24 = new byte[]
					{
						array4[0],
						array4[2],
						array4[4],
						array4[6],
						array4[8],
						array4[10],
						array4[12],
						array4[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array24);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array4[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array4, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array4, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array4[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array4, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array4, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array4, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array4, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array4, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array4, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array4, 80);
					if (Convert.ToInt32(array4[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num22 = (int)BitConverter.ToUInt64(array4, 84);
						this.charWepComboBox.SelectedValue = num22;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num22;
						}
					}
					else if (Convert.ToInt32(array4[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num23 = (int)BitConverter.ToUInt64(array4, 84);
						this.charWepComboBox.SelectedValue = num23;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num23;
						}
					}
					int num24 = (int)BitConverter.ToUInt64(array4, 92);
					this.charAcc1ComboBox.SelectedValue = num24;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num24;
					}
					int num25 = (int)BitConverter.ToUInt64(array4, 96);
					this.charAcc2ComboBox.SelectedValue = num25;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num26 = (int)array4[45];
					int num27 = (int)array4[46];
					int num28 = (int)array4[106];
					string text4 = "_" + num26.ToString() + num27.ToString() + num28.ToString();
					object object4 = Resources.ResourceManager.GetObject(text4);
					this.charPortraitPictureBox.Image = (Image)object4;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 4)
				{
					byte[] array25 = new byte[]
					{
						array5[0],
						array5[2],
						array5[4],
						array5[6],
						array5[8],
						array5[10],
						array5[12],
						array5[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array25);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array5[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array5, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array5, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array5[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array5, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array5, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array5, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array5, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array5, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array5, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array5, 80);
					if (Convert.ToInt32(array5[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num29 = (int)BitConverter.ToUInt64(array5, 84);
						this.charWepComboBox.SelectedValue = num29;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num29;
						}
					}
					else if (Convert.ToInt32(array5[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num30 = (int)BitConverter.ToUInt64(array5, 84);
						this.charWepComboBox.SelectedValue = num30;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num30;
						}
					}
					int num31 = (int)BitConverter.ToUInt64(array5, 92);
					this.charAcc1ComboBox.SelectedValue = num31;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num31;
					}
					int num32 = (int)BitConverter.ToUInt64(array5, 96);
					this.charAcc2ComboBox.SelectedValue = num32;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num33 = (int)array5[45];
					int num34 = (int)array5[46];
					int num35 = (int)array5[106];
					string text5 = "_" + num33.ToString() + num34.ToString() + num35.ToString();
					object object5 = Resources.ResourceManager.GetObject(text5);
					this.charPortraitPictureBox.Image = (Image)object5;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 5)
				{
					byte[] array26 = new byte[]
					{
						array6[0],
						array6[2],
						array6[4],
						array6[6],
						array6[8],
						array6[10],
						array6[12],
						array6[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array26);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array6[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array6, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array6, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array6[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array6, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array6, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array6, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array6, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array6, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array6, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array6, 80);
					if (Convert.ToInt32(array6[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num36 = (int)BitConverter.ToUInt64(array6, 84);
						this.charWepComboBox.SelectedValue = num36;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num36;
						}
					}
					else if (Convert.ToInt32(array6[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num37 = (int)BitConverter.ToUInt64(array6, 84);
						this.charWepComboBox.SelectedValue = num37;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num37;
						}
					}
					int num38 = (int)BitConverter.ToUInt64(array6, 92);
					this.charAcc1ComboBox.SelectedValue = num38;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num38;
					}
					int num39 = (int)BitConverter.ToUInt64(array6, 96);
					this.charAcc2ComboBox.SelectedValue = num39;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num40 = (int)array6[45];
					int num41 = (int)array6[46];
					int num42 = (int)array6[106];
					string text6 = "_" + num40.ToString() + num41.ToString() + num42.ToString();
					object object6 = Resources.ResourceManager.GetObject(text6);
					this.charPortraitPictureBox.Image = (Image)object6;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 6)
				{
					byte[] array27 = new byte[]
					{
						array7[0],
						array7[2],
						array7[4],
						array7[6],
						array7[8],
						array7[10],
						array7[12],
						array7[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array27);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array7[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array7, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array7, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array7[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array7, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array7, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array7, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array7, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array7, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array7, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array7, 80);
					if (Convert.ToInt32(array7[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num43 = (int)BitConverter.ToUInt64(array7, 84);
						this.charWepComboBox.SelectedValue = num43;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num43;
						}
					}
					else if (Convert.ToInt32(array7[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num44 = (int)BitConverter.ToUInt64(array7, 84);
						this.charWepComboBox.SelectedValue = num44;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num44;
						}
					}
					int num45 = (int)BitConverter.ToUInt64(array7, 92);
					this.charAcc1ComboBox.SelectedValue = num45;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num45;
					}
					int num46 = (int)BitConverter.ToUInt64(array7, 96);
					this.charAcc2ComboBox.SelectedValue = num46;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num47 = (int)array7[45];
					int num48 = (int)array7[46];
					int num49 = (int)array7[106];
					string text7 = "_" + num47.ToString() + num48.ToString() + num49.ToString();
					object object7 = Resources.ResourceManager.GetObject(text7);
					this.charPortraitPictureBox.Image = (Image)object7;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 7)
				{
					byte[] array28 = new byte[]
					{
						array8[0],
						array8[2],
						array8[4],
						array8[6],
						array8[8],
						array8[10],
						array8[12],
						array8[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array28);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array8[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array8, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array8, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array8[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array8, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array8, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array8, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array8, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array8, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array8, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array8, 80);
					if (Convert.ToInt32(array8[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num50 = (int)BitConverter.ToUInt64(array8, 84);
						this.charWepComboBox.SelectedValue = num50;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num50;
						}
					}
					else if (Convert.ToInt32(array8[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num51 = (int)BitConverter.ToUInt64(array8, 84);
						this.charWepComboBox.SelectedValue = num51;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num51;
						}
					}
					int num52 = (int)BitConverter.ToUInt64(array8, 92);
					this.charAcc1ComboBox.SelectedValue = num52;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num52;
					}
					int num53 = (int)BitConverter.ToUInt64(array8, 96);
					this.charAcc2ComboBox.SelectedValue = num53;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num54 = (int)array8[45];
					int num55 = (int)array8[46];
					int num56 = (int)array8[106];
					string text8 = "_" + num54.ToString() + num55.ToString() + num56.ToString();
					object object8 = Resources.ResourceManager.GetObject(text8);
					this.charPortraitPictureBox.Image = (Image)object8;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 8)
				{
					byte[] array29 = new byte[]
					{
						array9[0],
						array9[2],
						array9[4],
						array9[6],
						array9[8],
						array9[10],
						array9[12],
						array9[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array29);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array9[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array9, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array9, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array9[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array9, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array9, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array9, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array9, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array9, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array9, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array9, 80);
					if (Convert.ToInt32(array9[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num57 = (int)BitConverter.ToUInt64(array9, 84);
						this.charWepComboBox.SelectedValue = num57;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num57;
						}
					}
					else if (Convert.ToInt32(array9[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num58 = (int)BitConverter.ToUInt64(array9, 84);
						this.charWepComboBox.SelectedValue = num58;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num58;
						}
					}
					int num59 = (int)BitConverter.ToUInt64(array9, 92);
					this.charAcc1ComboBox.SelectedValue = num59;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num59;
					}
					int num60 = (int)BitConverter.ToUInt64(array9, 96);
					this.charAcc2ComboBox.SelectedValue = num60;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num61 = (int)array9[45];
					int num62 = (int)array9[46];
					int num63 = (int)array9[106];
					string text9 = "_" + num61.ToString() + num62.ToString() + num63.ToString();
					object object9 = Resources.ResourceManager.GetObject(text9);
					this.charPortraitPictureBox.Image = (Image)object9;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 9)
				{
					byte[] array30 = new byte[]
					{
						array10[0],
						array10[2],
						array10[4],
						array10[6],
						array10[8],
						array10[10],
						array10[12],
						array10[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array30);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array10[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array10, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array10, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array10[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array10, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array10, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array10, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array10, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array10, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array10, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array10, 80);
					if (Convert.ToInt32(array10[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num64 = (int)BitConverter.ToUInt64(array10, 84);
						this.charWepComboBox.SelectedValue = num64;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num64;
						}
					}
					else if (Convert.ToInt32(array10[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num65 = (int)BitConverter.ToUInt64(array10, 84);
						this.charWepComboBox.SelectedValue = num65;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num65;
						}
					}
					int num66 = (int)BitConverter.ToUInt64(array10, 92);
					this.charAcc1ComboBox.SelectedValue = num66;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num66;
					}
					int num67 = (int)BitConverter.ToUInt64(array10, 96);
					this.charAcc2ComboBox.SelectedValue = num67;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num68 = (int)array10[45];
					int num69 = (int)array10[46];
					int num70 = (int)array10[106];
					string text10 = "_" + num68.ToString() + num69.ToString() + num70.ToString();
					object object10 = Resources.ResourceManager.GetObject(text10);
					this.charPortraitPictureBox.Image = (Image)object10;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 10)
				{
					byte[] array31 = new byte[]
					{
						array11[0],
						array11[2],
						array11[4],
						array11[6],
						array11[8],
						array11[10],
						array11[12],
						array11[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array31);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array11[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array11, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array11, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array11[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array11, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array11, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array11, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array11, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array11, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array11, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array11, 80);
					if (Convert.ToInt32(array11[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num71 = (int)BitConverter.ToUInt64(array11, 84);
						this.charWepComboBox.SelectedValue = num71;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num71;
						}
					}
					else if (Convert.ToInt32(array11[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num72 = (int)BitConverter.ToUInt64(array11, 84);
						this.charWepComboBox.SelectedValue = num72;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num72;
						}
					}
					int num73 = (int)BitConverter.ToUInt64(array11, 92);
					this.charAcc1ComboBox.SelectedValue = num73;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num73;
					}
					int num74 = (int)BitConverter.ToUInt64(array11, 96);
					this.charAcc2ComboBox.SelectedValue = num74;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num75 = (int)array11[45];
					int num76 = (int)array11[46];
					int num77 = (int)array11[106];
					string text11 = "_" + num75.ToString() + num76.ToString() + num77.ToString();
					object object11 = Resources.ResourceManager.GetObject(text11);
					this.charPortraitPictureBox.Image = (Image)object11;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 11)
				{
					byte[] array32 = new byte[]
					{
						array12[0],
						array12[2],
						array12[4],
						array12[6],
						array12[8],
						array12[10],
						array12[12],
						array12[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array32);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array12[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array12, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array12, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array12[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array12, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array12, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array12, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array12, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array12, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array12, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array12, 80);
					if (Convert.ToInt32(array12[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num78 = (int)BitConverter.ToUInt64(array12, 84);
						this.charWepComboBox.SelectedValue = num78;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num78;
						}
					}
					else if (Convert.ToInt32(array12[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num79 = (int)BitConverter.ToUInt64(array12, 84);
						this.charWepComboBox.SelectedValue = num79;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num79;
						}
					}
					int num80 = (int)BitConverter.ToUInt64(array12, 92);
					this.charAcc1ComboBox.SelectedValue = num80;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num80;
					}
					int num81 = (int)BitConverter.ToUInt64(array12, 96);
					this.charAcc2ComboBox.SelectedValue = num81;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num82 = (int)array12[45];
					int num83 = (int)array12[46];
					int num84 = (int)array12[106];
					string text12 = "_" + num82.ToString() + num83.ToString() + num84.ToString();
					object object12 = Resources.ResourceManager.GetObject(text12);
					this.charPortraitPictureBox.Image = (Image)object12;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 12)
				{
					byte[] array33 = new byte[]
					{
						array13[0],
						array13[2],
						array13[4],
						array13[6],
						array13[8],
						array13[10],
						array13[12],
						array13[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array33);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array13[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array13, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array13, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array13[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array13, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array13, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array13, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array13, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array13, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array13, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array13, 80);
					if (Convert.ToInt32(array13[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num85 = (int)BitConverter.ToUInt64(array13, 84);
						this.charWepComboBox.SelectedValue = num85;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num85;
						}
					}
					else if (Convert.ToInt32(array13[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num86 = (int)BitConverter.ToUInt64(array13, 84);
						this.charWepComboBox.SelectedValue = num86;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num86;
						}
					}
					int num87 = (int)BitConverter.ToUInt64(array13, 92);
					this.charAcc1ComboBox.SelectedValue = num87;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num87;
					}
					int num88 = (int)BitConverter.ToUInt64(array13, 96);
					this.charAcc2ComboBox.SelectedValue = num88;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num89 = (int)array13[45];
					int num90 = (int)array13[46];
					int num91 = (int)array13[106];
					string text13 = "_" + num89.ToString() + num90.ToString() + num91.ToString();
					object object13 = Resources.ResourceManager.GetObject(text13);
					this.charPortraitPictureBox.Image = (Image)object13;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 13)
				{
					byte[] array34 = new byte[]
					{
						array14[0],
						array14[2],
						array14[4],
						array14[6],
						array14[8],
						array14[10],
						array14[12],
						array14[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array34);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array14[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array14, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array14, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array14[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array14, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array14, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array14, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array14, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array14, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array14, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array14, 80);
					if (Convert.ToInt32(array14[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num92 = (int)BitConverter.ToUInt64(array14, 84);
						this.charWepComboBox.SelectedValue = num92;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num92;
						}
					}
					else if (Convert.ToInt32(array14[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num93 = (int)BitConverter.ToUInt64(array14, 84);
						this.charWepComboBox.SelectedValue = num93;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num93;
						}
					}
					int num94 = (int)BitConverter.ToUInt64(array14, 92);
					this.charAcc1ComboBox.SelectedValue = num94;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num94;
					}
					int num95 = (int)BitConverter.ToUInt64(array14, 96);
					this.charAcc2ComboBox.SelectedValue = num95;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num96 = (int)array14[45];
					int num97 = (int)array14[46];
					int num98 = (int)array14[106];
					string text14 = "_" + num96.ToString() + num97.ToString() + num98.ToString();
					object object14 = Resources.ResourceManager.GetObject(text14);
					this.charPortraitPictureBox.Image = (Image)object14;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 14)
				{
					byte[] array35 = new byte[]
					{
						array15[0],
						array15[2],
						array15[4],
						array15[6],
						array15[8],
						array15[10],
						array15[12],
						array15[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array35);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array15[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array15, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array15, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array15[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array15, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array15, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array15, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array15, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array15, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array15, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array15, 80);
					if (Convert.ToInt32(array15[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num99 = (int)BitConverter.ToUInt64(array15, 84);
						this.charWepComboBox.SelectedValue = num99;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num99;
						}
					}
					else if (Convert.ToInt32(array15[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num100 = (int)BitConverter.ToUInt64(array15, 84);
						this.charWepComboBox.SelectedValue = num100;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num100;
						}
					}
					int num101 = (int)BitConverter.ToUInt64(array15, 92);
					this.charAcc1ComboBox.SelectedValue = num101;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num101;
					}
					int num102 = (int)BitConverter.ToUInt64(array15, 96);
					this.charAcc2ComboBox.SelectedValue = num102;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num103 = (int)array15[45];
					int num104 = (int)array15[46];
					int num105 = (int)array15[106];
					string text15 = "_" + num103.ToString() + num104.ToString() + num105.ToString();
					object object15 = Resources.ResourceManager.GetObject(text15);
					this.charPortraitPictureBox.Image = (Image)object15;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 15)
				{
					byte[] array36 = new byte[]
					{
						array16[0],
						array16[2],
						array16[4],
						array16[6],
						array16[8],
						array16[10],
						array16[12],
						array16[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array36);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array16[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array16, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array16, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array16[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array16, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array16, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array16, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array16, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array16, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array16, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array16, 80);
					if (Convert.ToInt32(array16[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num106 = (int)BitConverter.ToUInt64(array16, 84);
						this.charWepComboBox.SelectedValue = num106;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num106;
						}
					}
					else if (Convert.ToInt32(array16[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num107 = (int)BitConverter.ToUInt64(array16, 84);
						this.charWepComboBox.SelectedValue = num107;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num107;
						}
					}
					int num108 = (int)BitConverter.ToUInt64(array16, 92);
					this.charAcc1ComboBox.SelectedValue = num108;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num108;
					}
					int num109 = (int)BitConverter.ToUInt64(array16, 96);
					this.charAcc2ComboBox.SelectedValue = num109;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num110 = (int)array16[45];
					int num111 = (int)array16[46];
					int num112 = (int)array16[106];
					string text16 = "_" + num110.ToString() + num111.ToString() + num112.ToString();
					object object16 = Resources.ResourceManager.GetObject(text16);
					this.charPortraitPictureBox.Image = (Image)object16;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 16)
				{
					byte[] array37 = new byte[]
					{
						array17[0],
						array17[2],
						array17[4],
						array17[6],
						array17[8],
						array17[10],
						array17[12],
						array17[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array37);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array17[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array17, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array17, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array17[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array17, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array17, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array17, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array17, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array17, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array17, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array17, 80);
					if (Convert.ToInt32(array17[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num113 = (int)BitConverter.ToUInt64(array17, 84);
						this.charWepComboBox.SelectedValue = num113;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num113;
						}
					}
					else if (Convert.ToInt32(array17[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num114 = (int)BitConverter.ToUInt64(array17, 84);
						this.charWepComboBox.SelectedValue = num114;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num114;
						}
					}
					int num115 = (int)BitConverter.ToUInt64(array17, 92);
					this.charAcc1ComboBox.SelectedValue = num115;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num115;
					}
					int num116 = (int)BitConverter.ToUInt64(array17, 96);
					this.charAcc2ComboBox.SelectedValue = num116;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num117 = (int)array17[45];
					int num118 = (int)array17[46];
					int num119 = (int)array17[106];
					string text17 = "_" + num117.ToString() + num118.ToString() + num119.ToString();
					object object17 = Resources.ResourceManager.GetObject(text17);
					this.charPortraitPictureBox.Image = (Image)object17;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 17)
				{
					byte[] array38 = new byte[]
					{
						array18[0],
						array18[2],
						array18[4],
						array18[6],
						array18[8],
						array18[10],
						array18[12],
						array18[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array38);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array18[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array18, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array18, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array18[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array18, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array18, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array18, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array18, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array18, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array18, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array18, 80);
					if (Convert.ToInt32(array18[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num120 = (int)BitConverter.ToUInt64(array18, 84);
						this.charWepComboBox.SelectedValue = num120;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num120;
						}
					}
					else if (Convert.ToInt32(array18[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num121 = (int)BitConverter.ToUInt64(array18, 84);
						this.charWepComboBox.SelectedValue = num121;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num121;
						}
					}
					int num122 = (int)BitConverter.ToUInt64(array18, 92);
					this.charAcc1ComboBox.SelectedValue = num122;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num122;
					}
					int num123 = (int)BitConverter.ToUInt64(array18, 96);
					this.charAcc2ComboBox.SelectedValue = num123;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num124 = (int)array18[45];
					int num125 = (int)array18[46];
					int num126 = (int)array18[106];
					string text18 = "_" + num124.ToString() + num125.ToString() + num126.ToString();
					object object18 = Resources.ResourceManager.GetObject(text18);
					this.charPortraitPictureBox.Image = (Image)object18;
					return;
				}
				if (this.charSlotComboBox.SelectedIndex == 18)
				{
					byte[] array39 = new byte[]
					{
						array19[0],
						array19[2],
						array19[4],
						array19[6],
						array19[8],
						array19[10],
						array19[12],
						array19[14]
					};
					this.charNameTextBox.Text = Encoding.UTF8.GetString(array39);
					this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array19[48]) - 1);
					this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array19, 60);
					this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array19, 64);
					this.charClassComboBox.SelectedValue = Convert.ToInt32(array19[44]);
					this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array19, 72);
					this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array19, 76);
					this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array19, 68);
					this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array19, 78);
					this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array19, 70);
					this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array19, 74);
					this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array19, 80);
					if (Convert.ToInt32(array19[44]) == 0)
					{
						this.LoadSamuraiWeapons();
						int num127 = (int)BitConverter.ToUInt64(array19, 84);
						this.charWepComboBox.SelectedValue = num127;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num127;
						}
					}
					else if (Convert.ToInt32(array19[44]) == 2)
					{
						this.LoadGodHandWeapons();
						int num128 = (int)BitConverter.ToUInt64(array19, 84);
						this.charWepComboBox.SelectedValue = num128;
						if (this.charWepComboBox.Text == "")
						{
							this.charWepComboBox.Text = "Not found - " + num128;
						}
					}
					int num129 = (int)BitConverter.ToUInt64(array19, 92);
					this.charAcc1ComboBox.SelectedValue = num129;
					if (this.charAcc1ComboBox.Text == "")
					{
						this.charAcc1ComboBox.Text = "Not found - " + num129;
					}
					int num130 = (int)BitConverter.ToUInt64(array19, 96);
					this.charAcc2ComboBox.SelectedValue = num130;
					if (this.charAcc2ComboBox.Text == "")
					{
						this.charAcc2ComboBox.Text = "Not found - ";
					}
					int num131 = (int)array19[45];
					int num132 = (int)array19[46];
					int num133 = (int)array19[106];
					string text19 = "_" + num131.ToString() + num132.ToString() + num133.ToString();
					object object19 = Resources.ResourceManager.GetObject(text19);
					this.charPortraitPictureBox.Image = (Image)object19;
					return;
				}
				byte[] array40 = new byte[]
				{
					array20[0],
					array20[2],
					array20[4],
					array20[6],
					array20[8],
					array20[10],
					array20[12],
					array20[14]
				};
				this.charNameTextBox.Text = Encoding.UTF8.GetString(array40);
				this.charLevelComboBox.SelectedIndex = (int)(Convert.ToInt16(array20[48]) - 1);
				this.charExpNumericUpDown.Value = BitConverter.ToUInt32(array20, 60);
				this.charSPNumericUpDown.Value = BitConverter.ToUInt32(array20, 64);
				this.charClassComboBox.SelectedValue = Convert.ToInt32(array20[44]);
				this.bonusHPNumericUpDown.Value = BitConverter.ToUInt16(array20, 72);
				this.bonusManaNumericUpDown.Value = BitConverter.ToUInt16(array20, 76);
				this.bonusATKNumericUpDown.Value = BitConverter.ToUInt16(array20, 68);
				this.bonusDEFNumericUpDown.Value = BitConverter.ToUInt16(array20, 78);
				this.bonusSPDNumericUpDown.Value = BitConverter.ToUInt16(array20, 70);
				this.bonusMATNumericUpDown.Value = BitConverter.ToUInt16(array20, 74);
				this.bonusMDFNumericUpDown.Value = BitConverter.ToUInt16(array20, 80);
				if (Convert.ToInt32(array20[44]) == 0)
				{
					this.LoadSamuraiWeapons();
					int num134 = (int)BitConverter.ToUInt64(array20, 84);
					this.charWepComboBox.SelectedValue = num134;
					if (this.charWepComboBox.Text == "")
					{
						this.charWepComboBox.Text = "Not found - " + num134;
					}
				}
				else if (Convert.ToInt32(array20[44]) == 2)
				{
					this.LoadGodHandWeapons();
					int num135 = (int)BitConverter.ToUInt64(array20, 84);
					this.charWepComboBox.SelectedValue = num135;
					if (this.charWepComboBox.Text == "")
					{
						this.charWepComboBox.Text = "Not found - " + num135;
					}
				}
				int num136 = (int)BitConverter.ToUInt64(array20, 92);
				this.charAcc1ComboBox.SelectedValue = num136;
				if (this.charAcc1ComboBox.Text == "")
				{
					this.charAcc1ComboBox.Text = "Not found - " + num136;
				}
				int num137 = (int)BitConverter.ToUInt64(array20, 96);
				this.charAcc2ComboBox.SelectedValue = num137;
				if (this.charAcc2ComboBox.Text == "")
				{
					this.charAcc2ComboBox.Text = "Not found - ";
				}
				int num138 = (int)array20[45];
				int num139 = (int)array20[46];
				int num140 = (int)array20[106];
				string text20 = "_" + num138.ToString() + num139.ToString() + num140.ToString();
				object object20 = Resources.ResourceManager.GetObject(text20);
				this.charPortraitPictureBox.Image = (Image)object20;
				return;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000069BE File Offset: 0x00004BBE
		private void CharacterEditing_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveCharacters();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000069C8 File Offset: 0x00004BC8
		private void SaveCharacters()
		{
			if (this.currentSlot == 1)
			{
				byte[] array = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array, 0);
				int num = 0;
				for (int i = 1088; i <= 1102; i += 2)
				{
					Main.SaveData[i] = array[num];
					num++;
				}
				Main.SaveData[1136] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num2 = 0;
				for (int j = 1148; j <= 1151; j++)
				{
					Main.SaveData[j] = bytes[num2];
					num2++;
				}
				byte[] bytes2 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num3 = 0;
				for (int k = 1152; k <= 1154; k++)
				{
					Main.SaveData[k] = bytes2[num3];
					num3++;
				}
				byte[] bytes3 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[1160] = bytes3[0];
				Main.SaveData[1161] = bytes3[1];
				byte[] bytes4 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[1164] = bytes4[0];
				Main.SaveData[1165] = bytes4[1];
				byte[] bytes5 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[1156] = bytes5[0];
				Main.SaveData[1157] = bytes5[1];
				byte[] bytes6 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[1166] = bytes6[0];
				Main.SaveData[1167] = bytes6[1];
				byte[] bytes7 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[1158] = bytes7[0];
				Main.SaveData[1159] = bytes7[1];
				byte[] bytes8 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[1162] = bytes8[0];
				Main.SaveData[1163] = bytes8[1];
				byte[] bytes9 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[1168] = bytes9[0];
				Main.SaveData[1169] = bytes9[1];
			}
			if (this.currentSlot == 2)
			{
				byte[] array2 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array2, 0);
				int num4 = 0;
				for (int l = 2196; l <= 2211; l += 2)
				{
					Main.SaveData[l] = array2[num4];
					num4++;
				}
				Main.SaveData[2244] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes10 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num5 = 0;
				for (int m = 2256; m <= 2258; m++)
				{
					Main.SaveData[m] = bytes10[num5];
					num5++;
				}
				byte[] bytes11 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num6 = 0;
				for (int n = 2260; n <= 2262; n++)
				{
					Main.SaveData[n] = bytes11[num6];
					num6++;
				}
				byte[] bytes12 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[2268] = bytes12[0];
				Main.SaveData[2269] = bytes12[1];
				byte[] bytes13 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[2272] = bytes13[0];
				Main.SaveData[2273] = bytes13[1];
				byte[] bytes14 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[2264] = bytes14[0];
				Main.SaveData[2265] = bytes14[1];
				byte[] bytes15 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[2274] = bytes15[0];
				Main.SaveData[2275] = bytes15[1];
				byte[] bytes16 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[2266] = bytes16[0];
				Main.SaveData[2267] = bytes16[1];
				byte[] bytes17 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[2270] = bytes17[0];
				Main.SaveData[2271] = bytes17[1];
				byte[] bytes18 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[2276] = bytes18[0];
				Main.SaveData[2277] = bytes18[1];
			}
			if (this.currentSlot == 3)
			{
				byte[] array3 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array3, 0);
				int num7 = 0;
				for (int num8 = 3304; num8 <= 3319; num8 += 2)
				{
					Main.SaveData[num8] = array3[num7];
					num7++;
				}
				Main.SaveData[3352] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes19 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num9 = 0;
				for (int num10 = 3364; num10 <= 3366; num10++)
				{
					Main.SaveData[num10] = bytes19[num9];
					num9++;
				}
				byte[] bytes20 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num11 = 0;
				for (int num12 = 3368; num12 <= 3370; num12++)
				{
					Main.SaveData[num12] = bytes20[num11];
					num11++;
				}
				byte[] bytes21 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[3372] = bytes21[0];
				Main.SaveData[3373] = bytes21[1];
				byte[] bytes22 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[3374] = bytes22[0];
				Main.SaveData[3375] = bytes22[1];
				byte[] bytes23 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[3376] = bytes23[0];
				Main.SaveData[3377] = bytes23[1];
				byte[] bytes24 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[3378] = bytes24[0];
				Main.SaveData[3379] = bytes24[1];
				byte[] bytes25 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[3380] = bytes25[0];
				Main.SaveData[3381] = bytes25[1];
				byte[] bytes26 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[3382] = bytes26[0];
				Main.SaveData[3383] = bytes26[1];
				byte[] bytes27 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[3384] = bytes27[0];
				Main.SaveData[3385] = bytes27[1];
			}
			if (this.currentSlot == 4)
			{
				byte[] array4 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array4, 0);
				int num13 = 0;
				for (int num14 = 4412; num14 <= 4427; num14 += 2)
				{
					Main.SaveData[num14] = array4[num13];
					num13++;
				}
				Main.SaveData[4460] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes28 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num15 = 0;
				for (int num16 = 4472; num16 <= 4474; num16++)
				{
					Main.SaveData[num16] = bytes28[num15];
					num15++;
				}
				byte[] bytes29 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num17 = 0;
				for (int num18 = 4476; num18 <= 4478; num18++)
				{
					Main.SaveData[num18] = bytes29[num17];
					num17++;
				}
				byte[] bytes30 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[4480] = bytes30[0];
				Main.SaveData[4481] = bytes30[1];
				byte[] bytes31 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[4482] = bytes31[0];
				Main.SaveData[4483] = bytes31[1];
				byte[] bytes32 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[4484] = bytes32[0];
				Main.SaveData[4485] = bytes32[1];
				byte[] bytes33 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[4486] = bytes33[0];
				Main.SaveData[4487] = bytes33[1];
				byte[] bytes34 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[4488] = bytes34[0];
				Main.SaveData[4489] = bytes34[1];
				byte[] bytes35 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[4490] = bytes35[0];
				Main.SaveData[4491] = bytes35[1];
				byte[] bytes36 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[4492] = bytes36[0];
				Main.SaveData[4493] = bytes36[1];
			}
			if (this.currentSlot == 5)
			{
				byte[] array5 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array5, 0);
				int num19 = 0;
				for (int num20 = 5520; num20 <= 5535; num20 += 2)
				{
					Main.SaveData[num20] = array5[num19];
					num19++;
				}
				Main.SaveData[5568] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes37 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num21 = 0;
				for (int num22 = 5580; num22 <= 5582; num22++)
				{
					Main.SaveData[num22] = bytes37[num21];
					num21++;
				}
				byte[] bytes38 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num23 = 0;
				for (int num24 = 5584; num24 <= 5586; num24++)
				{
					Main.SaveData[num24] = bytes38[num23];
					num23++;
				}
				byte[] bytes39 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[5588] = bytes39[0];
				Main.SaveData[5589] = bytes39[1];
				byte[] bytes40 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[5590] = bytes40[0];
				Main.SaveData[5591] = bytes40[1];
				byte[] bytes41 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[5592] = bytes41[0];
				Main.SaveData[5593] = bytes41[1];
				byte[] bytes42 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[5594] = bytes42[0];
				Main.SaveData[5595] = bytes42[1];
				byte[] bytes43 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[5596] = bytes43[0];
				Main.SaveData[5597] = bytes43[1];
				byte[] bytes44 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[5598] = bytes44[0];
				Main.SaveData[5599] = bytes44[1];
				byte[] bytes45 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[5600] = bytes45[0];
				Main.SaveData[5601] = bytes45[1];
			}
			if (this.currentSlot == 6)
			{
				byte[] array6 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array6, 0);
				int num25 = 0;
				for (int num26 = 6628; num26 <= 6643; num26 += 2)
				{
					Main.SaveData[num26] = array6[num25];
					num25++;
				}
				Main.SaveData[6676] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes46 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num27 = 0;
				for (int num28 = 6688; num28 <= 6690; num28++)
				{
					Main.SaveData[num28] = bytes46[num27];
					num27++;
				}
				byte[] bytes47 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num29 = 0;
				for (int num30 = 6692; num30 <= 6694; num30++)
				{
					Main.SaveData[num30] = bytes47[num29];
					num29++;
				}
				byte[] bytes48 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[6696] = bytes48[0];
				Main.SaveData[6697] = bytes48[1];
				byte[] bytes49 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[6698] = bytes49[0];
				Main.SaveData[6699] = bytes49[1];
				byte[] bytes50 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[6700] = bytes50[0];
				Main.SaveData[6701] = bytes50[1];
				byte[] bytes51 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[6702] = bytes51[0];
				Main.SaveData[6703] = bytes51[1];
				byte[] bytes52 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[6704] = bytes52[0];
				Main.SaveData[6705] = bytes52[1];
				byte[] bytes53 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[6706] = bytes53[0];
				Main.SaveData[6707] = bytes53[1];
				byte[] bytes54 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[6708] = bytes54[0];
				Main.SaveData[6709] = bytes54[1];
			}
			if (this.currentSlot == 7)
			{
				byte[] array7 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array7, 0);
				int num31 = 0;
				for (int num32 = 7736; num32 <= 7751; num32 += 2)
				{
					Main.SaveData[num32] = array7[num31];
					num31++;
				}
				Main.SaveData[7784] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes55 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num33 = 0;
				for (int num34 = 7796; num34 <= 7798; num34++)
				{
					Main.SaveData[num34] = bytes55[num33];
					num33++;
				}
				byte[] bytes56 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num35 = 0;
				for (int num36 = 7800; num36 <= 7802; num36++)
				{
					Main.SaveData[num36] = bytes56[num35];
					num35++;
				}
				byte[] bytes57 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[7804] = bytes57[0];
				Main.SaveData[7805] = bytes57[1];
				byte[] bytes58 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[7806] = bytes58[0];
				Main.SaveData[7807] = bytes58[1];
				byte[] bytes59 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[7808] = bytes59[0];
				Main.SaveData[7809] = bytes59[1];
				byte[] bytes60 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[7810] = bytes60[0];
				Main.SaveData[7811] = bytes60[1];
				byte[] bytes61 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[7812] = bytes61[0];
				Main.SaveData[7813] = bytes61[1];
				byte[] bytes62 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[7814] = bytes62[0];
				Main.SaveData[7815] = bytes62[1];
				byte[] bytes63 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[7816] = bytes63[0];
				Main.SaveData[7817] = bytes63[1];
			}
			if (this.currentSlot == 8)
			{
				byte[] array8 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array8, 0);
				int num37 = 0;
				for (int num38 = 8844; num38 <= 8859; num38 += 2)
				{
					Main.SaveData[num38] = array8[num37];
					num37++;
				}
				Main.SaveData[8892] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes64 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num39 = 0;
				for (int num40 = 8904; num40 <= 8906; num40++)
				{
					Main.SaveData[num40] = bytes64[num39];
					num39++;
				}
				byte[] bytes65 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num41 = 0;
				for (int num42 = 8908; num42 <= 8910; num42++)
				{
					Main.SaveData[num42] = bytes65[num41];
					num41++;
				}
				byte[] bytes66 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[8912] = bytes66[0];
				Main.SaveData[8913] = bytes66[1];
				byte[] bytes67 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[8914] = bytes67[0];
				Main.SaveData[8915] = bytes67[1];
				byte[] bytes68 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[8916] = bytes68[0];
				Main.SaveData[8917] = bytes68[1];
				byte[] bytes69 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[8918] = bytes69[0];
				Main.SaveData[8919] = bytes69[1];
				byte[] bytes70 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[8920] = bytes70[0];
				Main.SaveData[8921] = bytes70[1];
				byte[] bytes71 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[8922] = bytes71[0];
				Main.SaveData[8923] = bytes71[1];
				byte[] bytes72 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[8924] = bytes72[0];
				Main.SaveData[8925] = bytes72[1];
			}
			if (this.currentSlot == 9)
			{
				byte[] array9 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array9, 0);
				int num43 = 0;
				for (int num44 = 9952; num44 <= 9967; num44 += 2)
				{
					Main.SaveData[num44] = array9[num43];
					num43++;
				}
				Main.SaveData[10000] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes73 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num45 = 0;
				for (int num46 = 10012; num46 <= 10014; num46++)
				{
					Main.SaveData[num46] = bytes73[num45];
					num45++;
				}
				byte[] bytes74 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num47 = 0;
				for (int num48 = 10016; num48 <= 10018; num48++)
				{
					Main.SaveData[num48] = bytes74[num47];
					num47++;
				}
				byte[] bytes75 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[10020] = bytes75[0];
				Main.SaveData[10021] = bytes75[1];
				byte[] bytes76 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[10022] = bytes76[0];
				Main.SaveData[10023] = bytes76[1];
				byte[] bytes77 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[10024] = bytes77[0];
				Main.SaveData[10025] = bytes77[1];
				byte[] bytes78 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[10026] = bytes78[0];
				Main.SaveData[10027] = bytes78[1];
				byte[] bytes79 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[10028] = bytes79[0];
				Main.SaveData[10029] = bytes79[1];
				byte[] bytes80 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[10030] = bytes80[0];
				Main.SaveData[10031] = bytes80[1];
				byte[] bytes81 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[10032] = bytes81[0];
				Main.SaveData[10033] = bytes81[1];
			}
			if (this.currentSlot == 10)
			{
				byte[] array10 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array10, 0);
				int num49 = 0;
				for (int num50 = 11060; num50 <= 11075; num50 += 2)
				{
					Main.SaveData[num50] = array10[num49];
					num49++;
				}
				Main.SaveData[11108] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes82 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num51 = 0;
				for (int num52 = 11120; num52 <= 11122; num52++)
				{
					Main.SaveData[num52] = bytes82[num51];
					num51++;
				}
				byte[] bytes83 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num53 = 0;
				for (int num54 = 11124; num54 <= 11126; num54++)
				{
					Main.SaveData[num54] = bytes83[num53];
					num53++;
				}
				byte[] bytes84 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[11128] = bytes84[0];
				Main.SaveData[11129] = bytes84[1];
				byte[] bytes85 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[11130] = bytes85[0];
				Main.SaveData[11131] = bytes85[1];
				byte[] bytes86 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[11132] = bytes86[0];
				Main.SaveData[11133] = bytes86[1];
				byte[] bytes87 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[11134] = bytes87[0];
				Main.SaveData[11135] = bytes87[1];
				byte[] bytes88 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[11136] = bytes88[0];
				Main.SaveData[11137] = bytes88[1];
				byte[] bytes89 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[11138] = bytes89[0];
				Main.SaveData[11139] = bytes89[1];
				byte[] bytes90 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[11140] = bytes90[0];
				Main.SaveData[11141] = bytes90[1];
			}
			if (this.currentSlot == 11)
			{
				byte[] array11 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array11, 0);
				int num55 = 0;
				for (int num56 = 12168; num56 <= 12183; num56 += 2)
				{
					Main.SaveData[num56] = array11[num55];
					num55++;
				}
				Main.SaveData[12216] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes91 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num57 = 0;
				for (int num58 = 12228; num58 <= 12230; num58++)
				{
					Main.SaveData[num58] = bytes91[num57];
					num57++;
				}
				byte[] bytes92 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num59 = 0;
				for (int num60 = 12232; num60 <= 12234; num60++)
				{
					Main.SaveData[num60] = bytes92[num59];
					num59++;
				}
				byte[] bytes93 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[12236] = bytes93[0];
				Main.SaveData[12237] = bytes93[1];
				byte[] bytes94 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[12238] = bytes94[0];
				Main.SaveData[12239] = bytes94[1];
				byte[] bytes95 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[12240] = bytes95[0];
				Main.SaveData[12241] = bytes95[1];
				byte[] bytes96 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[12242] = bytes96[0];
				Main.SaveData[12243] = bytes96[1];
				byte[] bytes97 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[12244] = bytes97[0];
				Main.SaveData[12245] = bytes97[1];
				byte[] bytes98 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[12246] = bytes98[0];
				Main.SaveData[12247] = bytes98[1];
				byte[] bytes99 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[12248] = bytes99[0];
				Main.SaveData[12249] = bytes99[1];
			}
			if (this.currentSlot == 12)
			{
				byte[] array12 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array12, 0);
				int num61 = 0;
				for (int num62 = 13276; num62 <= 13291; num62 += 2)
				{
					Main.SaveData[num62] = array12[num61];
					num61++;
				}
				Main.SaveData[13324] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes100 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num63 = 0;
				for (int num64 = 13336; num64 <= 13338; num64++)
				{
					Main.SaveData[num64] = bytes100[num63];
					num63++;
				}
				byte[] bytes101 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num65 = 0;
				for (int num66 = 13340; num66 <= 13342; num66++)
				{
					Main.SaveData[num66] = bytes101[num65];
					num65++;
				}
				byte[] bytes102 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[13344] = bytes102[0];
				Main.SaveData[13345] = bytes102[1];
				byte[] bytes103 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[13346] = bytes103[0];
				Main.SaveData[13347] = bytes103[1];
				byte[] bytes104 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[13348] = bytes104[0];
				Main.SaveData[13349] = bytes104[1];
				byte[] bytes105 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[13350] = bytes105[0];
				Main.SaveData[13351] = bytes105[1];
				byte[] bytes106 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[13352] = bytes106[0];
				Main.SaveData[13353] = bytes106[1];
				byte[] bytes107 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[13354] = bytes107[0];
				Main.SaveData[13355] = bytes107[1];
				byte[] bytes108 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[13356] = bytes108[0];
				Main.SaveData[13357] = bytes108[1];
			}
			if (this.currentSlot == 13)
			{
				byte[] array13 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array13, 0);
				int num67 = 0;
				for (int num68 = 14384; num68 <= 14399; num68 += 2)
				{
					Main.SaveData[num68] = array13[num67];
					num67++;
				}
				Main.SaveData[14432] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes109 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num69 = 0;
				for (int num70 = 14444; num70 <= 14446; num70++)
				{
					Main.SaveData[num70] = bytes109[num69];
					num69++;
				}
				byte[] bytes110 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num71 = 0;
				for (int num72 = 14448; num72 <= 14450; num72++)
				{
					Main.SaveData[num72] = bytes110[num71];
					num71++;
				}
				byte[] bytes111 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[14452] = bytes111[0];
				Main.SaveData[14453] = bytes111[1];
				byte[] bytes112 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[14214] = bytes112[0];
				Main.SaveData[14215] = bytes112[1];
				byte[] bytes113 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[14216] = bytes113[0];
				Main.SaveData[14217] = bytes113[1];
				byte[] bytes114 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[14218] = bytes114[0];
				Main.SaveData[14219] = bytes114[1];
				byte[] bytes115 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[14220] = bytes115[0];
				Main.SaveData[14221] = bytes115[1];
				byte[] bytes116 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[14222] = bytes116[0];
				Main.SaveData[14223] = bytes116[1];
				byte[] bytes117 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[14224] = bytes117[0];
				Main.SaveData[14225] = bytes117[1];
			}
			if (this.currentSlot == 14)
			{
				byte[] array14 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array14, 0);
				int num73 = 0;
				for (int num74 = 15492; num74 <= 15507; num74 += 2)
				{
					Main.SaveData[num74] = array14[num73];
					num73++;
				}
				Main.SaveData[15540] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes118 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num75 = 0;
				for (int num76 = 15552; num76 <= 15554; num76++)
				{
					Main.SaveData[num76] = bytes118[num75];
					num75++;
				}
				byte[] bytes119 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num77 = 0;
				for (int num78 = 15556; num78 <= 15558; num78++)
				{
					Main.SaveData[num78] = bytes119[num77];
					num77++;
				}
				byte[] bytes120 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[15560] = bytes120[0];
				Main.SaveData[15561] = bytes120[1];
				byte[] bytes121 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[15562] = bytes121[0];
				Main.SaveData[15563] = bytes121[1];
				byte[] bytes122 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[15564] = bytes122[0];
				Main.SaveData[15565] = bytes122[1];
				byte[] bytes123 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[15566] = bytes123[0];
				Main.SaveData[15567] = bytes123[1];
				byte[] bytes124 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[15568] = bytes124[0];
				Main.SaveData[15569] = bytes124[1];
				byte[] bytes125 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[15570] = bytes125[0];
				Main.SaveData[15571] = bytes125[1];
				byte[] bytes126 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[15572] = bytes126[0];
				Main.SaveData[15573] = bytes126[1];
			}
			if (this.currentSlot == 15)
			{
				byte[] array15 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array15, 0);
				int num79 = 0;
				for (int num80 = 16600; num80 <= 16615; num80 += 2)
				{
					Main.SaveData[num80] = array15[num79];
					num79++;
				}
				Main.SaveData[16648] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes127 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num81 = 0;
				for (int num82 = 16660; num82 <= 16662; num82++)
				{
					Main.SaveData[num82] = bytes127[num81];
					num81++;
				}
				byte[] bytes128 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num83 = 0;
				for (int num84 = 16664; num84 <= 16666; num84++)
				{
					Main.SaveData[num84] = bytes128[num83];
					num83++;
				}
				byte[] bytes129 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[16668] = bytes129[0];
				Main.SaveData[16669] = bytes129[1];
				byte[] bytes130 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[16670] = bytes130[0];
				Main.SaveData[16671] = bytes130[1];
				byte[] bytes131 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[16672] = bytes131[0];
				Main.SaveData[16673] = bytes131[1];
				byte[] bytes132 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[16674] = bytes132[0];
				Main.SaveData[16675] = bytes132[1];
				byte[] bytes133 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[16676] = bytes133[0];
				Main.SaveData[16677] = bytes133[1];
				byte[] bytes134 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[16678] = bytes134[0];
				Main.SaveData[16679] = bytes134[1];
				byte[] bytes135 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[16680] = bytes135[0];
				Main.SaveData[16681] = bytes135[1];
			}
			if (this.currentSlot == 16)
			{
				byte[] array16 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array16, 0);
				int num85 = 0;
				for (int num86 = 17708; num86 <= 17723; num86 += 2)
				{
					Main.SaveData[num86] = array16[num85];
					num85++;
				}
				Main.SaveData[17756] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes136 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num87 = 0;
				for (int num88 = 17768; num88 <= 17770; num88++)
				{
					Main.SaveData[num88] = bytes136[num87];
					num87++;
				}
				byte[] bytes137 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num89 = 0;
				for (int num90 = 17772; num90 <= 17774; num90++)
				{
					Main.SaveData[num90] = bytes137[num89];
					num89++;
				}
				byte[] bytes138 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[17776] = bytes138[0];
				Main.SaveData[17777] = bytes138[1];
				byte[] bytes139 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[17778] = bytes139[0];
				Main.SaveData[17779] = bytes139[1];
				byte[] bytes140 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[17780] = bytes140[0];
				Main.SaveData[17781] = bytes140[1];
				byte[] bytes141 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[17782] = bytes141[0];
				Main.SaveData[17783] = bytes141[1];
				byte[] bytes142 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[17784] = bytes142[0];
				Main.SaveData[17785] = bytes142[1];
				byte[] bytes143 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[17786] = bytes143[0];
				Main.SaveData[17787] = bytes143[1];
				byte[] bytes144 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[17788] = bytes144[0];
				Main.SaveData[17789] = bytes144[1];
			}
			if (this.currentSlot == 17)
			{
				byte[] array17 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array17, 0);
				int num91 = 0;
				for (int num92 = 18816; num92 <= 18831; num92 += 2)
				{
					Main.SaveData[num92] = array17[num91];
					num91++;
				}
				Main.SaveData[18864] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes145 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num93 = 0;
				for (int num94 = 18876; num94 <= 18878; num94++)
				{
					Main.SaveData[num94] = bytes145[num93];
					num93++;
				}
				byte[] bytes146 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num95 = 0;
				for (int num96 = 18880; num96 <= 18882; num96++)
				{
					Main.SaveData[num96] = bytes146[num95];
					num95++;
				}
				byte[] bytes147 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[18884] = bytes147[0];
				Main.SaveData[18885] = bytes147[1];
				byte[] bytes148 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[18886] = bytes148[0];
				Main.SaveData[18887] = bytes148[1];
				byte[] bytes149 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[18888] = bytes149[0];
				Main.SaveData[18889] = bytes149[1];
				byte[] bytes150 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[18896] = bytes150[0];
				Main.SaveData[18897] = bytes150[1];
				byte[] bytes151 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[18898] = bytes151[0];
				Main.SaveData[18899] = bytes151[1];
				byte[] bytes152 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[18900] = bytes152[0];
				Main.SaveData[18901] = bytes152[1];
				byte[] bytes153 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[18902] = bytes153[0];
				Main.SaveData[18903] = bytes153[1];
			}
			if (this.currentSlot == 18)
			{
				byte[] array18 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array18, 0);
				int num97 = 0;
				for (int num98 = 19924; num98 <= 19939; num98 += 2)
				{
					Main.SaveData[num98] = array18[num97];
					num97++;
				}
				Main.SaveData[19972] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes154 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num99 = 0;
				for (int num100 = 19984; num100 <= 19986; num100++)
				{
					Main.SaveData[num100] = bytes154[num99];
					num99++;
				}
				byte[] bytes155 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num101 = 0;
				for (int num102 = 19988; num102 <= 19990; num102++)
				{
					Main.SaveData[num102] = bytes155[num101];
					num101++;
				}
				byte[] bytes156 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[19992] = bytes156[0];
				Main.SaveData[19993] = bytes156[1];
				byte[] bytes157 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[19994] = bytes157[0];
				Main.SaveData[19995] = bytes157[1];
				byte[] bytes158 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[19996] = bytes158[0];
				Main.SaveData[19997] = bytes158[1];
				byte[] bytes159 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[19998] = bytes159[0];
				Main.SaveData[19999] = bytes159[1];
				byte[] bytes160 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[20000] = bytes160[0];
				Main.SaveData[20001] = bytes160[1];
				byte[] bytes161 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[20002] = bytes161[0];
				Main.SaveData[20003] = bytes161[1];
				byte[] bytes162 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[20004] = bytes162[0];
				Main.SaveData[20005] = bytes162[1];
			}
			if (this.currentSlot == 19)
			{
				byte[] array19 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array19, 0);
				int num103 = 0;
				for (int num104 = 21032; num104 <= 21047; num104 += 2)
				{
					Main.SaveData[num104] = array19[num103];
					num103++;
				}
				Main.SaveData[21080] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes163 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num105 = 0;
				for (int num106 = 21092; num106 <= 21094; num106++)
				{
					Main.SaveData[num106] = bytes163[num105];
					num105++;
				}
				byte[] bytes164 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num107 = 0;
				for (int num108 = 21096; num108 <= 21098; num108++)
				{
					Main.SaveData[num108] = bytes164[num107];
					num107++;
				}
				byte[] bytes165 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[21100] = bytes165[0];
				Main.SaveData[21101] = bytes165[1];
				byte[] bytes166 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[21102] = bytes166[0];
				Main.SaveData[21103] = bytes166[1];
				byte[] bytes167 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[21104] = bytes167[0];
				Main.SaveData[21105] = bytes167[1];
				byte[] bytes168 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[21106] = bytes168[0];
				Main.SaveData[21107] = bytes168[1];
				byte[] bytes169 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[21108] = bytes169[0];
				Main.SaveData[21109] = bytes169[1];
				byte[] bytes170 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[21110] = bytes170[0];
				Main.SaveData[21111] = bytes170[1];
				byte[] bytes171 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[21112] = bytes171[0];
				Main.SaveData[21113] = bytes171[1];
			}
			if (this.currentSlot == 20)
			{
				byte[] array20 = new byte[8];
				Encoding.UTF8.GetBytes(this.charNameTextBox.Text).CopyTo(array20, 0);
				int num109 = 0;
				for (int num110 = 22140; num110 <= 22155; num110 += 2)
				{
					Main.SaveData[num110] = array20[num109];
					num109++;
				}
				Main.SaveData[22188] = Convert.ToByte(this.charLevelComboBox.SelectedIndex + 1);
				byte[] bytes172 = BitConverter.GetBytes((int)this.charExpNumericUpDown.Value);
				int num111 = 0;
				for (int num112 = 22200; num112 <= 22202; num112++)
				{
					Main.SaveData[num112] = bytes172[num111];
					num111++;
				}
				byte[] bytes173 = BitConverter.GetBytes((int)this.charSPNumericUpDown.Value);
				int num113 = 0;
				for (int num114 = 22204; num114 <= 22206; num114++)
				{
					Main.SaveData[num114] = bytes173[num113];
					num113++;
				}
				byte[] bytes174 = BitConverter.GetBytes((int)this.bonusATKNumericUpDown.Value);
				Main.SaveData[22208] = bytes174[0];
				Main.SaveData[22209] = bytes174[1];
				byte[] bytes175 = BitConverter.GetBytes((int)this.bonusSPDNumericUpDown.Value);
				Main.SaveData[22210] = bytes175[0];
				Main.SaveData[22211] = bytes175[1];
				byte[] bytes176 = BitConverter.GetBytes((int)this.bonusHPNumericUpDown.Value);
				Main.SaveData[22212] = bytes176[0];
				Main.SaveData[22213] = bytes176[1];
				byte[] bytes177 = BitConverter.GetBytes((int)this.bonusMATNumericUpDown.Value);
				Main.SaveData[22214] = bytes177[0];
				Main.SaveData[22215] = bytes177[1];
				byte[] bytes178 = BitConverter.GetBytes((int)this.bonusManaNumericUpDown.Value);
				Main.SaveData[22216] = bytes178[0];
				Main.SaveData[22217] = bytes178[1];
				byte[] bytes179 = BitConverter.GetBytes((int)this.bonusDEFNumericUpDown.Value);
				Main.SaveData[22218] = bytes179[0];
				Main.SaveData[22219] = bytes179[1];
				byte[] bytes180 = BitConverter.GetBytes((int)this.bonusMDFNumericUpDown.Value);
				Main.SaveData[22220] = bytes180[0];
				Main.SaveData[22221] = bytes180[1];
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00009F58 File Offset: 0x00008158
		private void maxEXPNumeric_Click(object sender, EventArgs e)
		{
			this.charExpNumericUpDown.Value = 1980834m;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00009F6F File Offset: 0x0000816F
		private void maxSPNumeric_Click(object sender, EventArgs e)
		{
			this.charSPNumericUpDown.Value = 999999m;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00009F86 File Offset: 0x00008186
		private void maxHPNumeric_Click(object sender, EventArgs e)
		{
			this.bonusHPNumericUpDown.Value = 500m;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00009F9D File Offset: 0x0000819D
		private void maxMANNumeric_Click(object sender, EventArgs e)
		{
			this.bonusManaNumericUpDown.Value = 300m;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00009FB4 File Offset: 0x000081B4
		private void maxATKNumeric_Click(object sender, EventArgs e)
		{
			this.bonusATKNumericUpDown.Value = 500m;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00009FCB File Offset: 0x000081CB
		private void maxDEFNumeric_Click(object sender, EventArgs e)
		{
			this.bonusDEFNumericUpDown.Value = 300m;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00009FE2 File Offset: 0x000081E2
		private void maxSPDNumeric_Click(object sender, EventArgs e)
		{
			this.bonusSPDNumericUpDown.Value = 255m;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00009FF9 File Offset: 0x000081F9
		private void maxMATNumeric_Click(object sender, EventArgs e)
		{
			this.bonusMATNumericUpDown.Value = 500m;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000A010 File Offset: 0x00008210
		private void maxMDFNumeric_Click(object sender, EventArgs e)
		{
			this.bonusMDFNumericUpDown.Value = 300m;
		}

		// Token: 0x04000001 RID: 1
		private int currentSlot;
	}
}
