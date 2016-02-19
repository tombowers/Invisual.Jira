using Invisual.Jira.Api.Entities.Common;

namespace Invisual.Jira.Api.Entities.Projects
{
	public class Project
	{
		public string Self { get; set; }
		public string Id { get; set; }
		public string Key { get; set; }
		public string Name { get; set; }
		public AvatarUrls AvatarUrls { get; set; }
		public ProjectCategory ProjectCategory { get; set; }
	}
}
