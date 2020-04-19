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

		

		Operations myOp = new Operations();


		public Form1()
		{
			InitializeComponent();
		}


		private void BtnTip_Click(object sender, EventArgs e)
		{
			myOp.TipButtonClick(sender);
			lblOutOfTips.Text = myOp.lblOutOfTips;
		}

		public void BtnPoison_Click(object sender, EventArgs e)
		{
			//enable the Drink button + change button colour
			btnDrink.Enabled = true;
			btnDrink.BackColor = Color.PaleTurquoise;

			//enable the Tip button + change button colour
			btnTip.Enabled = true;
			btnTip.BackColor = Color.PaleTurquoise;

			//disable the Poison button + change button colour
			BtnPoison.Enabled = false;
			BtnPoison.BackColor = Color.Teal;

			//call the poisoning method from the Operations class
			myOp.Poisoning(sender);

		}

		public void BtnDrink_Click(object sender, EventArgs e)
		{
			myOp.DrinkButtonClick(sender);
		}

		private void btnCups_Click(object sender, EventArgs e)
		{
			myOp.GamePlay(sender, this);
			lblOutOfTips.Text = myOp.lblOutOfTips;
		}

	}
}