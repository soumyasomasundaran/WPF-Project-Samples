using LearningProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Services
{
    class NavigationService :ViewModelBase, INavigationService
    {
        private readonly Func<Type, ViewModelBase> _viewModelFactory;
        public NavigationService(Func<Type,ViewModelBase> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }
        private ViewModelBase _currentView;

        public ViewModelBase CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            
            }
        }

        public void NavigateTo<T>() where T : ViewModelBase
        {
            ViewModelBase viewModel = _viewModelFactory.Invoke(typeof(T));
            CurrentView = viewModel;
        }
    }
}
