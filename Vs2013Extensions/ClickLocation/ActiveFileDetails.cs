namespace ErR.Vs2013Extensions.ClickLocation
{
	public class ActiveFileDetails
	{
		public string FullPath { get; set; }
		public int CurrentLine { get; set; }

		public override string ToString()
		{
			return string.Format("{0}   |   Line: {1}",
				FullPath,
				CurrentLine);
		}
	}
}