using Invisual.Jira.Api.Entities.Common;

namespace Invisual.Jira.Api.Entities.Users
{
	public class User
	{
		public string Self { get; set; }
		public string Name { get; set; }
		public string Key { get; set; }
		public string EmailAddress { get; set; }
		public AvatarUrls AvatarUrls { get; set; }
		public string DisplayName { get; set; }
		public bool Active { get; set; }
		public string TimeZone { get; set; }
	}
}
