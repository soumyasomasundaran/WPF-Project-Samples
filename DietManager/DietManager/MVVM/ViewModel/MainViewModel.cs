using DietManager.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DietManager.MVVM.ViewModel
{
    class MainViewModel:ViewModelBase
    {
        public MainViewModel()
        {
            updateViewCommand = new RelayCommand(updateView,canExecute);
        }


        public ICommand updateViewCommand { get; set; }

        private ViewModelBase _currentViewModel = new HomeViewModel();
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { 
                _currentViewModel = value; 
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        private bool canExecute(object arg)
        {
            return true;
        }

        private void updateView(object obj)
        {
            if (obj.ToString() == "Home")
            {
                CurrentViewModel = new HomeViewModel();
            }
            else if (obj.ToString() == "Add")
            {
                CurrentViewModel = new AddViewModel();

            }
            else if (obj.ToString() == "Meal")
            {
                CurrentViewModel = new MealPlanViewModel();

            }
        }
    }
}
