using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PoisonCup1
{
	class Operations
	{
		//public Form form1 { get; set; }
		public string lblOutOfTips, WinLose;
		public void GamePlay(object sender, bool Poisoned, bool Drinking, List<int> EmptyList, int PoisonedCupNum, bool Tipping, int TipCounter)
		{
			Button FakeButton = (Button)sender;
			int FakeButtonText = Convert.ToInt16(FakeButton.Text);
			if (Poisoned)
			{
				if (Drinking)
				{
					if (EmptyList.Contains(FakeButtonText))
					{
						MessageBox.Show("This cup is empty!");
					}
					else
					{
						if (FakeButtonText == PoisonedCupNum)
						{
							Form3 loseform = new Form3();
							loseform.Show();
						}
						else
						{
							FakeButton.Image =
								Image.FromFile(
									@"C:\Users\Femi\Desktop\Vision College\Software Development Lvl 6\ASSESSMENTS\Assignment 01\PoisonCup1\soloCup.jpg");
							EmptyList.Add(FakeButtonText);
						}
					}
				}
				else if (Tipping)
				{
					if (EmptyList.Contains(FakeButtonText))
					{
						MessageBox.Show("This cup is empty!");
					}
					else if (TipCounter == 2)
					{
						MessageBox.Show("You have already tipped out 2 drinks... No more chances.");
						Tipping = false;
						lblOutOfTips = "You are out of tips!";
					}
					else
					{
						if (FakeButtonText == PoisonedCupNum)
						{
							Form2 winfrm = new Form2();
							winfrm.Show();
						} 
						else
						{
							TipCounter += 1;
							FakeButton.Image = Image.FromFile(@"C:\Users\Femi\Desktop\Vision College\Software Development Lvl 6\ASSESSMENTS\Assignment 01\PoisonCup1\soloCup.jpg");
							EmptyList.Add(FakeButtonText);
						}
					}
				}
			}
		}
	}
}
