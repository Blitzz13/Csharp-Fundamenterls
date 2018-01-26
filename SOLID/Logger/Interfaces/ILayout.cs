namespace Logger
{
	internal interface ILayout
	{
		string FormatMessage(string timeStamp, string reportLevel, string message);
	}
}