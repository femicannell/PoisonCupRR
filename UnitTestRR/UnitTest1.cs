using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoisonCup1;

namespace UnitTestRR
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestRandomNum()
		{
			//instantiate a new form and pass the form properties across
			Form1 myForm = new Form1();
			//run the method on the form and then pass the number to a variable for testing
			int PoisonedCupNum = myForm.PoisonGenerator();
			//is the number greater than 0 and less than 7? - needs to be between 1 and 6 because there are 6 cups
			Assert.IsTrue((PoisonedCupNum > 0) && (PoisonedCupNum < 7));
		}

	}
}
