
using MVVM.Tools;
using WPF_Hundekennel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPF_Hundekennel.ViewModel
{
    class MainViewModel : ObservableObject 
    {
        public RelayCommand HomeViewCommand{ get; set; }
        public RelayCommand CollectionViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }

        public CollectionViewModel CollectionVM { get; set; }

        private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set { _currentView = value;
                OnPropertyChanged();
            }
		}
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CollectionVM = new CollectionViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o => 
            { 
                CurrentView = HomeVM;
            });
            CollectionViewCommand = new RelayCommand(o =>
            {
                CurrentView = CollectionVM;
            });
        }
    }
}
