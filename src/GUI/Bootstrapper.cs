﻿namespace GUI
{
	using GUI.Views;
	using System.Windows;
	using Prism.Modularity;
	using Microsoft.Practices.Unity;
	using Prism.Unity;

	class Bootstrapper : UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return this.Container.Resolve<Shell>();
		}

		protected override void InitializeShell()
		{
			Application.Current.MainWindow.Show();
		}

		protected override void ConfigureModuleCatalog()
		{
			var moduleCatalog = this.ModuleCatalog as ModuleCatalog;
			//moduleCatalog.AddModule(typeof(YOUR_MODULE));
		}
	}
}
