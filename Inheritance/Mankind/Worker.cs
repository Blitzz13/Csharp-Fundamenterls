using System;
using System.Text;

namespace Mankind
{
	public class Worker : Human
	{
		private double _weekSalary;
		private double _workHoursPerDay;

		public Worker(string _firstName, string _lastName,double _weekSalary,double _workHoursPerDay)
			:base(_firstName,_lastName)
		{
			this.WeekSalary = _weekSalary;
			this.WorkHoursPerDay = _workHoursPerDay;
		}

		public double WorkHoursPerDay
		{
			get { return _workHoursPerDay; }
			set
			{
				if (value < 1 || value > 12)
				{
					throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
				}

				_workHoursPerDay = value;
			}

		}

		public double WeekSalary
		{
			get { return _weekSalary; }
			set
			{
				if (value <= 10)
				{
					throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
				}

				_weekSalary = value;
			}

		}

		private double CalculateSalaryPerHour()
		{
			return this.WeekSalary / (5 * this.WorkHoursPerDay);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append(base.ToString())
				.AppendLine($"Week Salary: {this.WeekSalary:F2}")
				.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}")
				.AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():F2}");
			return sb.ToString();
		}
	}
}
