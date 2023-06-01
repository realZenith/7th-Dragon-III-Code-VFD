using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000004 RID: 4
	public partial class ItemEditing1 : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x0000D760 File Offset: 0x0000B960
		public ItemEditing1()
		{
			this.InitializeComponent();
			this.LoadInventory();
			this.LoadItems();
			int num = this.itemWeaponHexId.Length;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000E91C File Offset: 0x0000CB1C
		public void LoadInventory()
		{
			byte[] array = new byte[5600];
			Array.Copy(Main.SaveData, 23308, array, 0, 5600);
			int num = 0;
			for (int i = 0; i < 5600; i += 8)
			{
				this.itemHexID[num] = (uint)BitConverter.ToUInt64(array, i);
				this.itemType[num] = (int)BitConverter.ToUInt16(array, i + 4);
				this.itemQuantity[num] = (int)BitConverter.ToUInt16(array, i + 6);
				if (this.itemHexID[num] > 1300U)
				{
					this.itemHexID[num] = 1300U;
				}
				if (this.itemType[num] > 5)
				{
					this.itemType[num] = 6;
				}
				num++;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		public void LoadItems()
		{
			string[] array = new string[4];
			for (int i = 0; i < 700; i++)
			{
				int num = i + 1;
				if (this.itemType[i] == 0)
				{
					int num2 = Array.IndexOf<int>(this.itemUseHexId, (int)this.itemHexID[i]);
					string text = this.itemUseName[num2];
					array[0] = num.ToString();
					array[1] = text;
					array[2] = this.itemTypeName[0];
					array[3] = this.itemQuantity[i].ToString();
				}
				if (this.itemType[i] == 1)
				{
					int num2 = Array.IndexOf<int>(this.itemWeaponHexId, (int)this.itemHexID[i]);
					string text = this.itemWeaponName[num2];
					array[0] = num.ToString();
					array[1] = text;
					array[2] = this.itemTypeName[1];
					array[3] = this.itemQuantity[i].ToString();
				}
				if (this.itemType[i] == 2)
				{
					int num2 = Array.IndexOf<int>(this.itemGearsHexId, (int)this.itemHexID[i]);
					string text = this.itemGearsName[num2];
					array[0] = num.ToString();
					array[1] = text;
					array[2] = this.itemTypeName[2];
					array[3] = this.itemQuantity[i].ToString();
				}
				if (this.itemType[i] == 3)
				{
					int num2 = Array.IndexOf<int>(this.itemAccHexId, (int)this.itemHexID[i]);
					string text = this.itemAccName[num2];
					array[0] = num.ToString();
					array[1] = text;
					array[2] = this.itemTypeName[3];
					array[3] = this.itemQuantity[i].ToString();
				}
				if (this.itemType[i] == 4)
				{
					int num2 = Array.IndexOf<int>(this.itemKeyHexId, (int)this.itemHexID[i]);
					string text = this.itemKeyName[num2];
					array[0] = num.ToString();
					array[1] = text;
					array[2] = this.itemTypeName[4];
					array[3] = this.itemQuantity[i].ToString();
				}
				if (this.itemType[i] == 5)
				{
					int num2 = Array.IndexOf<int>(this.itemExcHexId, (int)this.itemHexID[i]);
					string text = this.itemExcName[num2];
					array[0] = num.ToString();
					array[1] = text;
					array[2] = this.itemTypeName[5];
					array[3] = this.itemQuantity[i].ToString();
				}
				if (this.itemType[i] == 6)
				{
					int num2 = Array.IndexOf<int>(this.itemLolHexId, (int)this.itemHexID[i]);
					string text = this.itemLolName[num2];
					array[0] = num.ToString();
					array[1] = text;
					array[2] = this.itemTypeName[6];
					array[3] = 0.ToString();
				}
				ListViewItem listViewItem = new ListViewItem(array);
				this.listViewItemBox.Items.Add(listViewItem);
			}
			this.listViewItemBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000EC71 File Offset: 0x0000CE71
		private void listViewItemBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.button1.PerformClick();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000EC80 File Offset: 0x0000CE80
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.listViewItemBox.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Select an item to edit.");
				return;
			}
			base.Hide();
			ItemEditDialog itemEditDialog = new ItemEditDialog(this.listViewItemBox.SelectedItems[0].SubItems[1].Text, this.listViewItemBox.SelectedItems[0].SubItems[3].Text);
			itemEditDialog.ShowDialog();
			int num = int.Parse(this.listViewItemBox.SelectedItems[0].SubItems[0].Text);
			if (itemEditDialog.DialogResult == DialogResult.OK)
			{
				this.itemHexID[num - 1] = (uint)itemEditDialog.ItemID;
				this.itemType[num - 1] = itemEditDialog.ItemType;
				this.itemQuantity[num - 1] = itemEditDialog.ItemQuantity;
			}
			itemEditDialog.Dispose();
			this.listViewItemBox.Items.Clear();
			this.LoadItems();
			this.listViewItemBox.Items[num - 1].Selected = true;
			this.listViewItemBox.TopItem = this.listViewItemBox.SelectedItems[0];
			base.Show();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		private void ItemEditing1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveChanges();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		public void SaveChanges()
		{
			int num = 0;
			int num2 = (from ListViewItem x in this.listViewItemBox.Items
				where x.SubItems[1].Text.ToString() != "---"
				select x).Count<ListViewItem>();
			for (int i = 23308; i < 28907; i += 8)
			{
				byte[] bytes = BitConverter.GetBytes(this.itemHexID[num]);
				byte b = (byte)this.itemType[num];
				byte b2 = (byte)this.itemQuantity[num];
				if (bytes[0] == 20 && bytes[1] == 5)
				{
					Main.SaveData[i] = byte.MaxValue;
					Main.SaveData[i + 1] = byte.MaxValue;
					Main.SaveData[i + 2] = byte.MaxValue;
					Main.SaveData[i + 3] = byte.MaxValue;
					Main.SaveData[i + 4] = byte.MaxValue;
					Main.SaveData[i + 5] = byte.MaxValue;
					Main.SaveData[i + 6] = byte.MaxValue;
					Main.SaveData[i + 7] = byte.MaxValue;
				}
				else
				{
					Main.SaveData[i] = bytes[0];
					Main.SaveData[i + 1] = bytes[1];
					Main.SaveData[i + 2] = bytes[2];
					Main.SaveData[i + 3] = bytes[3];
					Main.SaveData[i + 4] = b;
					Main.SaveData[i + 5] = 0;
					if (b2 == 0)
					{
						Main.SaveData[i + 6] = 1;
					}
					else
					{
						Main.SaveData[i + 6] = b2;
					}
					Main.SaveData[i + 7] = 0;
				}
				num++;
				if (num == num2)
				{
					break;
				}
			}
			Main.SaveData[23304] = (byte)num2;
		}

		// Token: 0x0400004C RID: 76
		private uint[] itemHexID = new uint[700];

		// Token: 0x0400004D RID: 77
		private int[] itemType = new int[700];

		// Token: 0x0400004E RID: 78
		private int[] itemQuantity = new int[700];

		// Token: 0x0400004F RID: 79
		private int[] itemUseHexId = new int[]
		{
			0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
			10, 15, 16, 17, 18, 20, 21, 22, 23, 24,
			25, 30, 31, 32, 34, 35, 36, 40, 41, 49,
			50, 51, 52, 53, 54, 60, 61, 62, 63, 64,
			65, 70, 71, 72, 73, 80, 100, 105, 106, 110,
			121, 122, 123, 124, 125, 126, 127, 128, 134, 135,
			136, 137, 138, 139, 140
		};

		// Token: 0x04000050 RID: 80
		private string[] itemUseName = new string[]
		{
			"Medis I", "Medis II", "Medis III", "Milro Medis", "Medis IV", "Healing Aloe I", "Healing Aloe II", "Healing Aloe III", "Fixing Aloe", "Healing Aloe IV",
			"Healing Aloe V", "Ingredient Set", "Low-Grade Bento", "Handmade Bento", "High-Grade Bento", "Ropa Udon", "Fried Rice Bento", "Crummy Energy Bar", "Energy Bar", "Quality Energy Bar",
			"Supreme Energy Bar", "Mana Water", "Silver Water", "Blue Dragon Water", "Variety Bento", "Stamina Bento", "Supreme Bento", "Future of Atlantis", "Hope of Eden", "Nano-Care",
			"Nano-Aid", "Nano-Fine", "Hypno Crystal", "Nano-Hope", "Nano-Miracle", "Paral-Aid", "Blind-Aid", "Poison-Aid", "Ozon-Aid", "Ston-Aid",
			"Soma-Aid", "Paral-Aid All", "Blind-Aid All", "Poison-Aid All", "Ozon-Aid All", "Dragon Hatchling", "Smoke Grenade", "Camouflage", "Optical Camouflage", "Escape Kit",
			"Abalone Bento", "Scallop Bento", "Large Abalone Bento", "Large Scallop Bento", "Bird Meat Bento", "Dragon Meat", "Large Bird Bento", "Large Dragon Bento", "SP Up 100", "SP Up 200",
			"SP Up 300", "SP Up 500", "SP Up EX", "Mio-Made Cookie", "Cookie From Mio"
		};

		// Token: 0x04000051 RID: 81
		private int[] itemWeaponHexId = new int[]
		{
			200, 201, 202, 203, 204, 205, 206, 207, 208, 209,
			210, 211, 212, 213, 214, 215, 220, 221, 222, 223,
			224, 225, 226, 227, 228, 229, 230, 231, 232, 233,
			234, 240, 241, 242, 243, 244, 245, 246, 247, 248,
			249, 250, 251, 252, 253, 254, 260, 261, 262, 263,
			264, 265, 266, 267, 268, 269, 270, 271, 272, 273,
			274, 280, 281, 282, 283, 284, 285, 286, 287, 288,
			289, 290, 291, 292, 293, 294, 300, 301, 302, 303,
			304, 305, 306, 307, 308, 309, 310, 311, 312, 313,
			320, 321, 322, 323, 324, 325, 326, 327, 328, 329,
			330, 331, 340, 341, 342, 343, 344, 345, 346, 347,
			348, 349, 350, 360, 361, 362, 363, 364, 365, 366,
			367, 368, 369, 370, 380, 381, 382, 383, 384, 385,
			386, 387
		};

		// Token: 0x04000052 RID: 82
		private string[] itemWeaponName = new string[]
		{
			"Wakizashi", "Wakizashi 2", "Masamune", "Mikazuchi", "Zanbatou", "Chidori", "Kiryu Ichimonji", "Zanba Ashura", "Seigan", "Kokutou",
			"Amanotsurugi", "Amenobari", "Tenchi Danretsu", "Fake Sword A", "Wakizashi Zero", "Fake Sword B", "Souken", "Kogarasumaru", "Hizamaru", "Kotetsu",
			"Hotarumaru", "Shishiou", "Sealed Shichisei", "Raikiri", "Shichisei", "Chiru+Saku", "Amamegiri", "Ranbu Sanzanzakura", "Fake Blades A", "Souken Zero",
			"Fake Blades B", "Striker", "Fire Beretta", "High Derringer", "Eagle Eye", "Scorpion", "Counter Killer", "Mrskytia", "Dragoon", "Infinity",
			"Holy Gyorgear", "Grenerik", "Indra", "Fake Gun A", "Strike Zeroshiki", "Fake Gun B", "Twin Fist", "Knuckle Breaker", "Hero Fist", "Kaiser Knuckle",
			"Bone Fist", "Star Fist", "Ogre Crusher", "Dreadnought", "Almighty Hand", "Mio Gauntlet", "Rad Blaster", "God Knuckle", "Fake Knuckle A", "Twin Fist Zero",
			"Fake Knuckle B", "Volume 1", "Volume 2", "Volume 3", "Volume 4", "Volume 5", "Volume 6", "Volume 7", "Volume 8", "Volume 9",
			"Volume EX", "Volume 0", "Volume X", "Fake Cards A", "Volume Zero", "Fake Cards B", "Mrkyska", "Battle Dagger", "Seax", "Ladyin Blade",
			"Kunai", "Peshkatz", "Misericorde", "AAA Victory", "Holy Atlantica", "Magic Azoth", "Nynal Knife", "Soludis", "Odin", "Fake Knife A",
			"Hunraqan", "Xibalba", "Tsolk'in", "Ts'onot", "Ixtab", "Wayeb'", "Chaahk", "Tepeu", "Ixchel", "Kukulcan",
			"Yggdrasil", "Fake Scythe A", "Mace", "Ancient Root", "Morning Star", "Jewel Rod", "Magus Mace", "Gygant Hammer", "Vajra", "Cage of Hearts",
			"Ukonvasara", "Staff of the End", "Fake Staff A", "Valiant", "Wirbelwind", "Valiant Mk.II", "Hetzer", "Ostwind", "Kugelblitz", "Brummbar",
			"Valiant Mk.III", "Leichttraktor", "Heat X", "Fake Spear A", "Dual Blade Sample", "Gun Sample", "Knuckle Sample", "Card Sample", "Mace Sample", "Spear Sample Gun Lance S",
			"Knife Sample", "Scythe Sample"
		};

		// Token: 0x04000053 RID: 83
		private int[] itemGearsHexId = new int[]
		{
			400, 401, 402, 403, 404, 405, 406, 415, 416, 417,
			418, 419, 420, 421, 422, 423, 426, 430, 431, 432,
			433, 434, 435, 436, 437, 438, 441, 459, 460, 461,
			462, 463, 464, 465, 466, 467, 468, 469, 470, 471,
			472, 473, 474, 475, 476, 477, 478, 479, 480, 481,
			482, 483, 484, 485, 486
		};

		// Token: 0x04000054 RID: 84
		private string[] itemGearsName = new string[]
		{
			"Chrome Uni", "Chrome Uni BTL", "Chrome Uni EX", "Murakumo Uni", "Fortress Armor", "Wizard Robe", "C3N4", "Battle Suit", "Damper Coat", "Spectra Chest",
			"Ceramic Plate", "Hi-Polymer Vest", "Ballistic Coat", "Synthetic Plate", "Anti-Shock Field", "Ultimate Shield", "Polymer Uni", "Type Titanium", "Silver Stream", "Amorphic Chrome",
			"Anti-Pressure", "Full Coat", "eChip Gear", "Type Adamant", "Vortex Screen", "Nano Envelope", "Steel Wear", "Mammoth Fur", "Kapra Armor", "Algen Mail",
			"Gumani Lorica", "Auria Plate", "Castrad Ore", "Adamant Heavy", "Anzhi Robe", "Mrkyska Toga", "Reddick Suit", "Chokari Habit", "Cromwell Vest", "Iriya War Robe",
			"Mistrua Gown", "Fluted Plate", "Heavy Suit", "Brigandine", "Gaian Lorica", "Hauberk", "Cuirass", "King's Fortress", "Travel Coat", "Aizhen Frock",
			"Shadow Mantle", "Silver Tunic", "Mythril Vest", "Princess Dress", "Nine Tail Robe"
		};

		// Token: 0x04000055 RID: 85
		private int[] itemAccHexId = new int[]
		{
			500, 501, 502, 503, 504, 505, 506, 507, 508, 509,
			510, 511, 512, 513, 514, 515, 516, 517, 518, 519,
			530, 531, 532, 533, 534, 535, 536, 537, 538, 539,
			540, 541, 542, 543, 544, 545, 546, 547, 548, 549,
			550, 551, 552, 553, 554, 555, 556, 557, 558, 559,
			560, 561, 562, 563, 564, 565, 567, 568, 569, 571,
			572, 573, 574, 575, 580, 581, 582, 583, 584, 585,
			586, 587
		};

		// Token: 0x04000056 RID: 86
		private string[] itemAccName = new string[]
		{
			"Attack Ring I", "Guard Ring I", "Phazer Ring I", "Cat Tail", "Killer Band", "Gygant Medal", "Toughness Medal", "Blaster Belt", "Saint Ring", "Attack Ring II",
			"Guard Ring II", "Phazer Ring II", "Retreat Ring", "Shining Ring", "Guard Ring III", "Argos Medal", "Sway Ring", "Blaster Ring", "Attack Ring III", "Attack Ring EX",
			"Venom Guard", "Paralyze Guard", "Burn Guard", "Frost Guard", "Blind Guard", "Stone Guard", "Sleep Guard", "Nagamimi Charm", "Confusion Guard", "Downer Guard",
			"Stop Guard", "Dead Guard", "ISDF Purple Heart", "Lesser Bracer", "Queen Bracer", "Physical Guard", "Prince Bracer", "Psycho Guard", "King Bracer", "Venom Cut",
			"Paralyze Cut", "Burn Cut", "Frost Cut", "Blind Cut", "Stone Cut", "Sleep Cut", "Confusion Cut", "Downer Cut", "Stop Cut", "Dead Cut",
			"EXP Upper", "SP Upper", "Rogue Band", "Mind Booster", "EXP Upper G", "SP Upper G", "Major Bracer", "Super Upper", "Cat Pendant", "Yuma's Nametag",
			"Broken Knife Hilt", "Bent Sword Guard", "Damaged Pendant", "Split Weapon Core", "Sheathed Wisdom", "Rouge Barrett", "The Hand of God", "Evasive Wanderer", "Aurora Piercings", "Maximum Cute!",
			"Guard Talisman", "Bomb Accelerator"
		};

		// Token: 0x04000057 RID: 87
		private int[] itemKeyHexId = new int[]
		{
			700, 701, 702, 703, 704, 705, 706, 707, 708, 709,
			710, 711, 712, 713, 714, 715, 716, 717, 718, 719,
			720, 721, 722, 723, 724, 725, 726, 727, 728, 729,
			730, 731, 732, 733, 734, 735, 736, 737, 738, 742,
			746, 747, 748, 749, 750, 751, 752, 779, 780, 781,
			782, 783, 784, 785, 786, 787, 788, 789, 790, 791,
			997, 998, 999
		};

		// Token: 0x04000058 RID: 88
		private string[] itemKeyName = new string[]
		{
			"ID Card", "Mayhem Specimen", "Dragonslayer Atlantis", "3rd True Dragon Specimen", "Dragonslayer Eden", "4th True Dragon Specimen", "Konohana Sakuhime", "Kohohana Chiruhime", "ND's Congratulations", "Bug Report",
			"Dragontil", "The Sunken Kingdom", "The Great Dragon War, Pt", "The Great Dragon War, Pt", "Bellocchio Photo", "Roses and Love Letter", "Rose Bouquet", "Camera", "Throw Net", "Eden Book",
			"Letter to Noyle", "Yuta and Maya's Letters", "Atlantis Books", "The Sound of the Surf", "Pipe Diagram", "Tokion Report", "Lucier Stone", "Ring and Rare Card", "Instructions", "Fried Rice Recipe",
			"Mayhem Fossil Specimen", "Blue Dragonsbane Sample", "Console", "Insomnia ? Specimen", "Zero Blue ? Specimen", "Blank Paper", "Blaster Pen", "Conch Digestive Gland", "Ammonite", "SKY Emblem",
			"Titan Gygas EX", "Jormungand Manuscript", "666 Sights of the World", "Rosier Claw", "Blaster Autograph", "6th True Dragon Specimen", "2nd True Dragon Specimen", "ID: Allie", "ID: Julietta", "ID: Nagamimi",
			"ID: Mio", "ID: Yoritomo", "ID: Yuma", "ID: Chika", "ID: Rika", "ID: Ulania", "ID: Eigur", "ID: Sailas", "ID: Brijilt", "ID: Hero",
			"???", "ND Defeat Certificate", "White Paper"
		};

		// Token: 0x04000059 RID: 89
		private int[] itemExcHexId = new int[]
		{
			1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009,
			1010, 1050, 1051, 1052, 1053, 1055, 1056, 1057, 1058, 1059,
			1060, 1061, 1062, 1063, 1064, 1065, 1067, 1068, 1070, 1071,
			1073, 1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1083,
			1084, 1085, 1087, 1088, 1090, 1092, 1093, 1094, 1095, 1096,
			1097, 1098, 1110, 1111, 1112, 1113, 1115, 1116, 1117, 1118,
			1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128,
			1129, 1130, 1131, 1299
		};

		// Token: 0x0400005A RID: 90
		private string[] itemExcName = new string[]
		{
			"Digestive Gland", "Spiral Meat", "Flame Collagen", "Ebony Wing", "Copper Beef", "Peach Nectar", "Ancient Icicle", "Bloody Essence", "Rosier Claw 2", "Cat Food",
			"Fancy Cat Food", "KZN Battle Chip", "Hazy Smoke", "Flimsy Shark Fin", "Spiral Extract", "Super Exoskeleton", "Paper Lantern", "Soft Skin", "Dark Feather", "Sproingy Fat",
			"JZH Emotion Chip", "Numbing Mucus", "Thick Iron Plate", "UTI Drill Edge", "Warm Light Ball", "Shiny Great Horn", "Ice Petal", "Tender Meat", "Black Great Horn", "Red Rabbit Fang",
			"Battle-Worn Claws", "Pollen of Grief", "Thick Ivy", "High-Grade Steel", "Auburn Feather", "A1 Meat Slab", "Flexible Ivy", "Dark Fatty Meat", "Bristly Skin", "Smoke Ball",
			"KEM Large Drill", "Steel Claws", "Thick Steel Sheet", "Fancy Shark Fin", "Freezing Leather", "Shining Pincers", "Supreme Bear Meat", "Large Steel Sheet", "A5 Meat Slab", "YKS On-Board Chip",
			"ZNK Flame Drill", "Transparent Ivy", "Gold Dust", "Gold Nugget", "Gold Chunk", "Gold Ingot", "Dragon Skin", "Dragon Wing", "Dragon Patagium", "Dragon Skull",
			"Dragon Horn", "Dragon Tusk", "Axe Dragon Horn", "Dragon Scale", "Dragon Stone", "Dragon Tongue", "Dragon Chain", "Dragon Apex Scale", "Frozen Plasma", "Dragon Mask",
			"Dragon Claws", "Red Dragon Heart", "Dragon Liver", "Az"
		};

		// Token: 0x0400005B RID: 91
		private int[] itemLolHexId = new int[] { 1300 };

		// Token: 0x0400005C RID: 92
		private string[] itemLolName = new string[] { "---" };

		// Token: 0x0400005D RID: 93
		private string[] itemTypeName = new string[] { "Use", "Weapons", "Gears", "Accessories", "Key", "Exchange", "---" };
	}
}
