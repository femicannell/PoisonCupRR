using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


//TODO make reset method, have to bring cup buttons over from Form1 (use a list?)


namespace PoisonCup1
{
	class Operations
	{		
		//Creating variables - also creates a counter for tips (TipCounter), so that the user can only tip out 2 cups
		public int TipCounter;
		public bool Drinking, Tipping, Poisoned;

		//creates a new list to store cups that have been emptied so no 2 cups can be used twice
		public List<int> EmptyList = new List<int>();

		public void Poisoning(object sender)
		{
			Poisoned = true; //set poisoned to true
			TipCounter = 0; //set tip counter to 0
		}

		public void GamePlay(object sender, Form1 Form1, int PoisonedCupNum) //main gameplay function - most of the heavy lifting happens in here
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
							SoundPlayer LoseSound = new SoundPlayer(Resource1.losing_sound);
							LoseSound.Play(); //plays the sound indicating they've lost

							Form3 loseform = new Form3(); 
							loseform.Show(); //show the form saying they lose
							Form1.Hide(); //hide the main form
						}
						else //if the cup they choose to drink is NOT the poisoned cup - adds the cup to the list of empty cups and nothing else happens, do not win or lose
						{
							SoundPlayer DrinkSound = new SoundPlayer(Resource1.water_drinking);
							DrinkSound.Play();
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
					else
					{
						if (FakeButtonText == PoisonedCupNum) //if they tip out the poisoned cup - they win
						{
							SoundPlayer WinSound = new SoundPlayer(Resource1.winning_sound);
							WinSound.Play(); //plays a sound indicating the user has won the game
							//the user has tipped out the poison so they win the game
							Form2 winfrm = new Form2(); 
							winfrm.Show(); //show the form saying the user has won
							Form1.Hide(); //hide the main form
						} 
						else //if they do not tip out the poisoned cup
						{
							TipCounter += 1; //add 1 to the counter for tipping
							FakeButton.Image = Resource1.soloCup;
							EmptyList.Add(FakeButtonText); //add the cup number to the list of empty cups
							if (TipCounter == 2)
							{
								SoundPlayer LoseSound = new SoundPlayer(Resource1.losing_sound);
								LoseSound.Play(); //plays a sound indicating the user has lost the game
								//the user loses as they have run out of chances to tip out the poison
								Form3 loseform = new Form3();
								loseform.Show(); //show the form saying they lose
								Form1.Hide(); //hide the main form
							}
							else
							{
								SoundPlayer TipSound = new SoundPlayer(Resource1.water_pouring);
								TipSound.Play();
							}
						}
					}
				}
			}
		}

		public void TipButtonClick(object sender) //when the tip button is clicked
		{
			if (Poisoned)
			{
					//if a cup has been poisoned and the user has at least 1 tip left, set the action to tipping
					Drinking = false;
					Tipping = true;
			}
			else
			{
				//if the user hasn't pressed the poison button yet, so no cups are poisoned
				MessageBox.Show("You haven't poisoned any of the cups! Please press the POISON button to begin the game.");
			}
		}

		public void DrinkButtonClick(object sender) //when the drink button is clicked
		{
			if (Poisoned) //if the poison button has been selected and the user has chosen to drink
			{
				Drinking = true; //set drinking to true
				Tipping = false; //set tipping to false - ensures tipping is false in case the user had previously been tipping
			}
			else
			{
				MessageBox.Show("You haven't poisoned any of the cups! Please press the POISON button to begin the game."); //if the drinking option is selected but the poison button has not yet been clicked
			}
		}
	}
}