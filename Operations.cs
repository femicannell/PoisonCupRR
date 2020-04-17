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
		public string lblOutOfTips, WinLose;
		public void GamePlay(object sender, bool Poisoned, bool Drinking, List<int> EmptyList, int PoisonedCupNum, bool Tipping, int TipCounter)
		{
			Button FakeButton = (Button)sender;
			int FakeButtonText = Convert.ToInt16(FakeButton.Text);
			if (Poisoned) //if the poison button has been pressed, a random number has been generated and the game can start
			{
				if (Drinking) //if the user has selected the drinking option, they will drink any cups they click on from here on out
				{
					if (EmptyList.Contains(FakeButtonText)) //if the cup they selected is EMPTY (already drank or tipped out)
					{
						MessageBox.Show("This cup is empty!"); //show a message box informing the user the cup is empty
					}
					else //if the cup is NOT empty
					{
						if (FakeButtonText == PoisonedCupNum) //if the cup they chose to drink is the poisoned cup - they lose/die
						{
							Form3 loseform = new Form3(); 
							loseform.Show(); //show the form saying they lose
						}
						else //if the cup they choose to drink is NOT the poisoned cup - adds the cup to the list of empty cups and nothing else happens, do not win or lose
						{
							FakeButton.Image = Resource1.soloCup;
								EmptyList.Add(FakeButtonText); //adds the cuo number to the list of empty cups
						}
					}
				}
				else if (Tipping) //if the user has selected the tipping option, they will tip out any full cup they choose but can only tip out a max of 2 cups
				{
					if (EmptyList.Contains(FakeButtonText)) //if the cup they have chosen to tip out is empty
					{
						MessageBox.Show("This cup is empty!"); //show a message box informing the user the cup they chose is already empty
					}
					else if (TipCounter == 2) //if they have already tipped out 2 drinks, they can't tip out any more
					{
						MessageBox.Show("You have already tipped out 2 drinks... No more chances."); //show a messagebox informing them they can't tip anymore drinks
						Tipping = false; //change the tipping option to false
						lblOutOfTips = "You are out of tips!"; //change the label under the tipping option to show they are out of tips
					}
					else
					{
						if (FakeButtonText == PoisonedCupNum) //if they tip out the poisoned cup - they win
						{
							Form2 winfrm = new Form2(); 
							winfrm.Show(); //show the winning screen/form
						} 
						else //if they do not tip out the poisoned cup
						{
							TipCounter += 1; //add 1 to the counter for tipping
							FakeButton.Image = Resource1.soloCup;
							EmptyList.Add(FakeButtonText); //add the cup number to the list of empty cups
						}
					}
				}
			}
		}
	}
}
