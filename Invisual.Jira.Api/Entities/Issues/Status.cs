namespace Invisual.Jira.Api.Entities.Issues
{
	public class Status
	{
		public string Self { get; set; }
		public string Description { get; set; }
		public string IconUrl { get; set; }
		public string Name { get; set; }
		public string Id { get; set; }
		public StatusCategory StatusCategory { get; set; }
	}
}
