class Citizen : Being
{
	public Citizen(string name,int age,string id) : base(id)
	{
		this.Name = name;
		this.Age = age;
	}

	public string Name { get; set; }
	public int Age { get; set; }
}