namespace GUI.Interfaces
{
	using System.Windows.Input;

	public interface IShellViewModel
	{
		ICommand MinimiseWindowCommand { get; }

		ICommand CloseWindowCommand { get; }

		string Title { get; }
	}
}
