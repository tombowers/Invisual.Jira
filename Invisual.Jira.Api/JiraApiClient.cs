using Invisual.Jira.Api.Requests;
using Invisual.Jira.Api.Responses;
using Invisual.Rest;
using System;

namespace Invisual.Jira.Api
{
	public class JiraApiClient : IJiraApiClient
	{
		private readonly IRestClient _restClient;

		public JiraApiClient(IRestClient restclient)
		{
			if (restclient == null)
				throw new ArgumentNullException("restClient");

			_restClient = restclient;
		}

		public SearchResponse Search(SearchRequest searchRequest)
		{
			if (searchRequest == null)
				throw new ArgumentNullException("searchRequest");

			try
			{
				return _restClient.Request<SearchResponse>(ServiceUrls.Search, HttpRequestMethod.Get, searchRequest, RequestParamType.QueryString);
			}
			catch (Exception e)
			{
				throw new JiraApiException("Exception thrown by rest client. See inner exception for details.", e);
			}
		}
	}
}
