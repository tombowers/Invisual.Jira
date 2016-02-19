using Invisual.Jira.Api.Entities.Issues;
using System.Collections.Generic;

namespace Invisual.Jira.Api.Responses
{
	public class SearchResponse
	{
		public string Expand { get; set; }
		public int StartAt { get; set; }
		public int MaxResults { get; set; }
		public int Total { get; set; }
		public List<Issue> Issues { get; set; }
	}
}
