
using LearningProject.Core;
using LearningProject.Services;

namespace LearningProject.MVVM.ViewModel
{
    class MainViewModel: ViewModelBase
    {
        public MainViewModel(INavigationService _navService)
        {
            _navService = NavService;
            NavigateHomeCommand = new RelayCommand(execute: o => { _navService.NavigateTo<HomeViewModel>(); }, canExecute: o => true) ;
            NavigateSettingsCommand = new RelayCommand(execute: o => { _navService.NavigateTo<SettingsViewModel>(); }, canExecute: o => true) ;
        }

        private INavigationService _navService;

        public INavigationService NavService
        {
            get { return _navService; }
            set { 
                _navService = value;
                OnPropertyChanged(nameof(NavService));
            
            }
        }

        public RelayCommand NavigateHomeCommand { get; set; }
        public RelayCommand NavigateSettingsCommand { get; set; }
    }
}
