namespace Invisual.Jira.Api.Requests
{
	public class SearchRequest
	{
		public string Jql { get; set; }
		public int StartAt { get; set; }
		public int MaxResults { get; set; }
		public bool ValidateQuery { get; set; }
	}
}
