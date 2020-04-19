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
		private int PoisonedCupNum, TipCounter;

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
			myOp.TipButtonClick(sender, Poisoned, TipCounter, Drinking, Tipping);
			lblOutOfTips.Text = myOp.lblOutOfTips;
		}

		public void BtnPoison_Click(object sender, EventArgs e)
		{
			//enable the Drink button + change button colour
			btnDrink.Enabled = true;
			btnDrink.BackColor = Color.Gainsboro;

			//enable the Tip button + change button colour
			btnTip.Enabled = true;
			btnTip.BackColor = Color.Gainsboro;

			//disable the Poison button + change button colour
			BtnPoison.Enabled = false;
			BtnPoison.BackColor = Color.DimGray;
			//get a random int between 1 and 6
			var rand = new Random();
			//set which cup number is poisoned using the random number generator
			PoisonedCupNum = rand.Next(1, 7);

			Poisoned = true; //set poisoned to true
			TipCounter = 0; //set tip counter to 0

		}

		public void BtnDrink_Click(object sender, EventArgs e)
		{
			myOp.DrinkButtonClick(sender, Poisoned, Drinking, Tipping);
		}

		private void btnCups_Click(object sender, EventArgs e)
		{
			myOp.GamePlay(sender, Poisoned, Drinking, EmptyList, PoisonedCupNum, Tipping, TipCounter);
			lblOutOfTips.Text = myOp.lblOutOfTips;
		}

	}
}