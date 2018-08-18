namespace GUI.DummyData
{
	using GUI.Interfaces;
	using System;
	using System.Windows.Input;

	public class DummyShellViewModel : IShellViewModel
	{
		public ICommand MinimiseWindowCommand => throw new NotImplementedException();

		public ICommand CloseWindowCommand => throw new NotImplementedException();

		public string Title => "Smallify";
	}
}
