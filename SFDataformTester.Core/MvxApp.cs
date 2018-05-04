using MvvmCross.ViewModels;

namespace SFDataformTester.Core
{
    public class MvxApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<SFDataformTesterViewModel>();
        }
    }
}
