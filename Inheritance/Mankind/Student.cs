using System;
using System.Linq;
using System.Text;

namespace Mankind
{
	public class Student : Human
	{
		private string facultyNumber;

		public Student(string _firstName, string _lastName, string _facultyNumber)
			: base(_firstName, _lastName)
		{
			this.FacultyNumber = _facultyNumber;
		}

		public string FacultyNumber
		{
			get { return facultyNumber; }
			set
			{
				bool isOnlyLettersAndDigits = value.All(c => Char.IsLetterOrDigit(c));
				if (value.Length < 5 || value.Length > 10 || !isOnlyLettersAndDigits)
				{
					throw new ArgumentException($"Invalid faculty number!");
				}

				facultyNumber = value;
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append(base.ToString()).AppendLine($"Faculty number: {this.FacultyNumber}");
			return sb.ToString();
		}
	}
}
