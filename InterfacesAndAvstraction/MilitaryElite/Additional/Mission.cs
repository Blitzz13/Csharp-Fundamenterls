namespace MilitaryElite
{
	class Mission
	{
		private string _codeName;

		private string _sate;

		public Mission(string codeName,string state)
		{
			this.CodeName = codeName;
			this.State = state;
		}
		public string State
		{
			get => _sate;
			set => _sate = value;
		}

		public string CodeName
		{
			get => _codeName;
			set => _codeName = value;
		}

		void CompleteMission() { }
	}
}
