using System;
using Samples.Oop;

namespace Samples.Oop
{
	public class TestStaticKeyword
	{
		public static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("Test static keyword    ");
			Console.WriteLine("----------------------");
			Client[] clients = new Client[3];
			clients[0] = new Client("Anna");
			clients[1] = new Client("Martin");
			clients[2] = new Client("Henry");
			Console.WriteLine("Total count: {0}",Client.counter);
			Console.WriteLine();
		}
	}
}