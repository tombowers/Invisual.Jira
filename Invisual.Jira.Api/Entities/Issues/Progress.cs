namespace Invisual.Jira.Api.Entities.Issues
{
	public class Progress
	{
		//[CustomName("progress")]
		public int Value { get; set; }

		public int Total { get; set; }
		public int Percent { get; set; }
	}
}
