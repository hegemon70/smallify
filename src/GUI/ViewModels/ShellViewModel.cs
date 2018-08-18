namespace GUI.ViewModels
{
	using GUI.Interfaces;
	using Prism.Commands;
	using Prism.Mvvm;
	using System.Windows;
	using System.Windows.Input;

	public class ShellViewModel : BindableBase, IShellViewModel
	{
		private string _title;

		public ShellViewModel()
		{
			this._title = "Smallify";

			this.MinimiseWindowCommand = new DelegateCommand<object>(this.MinimiseWindowCommand_Execute);
			this.CloseWindowCommand = new DelegateCommand<object>(this.CloseWindowCommand_Execute);
		}

		public ICommand MinimiseWindowCommand { get; }

		public ICommand CloseWindowCommand { get; }

		public string Title
		{
			get => this._title;
			private set => this.SetProperty(ref this._title, value);
		}

		private void MinimiseWindowCommand_Execute(object param)
		{
			if (param is Window window)
			{
				window.WindowState = WindowState.Minimized;
			}
		}

		private void CloseWindowCommand_Execute(object param)
		{
			if (param is Window window)
			{
				window.Close();
			}
		}
	}
}
