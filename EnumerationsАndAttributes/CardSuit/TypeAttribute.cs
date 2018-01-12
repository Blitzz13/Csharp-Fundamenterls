using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
class TypeAttribute : Attribute
{
	private string _type;

	public TypeAttribute(string category, string description)
	{
		this._type = "Enumeration";
		this.Category = category;
		this.Description = description;
	}

	public string Type => _type;

	public string Category { get; set; }
	public string Description { get; set; }

	public override string ToString()
	{
		return $"Type = {this.Type}, Description = {this.Description}";
	}
}
