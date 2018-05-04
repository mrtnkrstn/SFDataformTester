using MvvmCross.Commands;
using MvvmCross.ViewModels;
using SFDataformTester.Core;

namespace SFDataformTester
{
    public class SFDataformTesterViewModel : MvxViewModel
    {
        public SFDataformTesterViewModel()
        {
            Item = new Item();

            PopulateCommand = new MvxCommand(Populate);
        }

        private Item _item;
        public Item Item
        {
            get => _item;
            set => SetProperty(ref _item, value);
        }

        public IMvxCommand PopulateCommand { get; }

        private void Populate()
        {
            Item.Value = "Value";
        }
    }
}
