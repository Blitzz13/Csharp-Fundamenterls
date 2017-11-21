using System;
using System.Text;

class Book
{
	private string _title;
	private string _author;
	private decimal _price;

	public Book(string _author, string _title, decimal _price)
	{
		this.Author = _author;
		this.Title = _title;
		this.Price = _price;
	}

	public virtual decimal Price
	{
		get { return _price; }
		set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Price not valid!");
			}
			_price = value;
		}
	}


	public string Author
	{
		get { return _author; }
		set
		{
			if (char.IsDigit(value[0]))
			{
				throw new ArgumentException("Author not valid!");
			}
			_author = value;
		}
	}

	public string Title
	{
		get { return _title; }
		set
		{
			if (value.Length < 3)
			{
				throw new ArgumentException("Title not valid!");
			}
			_title = value;
		}
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("Type: ").AppendLine(this.GetType().Name)
			.Append("Title: ").AppendLine(this.Title)
			.Append("Author: ").AppendLine(this.Author)
			.Append("Price: ").Append($"{this.Price:f1}")
			.AppendLine();

		return sb.ToString();
	}

}
