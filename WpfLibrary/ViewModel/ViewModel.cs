using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WeatherWPF
{
    class SimpleCommand : ICommand
    {
        Action execute;
        public SimpleCommand(Action execute)
        {
            this.execute = execute;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
            => true;
        public void Execute(object parameter)
            => execute();
    }

    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        int count;
        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }
        }
        public ICommand Increment { get; }
        public ICommand Decrement { get; }

        public List<WeatherDataView> WeatherDataList { get; set; }

        public ViewModel()
        {
            Count = 0;
            Increment = new SimpleCommand(() => Count++);
            Decrement = new SimpleCommand(() => Count--);

            this.WeatherDataList = new List<WeatherDataView>();
            WeatherDataList.Add(new WeatherDataView());

        }
    }
}