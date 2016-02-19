using System;

namespace Invisual.Jira.Api
{

	[Serializable]
	public class JiraApiException : Exception
	{
		public JiraApiException() { }
		public JiraApiException(string message) : base(message) { }
		public JiraApiException(string message, Exception inner) : base(message, inner) { }
		protected JiraApiException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{ }
	}
}
