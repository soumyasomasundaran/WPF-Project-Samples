using DietManager.Commands;
using System;
using System.Windows.Input;

namespace DietManager.MVVM.ViewModel
{
    class NumbericalInputViewModel:ViewModelBase
    {
		private string _inputText;
		public ICommand OKCommand { get; set; }
        public EventHandler<bool> CloseRequested;
		public string InputText
		{
			get { 
                return _inputText; 
            }
			set {
                _inputText = value;
                OnPropertyChanged(nameof(InputText));
                IsOKEnabled = double.TryParse(InputText, out _);
            }
		}

        public bool Success { get; private set; }

        public NumbericalInputViewModel()
        {
            OKCommand = new RelayCommand(OK, canExecute);
        }

        private void OK(object obj)
        {
            if (IsOKEnabled)
            {              
               
                CloseRequested?.Invoke(this, true);
            }
        }
        private bool _isOKEnabled;

        public bool IsOKEnabled
        {
            get { return _isOKEnabled; }
            set { _isOKEnabled = value;
                OnPropertyChanged(nameof(IsOKEnabled) );
            }
        }


        private bool canExecute(object arg)
        {
            return true;
        }
    }
}
