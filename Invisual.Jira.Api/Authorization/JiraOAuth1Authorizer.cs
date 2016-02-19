using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth.ChannelElements;
using Invisual.Jira.Api.Configuration;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Invisual.Jira.Api.Authorization
{
	public class JiraOAuth1Authorizer
	{
		private readonly DesktopConsumer _jiraConsumer;

		public JiraOAuth1Authorizer(IJiraAppSettings settingsProvider)
		{
			if (settingsProvider == null)
				throw new ArgumentNullException("settingsProvider");

			var jiraServiceDescription = new ServiceProviderDescription
			{
				ProtocolVersion = ProtocolVersion.V10a,
				RequestTokenEndpoint = new MessageReceivingEndpoint(settingsProvider.ApiRequestTokenUrl, HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.PostRequest),
				UserAuthorizationEndpoint = new MessageReceivingEndpoint(settingsProvider.ApiAuthorizationUrl, HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.PostRequest),
				AccessTokenEndpoint = new MessageReceivingEndpoint(settingsProvider.ApiAccessTokenUrl, HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.PostRequest)
			};

			if (settingsProvider.ApiSigningCertificatePath != null)
			{
				var signingCertificate = settingsProvider.ApiSigningCertificatePassword == null
					? new X509Certificate2(settingsProvider.ApiSigningCertificatePath)
					: new X509Certificate2(settingsProvider.ApiSigningCertificatePath, settingsProvider.ApiSigningCertificatePassword);

				jiraServiceDescription.TamperProtectionElements = new ITamperProtectionChannelBindingElement[] { new RsaSha1ConsumerSigningBindingElement(signingCertificate) };
			}

			var jiraTokenManager = new InMemoryTokenManager(settingsProvider.ApiConsumerKey, settingsProvider.ApiConsumerSecret);
			_jiraConsumer = new DesktopConsumer(jiraServiceDescription, jiraTokenManager);
		}

		public UserAuthorizationInitializationResponse GetAuthorizationUrl()
		{
			string requestToken;
			var response = _jiraConsumer.RequestUserAuthorization(null, null, out requestToken);

			return new UserAuthorizationInitializationResponse { AuthorizationUri = response, RequestToken = requestToken };
		}

		public string Authorize(string requestToken, string verificationCode)
		{
			if (string.IsNullOrWhiteSpace(requestToken))
				throw new ArgumentException("requestToken must not be null, empty, or whitespace");
			if (string.IsNullOrWhiteSpace(verificationCode))
				throw new ArgumentException("verificationCode must not be null, empty, or whitespace");		

			var response = _jiraConsumer.ProcessUserAuthorization(requestToken, verificationCode);

			return response != null ? response.AccessToken : null;
		}
	}
}
