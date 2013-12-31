using NUnit.Framework;
using System;

namespace StringToPastel
{
	[TestFixture]
	public class NUnitTestClass
	{
		MainClass main;

		[SetUp]
		public void setup(){
			main = new MainClass ();
		}

		[Test]
		public void stringToInteger ()
		{
			int result = main.stringToInteger ("test");
			Assert.AreEqual (228, result);
		}

		[Test]
		public void StringToPastelTest(){
			string result1 = main.pastelColorForString ("swag");
			Assert.AreEqual ("#95DCF6", result1);

			string result2 = main.pastelColorForString ("#church");
			Assert.AreEqual ("#8FB7CE", result2);
		}

	}
}
