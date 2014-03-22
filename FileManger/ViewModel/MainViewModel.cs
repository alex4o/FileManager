using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
namespace FileManger.ViewModel
{
	class MainViewModel : BaseViewModel
	{
		ObservableCollection<String> files;

		public MainViewModel()
		{
			files = new ObservableCollection<string>();
			foreach(var file in Directory.GetFiles("D:\\Users\\root\\Desktop\\")){
				files.Add(file);
			}
			
		}

		public ObservableCollection<String> Files
		{
			get { 
				return files; 
			}
			set {
				files = value;
				NotifyPropertyChanged("Files");
			}
		}


	}
}
