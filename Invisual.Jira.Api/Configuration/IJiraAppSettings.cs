namespace Invisual.Jira.Api.Configuration
{
	public interface IJiraAppSettings
	{
		string ApiConsumerKey { get; }
		string ApiConsumerSecret { get; }
		string ApiRequestTokenUrl { get; }
		string ApiAuthorizationUrl { get; }
		string ApiAccessTokenUrl { get; }
		string ApiSigningCertificatePath { get; }
		string ApiSigningCertificatePassword { get; }

		string BaseUri { get; }
	}
}
