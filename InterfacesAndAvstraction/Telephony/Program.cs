using System;

namespace Telephony
{
	class Program
	{
		static void Main()
		{
			var phone = new Phone();

			string[] phoneNumbers = Console.ReadLine().Split();
			foreach (string phoneNumber in phoneNumbers)
			{
				Console.WriteLine(phone.Call(phoneNumber));
			}

			string[] urls = Console.ReadLine().Split();
			foreach (string url in urls)
			{
				Console.WriteLine(phone.Browse(url));
			}

		}

	}

}
