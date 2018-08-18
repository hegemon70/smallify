namespace GUI.Views
{
	using GUI.ViewModels;
	using System.Windows;

	/// <summary>
	/// Interaction logic for Shell.xaml
	/// </summary>
	public partial class Shell : Window
	{
		public Shell()
		{
			this.DataContext = new ShellViewModel();
			this.InitializeComponent();
		}
	}
}
