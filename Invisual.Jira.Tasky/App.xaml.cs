using Invisual.SystemTray.Interop;
using System.Windows;

namespace Invisual.Jira.Tasky
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private TaskbarIcon _notifyIcon;

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			//create the notifyicon (it's a resource declared in NotifyIconResources.xaml
			_notifyIcon = (TaskbarIcon)FindResource("JiraTrayIcon");
		}

		protected override void OnExit(ExitEventArgs e)
		{
			_notifyIcon.Dispose(); //the icon would clean up automatically, but this is cleaner
			base.OnExit(e);
		}
	}
}
