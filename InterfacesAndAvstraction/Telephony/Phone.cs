namespace Telephony
{
	public class Phone : ICallable, IBrowseable
	{
		public string Call(string number)
		{
			if (IsTheNumberRight(number))
			{
				return $"Calling... {number}";
			}
			return "Invalid number!";
		}

		public string Browse(string url)
		{
			if (IsTheUrlRight(url))
			{
				return $"Browsing: {url}!";
			}

			return "Invalid URL!";
		}

		private bool IsTheUrlRight(string url)
		{
			foreach (char letter in url)
			{
				if (char.IsDigit(letter))
				{
					return false;
				}

			}

			return true;
		}

		private bool IsTheNumberRight(string url)
		{
			foreach (char letter in url)
			{
				if (char.IsLetter(letter))
				{
					return false;
				}

			}

			return true;
		}
	}
}
