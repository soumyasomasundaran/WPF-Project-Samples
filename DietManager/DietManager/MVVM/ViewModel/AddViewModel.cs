using DietManager.Commands;
using DietManager.MVVM.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace DietManager.MVVM.ViewModel
{
    class AddViewModel : ViewModelBase
    {
        private ObservableCollection<double> _foodList = new ObservableCollection<double>();

        public ObservableCollection<double> FoodList
        {
            get { return _foodList; }
            set { 
                _foodList = value;
                OnPropertyChanged(nameof(FoodList));
            }
        }
        
        public bool Success { get; set; }
        public ICommand AddFoodCommand { get; set; }
        public AddViewModel()
        {
            AddFoodCommand = new RelayCommand(openPopUp,canExecute);
        }

        private void openPopUp(object obj)
        {
            NumbericalInputViewModel numVM = new NumbericalInputViewModel();
            NumericInput numWin = new NumericInput();
            numWin.DataContext = numVM;
            numVM.CloseRequested += (sender, success) =>
            {
                if (success)
                {
                    FoodList.Add((double.Parse(numVM.InputText)));
                    // Handle the numeric input, for example, show it in a message box
                    MessageBox.Show($"Entered numeric value: {numVM.InputText}");
                }

                // Close the numeric input view
                numWin.Close();
            };
            numWin.ShowDialog();

        }

        private bool canExecute(object arg)
        {
            return true;
        }
    }
}
