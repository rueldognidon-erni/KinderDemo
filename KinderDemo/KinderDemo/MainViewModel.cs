using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KinderDemo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            MainText = "Kinder Demo";
        }

        private string _mainText;
        public string MainText
        {
            get => _mainText;
            set
            {
                _mainText = value;
                OnPropertyChanged();
            }
        }


        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (string.IsNullOrEmpty(propertyName)) return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
