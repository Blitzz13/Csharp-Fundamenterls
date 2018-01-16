using System;
using System.Collections.Generic;

namespace CreateCustomClassAttribute
{
	[AttributeUsage(AttributeTargets.Class)]
	class CustomAttribute : Attribute
	{
		private string _author;
		private int _revision;
		private string _description;
		private List<string> _reviewers;

		public CustomAttribute()
		{
			this._author = "Pesho";
			this._revision = 3;
			this._description = "Used for C# OOP Advanced Course - Enumerations and Attributes.";
			this._reviewers.AddRange(new[] {"Peso", "Svetlio"});
		}

		public List<string> Reviewers
		{
			get { return _reviewers; }
			set { _reviewers = value; }
		}


		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public int Revision
		{
			get { return _revision; }
			set { _revision = value; }
		}

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

	}
}

