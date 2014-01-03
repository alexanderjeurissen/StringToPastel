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
		public void StringToPastelTest(){
			string result1 = main.pastelColorForString ("swag");
			Assert.AreEqual ("#95C6A5", result1);

			string result2 = main.pastelColorForString ("#church");
			Assert.AreEqual ("#8FC9C6", result2);
		}

	}
}
