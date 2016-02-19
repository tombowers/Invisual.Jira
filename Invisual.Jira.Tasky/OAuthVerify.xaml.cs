using Invisual.Jira.Api.Authorization;
using Invisual.Jira.Tasky.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Invisual.Jira.Tasky
{
	/// <summary>
	/// Interaction logic for OAuthVerify.xaml
	/// </summary>
	public partial class OAuthVerify : Window
	{
		private readonly JiraOAuth1Authorizer _jiraAuthorizer;
		private readonly string _requestToken;

		public OAuthVerify(string requestToken)
		{
			if (string.IsNullOrWhiteSpace(requestToken))
				throw new ArgumentException("requestToken must not be null, empty, or whitespace");

			_requestToken = requestToken;

			InitializeComponent();

			_jiraAuthorizer = new JiraOAuth1Authorizer(JiraAppSettings.Values);

			DataContext = this;
		}

		private string _verificationCode;
		public string VerificationCode
		{
			get { return _verificationCode; }
			set
			{
				_verificationCode = value;

				if (string.IsNullOrWhiteSpace(value))
					throw new ApplicationException("Verification Code is required.");
			}
		}

		private void AuthorizeButtonClick(object sender, RoutedEventArgs e)
		{
			VerificationCodeTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();



			//var accessToken = _jiraAuthorizer.Authorize(_requestToken, VerificationCode);

			//DialogResult = true;
		}
	}
}
