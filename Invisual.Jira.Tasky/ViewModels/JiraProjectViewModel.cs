using Invisual.Jira.Api.Entities.Issues;
using Invisual.Jira.Api.Entities.Projects;
using System.Collections.Generic;

namespace Invisual.Jira.Tasky.ViewModels
{
	public class JiraProjectViewModel
	{
		public Project Project { get; set; }
		public List<Issue> UserIssues { get; set; }
	}
}
