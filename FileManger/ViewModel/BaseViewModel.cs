using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

public abstract class BaseViewModel : INotifyPropertyChanged
{
	#region PropertyChanged
	public event PropertyChangedEventHandler PropertyChanged;
	public void NotifyPropertyChanged(string str)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(str));
		}
	}
	#endregion

}
