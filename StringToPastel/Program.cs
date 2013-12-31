using System;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Linq;

namespace StringToPastel
{

	class MainClass
	{
		public int stringToInteger (string s) {
			var sha1 = new SHA1CryptoServiceProvider();
			byte[] passwordBytes = Encoding.UTF8.GetBytes(s);
			byte[] hash = sha1.ComputeHash(passwordBytes);
			return (int)(
				(double)BitConverter.ToUInt32 (hash, 0) / UInt32.MaxValue * 255
			);
		}
	
		public string pastelColorForString (string s) {
	
			int r = stringToInteger (s);
			int g = stringToInteger (new string (s.Reverse ().ToArray ())); 
			int b = stringToInteger (""+Math.Max (r, g));

			Color result = Color.FromArgb (
				0,
				(int)((r+255)/2),
				(int)((g+255)/2),
				(int)((b+255)/2)
			);	
		
			return ColorTranslator.ToHtml (result);
		}

		public MainClass() {
			Console.WriteLine ("string to encode:");
			string userInput = Console.ReadLine () ;
			Console.WriteLine (pastelColorForString ("" + userInput));
			Console.WriteLine ("---------------- press any key to exit ----------------");
			Console.Read ();
		}
		public static void Main (string[] args) {
			new MainClass ();
		}
	}
}