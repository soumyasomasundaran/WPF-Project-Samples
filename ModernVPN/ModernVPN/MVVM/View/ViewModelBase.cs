using System.ComponentModel;


namespace ModernVPN.MVVM.View
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged()
    }
}
