using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace SFDataformTester
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation]
    public partial class SFDataformTesterPage : MvxContentPage<SFDataformTesterViewModel>
    {
        public SFDataformTesterPage()
        {
            InitializeComponent();
        }
    }
}
