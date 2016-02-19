using Invisual.Jira.Api;
using Invisual.Jira.Api.Authorization;
using Invisual.Jira.Api.Entities.Issues;
using Invisual.Jira.Api.Requests;
using Invisual.Jira.Tasky.Configuration;
using Invisual.Jira.Tasky.Properties;
using Invisual.Jira.Tasky.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Invisual.Jira.Tasky
{
	/// <summary>
	/// Interaction logic for MenuWindow.xaml
	/// </summary>
	public partial class MenuWindow : UserControl
	{
		private IEnumerable<JiraProjectViewModel> _projects;

		public MenuWindow()
		{
			InitializeComponent();

			if (string.IsNullOrWhiteSpace(Settings.Default.JiraAccessToken))
				RequestAuthorization();
			else
				RefreshProjectList();
		}

		private JiraApiClient _jira;
		private JiraApiClient Jira
		{
			get
			{
				if (_jira != null)
					return _jira;

				if (string.IsNullOrWhiteSpace(Settings.Default.JiraAccessToken))
					throw new Exception(); // TODO: Proper custom exception

				_jira = new JiraApiClient(JiraAppSettings.Values.BaseUri, Settings.Default.JiraAccessToken);

				return _jira;
			}
		}

		private void RequestAuthorization()
		{
			var authorizer = new JiraOAuth1Authorizer(JiraAppSettings.Values);

			var authResponse = authorizer.GetAuthorizationUrl();

			// Open auth url
			// TODO: open url within WPF window
			var psi = new ProcessStartInfo("chrome.exe");
			psi.Arguments = authResponse.AuthorizationUri.AbsoluteUri;
			Process.Start(psi);

			// Open dialog for the user to enter their verification code.
			new OAuthVerify(authResponse.RequestToken).ShowDialog();
		}

		private void RefreshProjectList()
		{
			ErrorLabel.Visibility = Visibility.Visible;

			// TODO: async
			_projects = Jira.Search(new SearchRequest { Jql = "assignee = currentUser()" }).Issues.Select(i =>
			{
				var project = _projects.FirstOrDefault(p => p.Project.Id == i.Fields.Project.Id);

				if (project != null)
				{
					project.UserIssues.Add(i);
					return null;
				}

				return new JiraProjectViewModel
				{
					Project = i.Fields.Project,
					UserIssues = new List<Issue> { i }
				};
			})
			.Where(p => p != null);
		}
	}
}
