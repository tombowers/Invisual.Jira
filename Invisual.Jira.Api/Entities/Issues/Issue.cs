namespace Invisual.Jira.Api.Entities.Issues
{
	public class Issue
	{
		public string Expand { get; set; }
		public string Id { get; set; }
		public string Self { get; set; }
		public string key { get; set; }
		public Fields Fields { get; set; }
	}
}
