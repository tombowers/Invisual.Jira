using System;

namespace Invisual.Jira.Api.Authorization
{
	public class UserAuthorizationInitializationResponse
	{
		public Uri AuthorizationUri { get; set; }
		public string RequestToken { get; set; }
	}
}
