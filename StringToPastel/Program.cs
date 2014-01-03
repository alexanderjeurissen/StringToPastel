using System;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Linq;


namespace StringToPastel
{

	class MainClass
	{
		public string pastelColorForString (string s) {
			UInt32 hashCode = BitConverter.ToUInt32 (
				new SHA1CryptoServiceProvider ().ComputeHash (
					Encoding.UTF8.GetBytes (s)
				),0
			);

			return "#" +
				((((hashCode >> 24) & 0xFF)+255)/2).ToString ("X") +
				((((hashCode >> 16) & 0xFF)+255)/2).ToString ("X") +
				((((hashCode >> 08) & 0xFF)+255)/2).ToString ("X");
		}
	
		public MainClass() {

			Console.WriteLine ("string to encode:");
			string userInput = Console.ReadLine ();
			Console.WriteLine (pastelColorForString ("" + userInput));
			Console.WriteLine ("---------------- press any key to exit ----------------");
			Console.Read ();

		}
		public static void Main (string[] args) {
			new MainClass ();
		}
	}
}