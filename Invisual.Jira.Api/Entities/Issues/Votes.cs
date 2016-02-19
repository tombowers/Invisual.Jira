namespace Invisual.Jira.Api.Entities.Issues
{
	public class Votes
	{
		public string Self { get; set; }

		//[CustomName("votes")]
		public int Count { get; set; }

		public bool HasVoted { get; set; }
	}
}
