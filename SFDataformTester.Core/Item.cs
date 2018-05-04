using System;
using MvvmCross.ViewModels;

namespace SFDataformTester.Core
{
    public class Item : MvxNotifyPropertyChanged
    {
        private string _name = "Test";
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _value;
        public string Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}
