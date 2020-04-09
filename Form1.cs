using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoisonCup1
{


	public partial class Form1 : Form
	{
		//create variables, all of these are global
		//also creates a counter for tips, so that the user can only tip out 2 cups
		private bool Poisoned, Drinking, Tipping;
		private int PoisonedCupNum, FakeButtonText, TipCounter;

		//creates a new list to store cups that have been emptied so no 2 cups can be used twice
		public List<int> EmptyList = new List<int>();

		Operations myOp = new Operations();


		public Form1()
		{
			InitializeComponent();
			//myOp.form1 = Form1.Hide();
		}

		private void LblTitle_Click(object sender, EventArgs e)
		{

		}

		private void BtnTip_Click(object sender, EventArgs e)
		{


			if (Poisoned)
			{
				if (TipCounter == 2)
				{
					//if the user has already tipped out 2 cups, tell them they are out of tips and change tipping to false so it won't work if they click on a cup 
					lblOutOfTips.Text = "You are out of tips!";
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

		public void BtnPoison_Click(object sender, EventArgs e)
		{
			//enable the Drink button
			btnDrink.Enabled = true;
			btnDrink.BackColor = Color.Gainsboro;

			//enable the Tip button
			btnTip.Enabled = true;
			btnTip.BackColor = Color.Gainsboro;

			//disable the Poison button
			BtnPoison.Enabled = false;
			BtnPoison.BackColor = Color.DimGray;
			//get a random int between 1 and 6
			var rand = new Random();
			PoisonedCupNum = rand.Next(1, 7);

			Poisoned = true;
			TipCounter = 0;

		}

		public void BtnDrink_Click(object sender, EventArgs e)
		{
			if (Poisoned)
			{
				Drinking = true;
				Tipping = false;
			}
			else
			{
				MessageBox.Show("You haven't poisoned any of the cups!");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnCups_Click(object sender, EventArgs e)
		{
			myOp.GamePlay(sender, Poisoned, Drinking, EmptyList, PoisonedCupNum, Tipping, TipCounter);
			lblOutOfTips.Text = myOp.lblOutOfTips;
		}

	}
}