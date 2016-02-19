using Invisual.Jira.Api.Entities.Projects;
using Invisual.Jira.Api.Entities.Users;
using System;
using System.Collections.Generic;

namespace Invisual.Jira.Api.Entities.Issues
{
	public class Fields
	{
		public IssueType IssueType { get; set; }
		public int TimeSpent { get; set; }
		public Project Project { get; set; }
		public List<object> FixVersions { get; set; } // TODO: Type TBC
		public int Aggregatetimespent { get; set; }
		public Resolution Resolution { get; set; }
		public DateTime? ResolutionDate { get; set; }
		public int WorkRatio { get; set; }
		public DateTime? LastViewed { get; set; }
		public Watches Watches { get; set; }
		public DateTime Created { get; set; }
		public Priority Priority { get; set; }
		public List<object> Labels { get; set; }  // TODO: Type TBC
		public int TimeEstimate { get; set; }
		public int AggregateTimeOriginalEstimate { get; set; }
		public List<object> Versions { get; set; }  // TODO: Type TBC
		public List<object> Issuelinks { get; set; }  // TODO: Type TBC
		public User Assignee { get; set; }
		public DateTime? Updated { get; set; }
		public Status Status { get; set; }
		public List<object> Components { get; set; }  // TODO: Type TBC
		public int TimeOriginalEstimate { get; set; }
		public string Description { get; set; }
		public int AggregateTimeEstimate { get; set; }
		public string Summary { get; set; }
		public User Creator { get; set; }
		public List<object> SubTasks { get; set; } // TODO: Type TBC
		public User Reporter { get; set; }	
		public Progress AggregateProgress { get; set; }	
		public string Environment { get; set; }
		public DateTime? DueDate { get; set; }
		public Progress Progress { get; set; }
		public Votes Votes { get; set; }

		public string Customfield_10000 { get; set; }
		public string Customfield_10001 { get; set; }
		public object Customfield_10002 { get; set; }
		public object Customfield_10003 { get; set; }

		public string Customfield_10006 { get; set; }
		public object Customfield_10007 { get; set; }
		public object Customfield_10008 { get; set; }

		public object Customfield_10012 { get; set; }
		public object Customfield_10013 { get; set; }
		public object Customfield_10014 { get; set; }
		public object Customfield_10015 { get; set; }
		public object Customfield_10016 { get; set; }
		public object Customfield_10017 { get; set; }
		public object Customfield_10018 { get; set; }
		public object Customfield_10019 { get; set; }

		public object Customfield_10020 { get; set; }
		public string Customfield_10021 { get; set; }

		public object Customfield_10024 { get; set; }

		public string Customfield_10100 { get; set; }

		public object Customfield_10200 { get; set; }

		public object Customfield_10300 { get; set; }

		public object Customfield_10401 { get; set; }

		public object Customfield_10500 { get; set; }
		public object Customfield_10501 { get; set; }

		public object Customfield_10700 { get; set; }

		public object Customfield_10800 { get; set; }
	}
}
