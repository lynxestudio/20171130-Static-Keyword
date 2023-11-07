using System;

namespace Samples.Oop {
	public class Client {
		public static int counter = 0;
		private string name;
		private int serialNumber = 0;

		public Client(string name) {
			counter++;
			this.SerialNumber = counter;
			this.Name = name;
		}

		public string Name {
			get{ return name; }
			private set{ name = value; }
		}

		public int SerialNumber {
			get{ return serialNumber; }
			private set{ serialNumber = value; }
		}
		
		public static int GetTotalCount() {
			return counter;
		}
	}
}