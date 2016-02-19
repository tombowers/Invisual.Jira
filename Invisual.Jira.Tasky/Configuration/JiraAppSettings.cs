using Invisual.Jira.Api.Configuration;
using System;
using System.Configuration;

namespace Invisual.Jira.Tasky.Configuration
{
	public static class JiraAppSettings
	{
		private static Lazy<JiraSettings> _settings = new Lazy<JiraSettings>(() => { return new JiraSettings(); });
		public static IJiraAppSettings Values { get { return _settings.Value; } }

		private class JiraSettings : IJiraAppSettings
		{
			public JiraSettings()
			{
				ApiAccessTokenUrl = ConfigurationManager.AppSettings["JiraApiAccessTokenUrl"];
				ApiAuthorizationUrl = ConfigurationManager.AppSettings["JiraApiAuthorizationUrl"];
				ApiConsumerKey = ConfigurationManager.AppSettings["JiraApiConsumerKey"];
				ApiConsumerSecret = ConfigurationManager.AppSettings["JiraApiConsumerSecret"];
				ApiRequestTokenUrl = ConfigurationManager.AppSettings["JiraApiRequestTokenUrl"];
				ApiSigningCertificatePath = ConfigurationManager.AppSettings["JiraApiSigningCertificatePath"];
				ApiSigningCertificatePassword = ConfigurationManager.AppSettings["JiraApiSigningCertificatePassword"];

				BaseUri = ConfigurationManager.AppSettings["JiraBaseUri"];
			}

			public string ApiAccessTokenUrl { get; set; }
			public string ApiAuthorizationUrl { get; set; }
			public string ApiConsumerKey { get; set; }
			public string ApiConsumerSecret { get; set; }
			public string ApiRequestTokenUrl { get; set; }
			public string ApiSigningCertificatePath { get; set; }
			public string ApiSigningCertificatePassword { get; set; }			

			public string BaseUri { get; set; }
		}
	}
}
