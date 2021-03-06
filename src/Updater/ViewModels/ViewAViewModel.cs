﻿using Prism.Mvvm;

namespace Updater.ViewModels
{
	public class ViewAViewModel : BindableBase
	{
		private string _message;

		public ViewAViewModel()
		{
			this.Message = "View A from your Prism Module";
		}

		public string Message
		{
			get
			{
				return this._message;
			}

			set
			{
				this.SetProperty(ref this._message, value);
			}
		}
	}
}