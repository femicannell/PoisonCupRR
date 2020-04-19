using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


//TODO make reset method, have to bring cup buttons over from Form1 (use a list?)


namespace PoisonCup1
{
	class Operations
	{		
		//create variables
		public string lblOutOfTips, WinLose;
		//also creates a counter for tips, so that the user can only tip out 2 cups
		public int TipCounter, PoisonedCupNum, TotalScore;
		private bool Drinking, Tipping, Poisoned;

		//creates a new list to store cups that have been emptied so no 2 cups can be used twice
		public List<int> EmptyList = new List<int>();

		public void Poisoning(object sender)
		{
			
			//get a random int between 1 and 6
			var rand = new Random();
			//set which cup number is poisoned using the random number generator
			PoisonedCupNum = rand.Next(1, 7);

			Poisoned = true; //set poisoned to true
			TipCounter = 0; //set tip counter to 0
		}

		public void GamePlay(object sender, Form1 Form1)
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
							Form1.Hide(); //hide the main form
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
			//return TipCounter;
		}

		public void TipButtonClick(object sender)
		{
			if (Poisoned)
			{
				if (TipCounter == 2)
				{
					//if the user has already tipped out 2 cups, tell them they are out of tips and change tipping to false so it won't work if they click on a cup 
					lblOutOfTips = "You are out of tips! The game is over.";
					Tipping = false;
				}
				else
				{
					//if a cup has been poisoned and the user has at least 1 tip left, set the action to tipping
					Drinking = false;
					Tipping = true;
				}

			}
			else
			{
				//if the user hasn't pressed the poison button yet, so no cups are poisoned
				MessageBox.Show("You haven't poisoned any of the cups!");
			}
		}

		public void DrinkButtonClick(object sender)
		{
			if (Poisoned) //if the poison button has been selected and the user has chosen to drink
			{
				Drinking = true; //set drinking to true
				Tipping = false; //set tipping to false - ensures tipping is false in case the user had previously been tipping
			}
			else
			{
				MessageBox.Show("You haven't poisoned any of the cups!"); //if the drinking option is selected but the poison button has not yet been clicked
			}
		}
	}
}
