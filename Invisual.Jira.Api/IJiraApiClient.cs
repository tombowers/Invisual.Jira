using Invisual.Jira.Api.Requests;
using Invisual.Jira.Api.Responses;

namespace Invisual.Jira.Api
{
	public interface IJiraApiClient
	{
		SearchResponse Search(SearchRequest searchRequest);
	}
}
