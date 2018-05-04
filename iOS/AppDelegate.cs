using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using SFDataformTester.Core;
using UIKit;

namespace SFDataformTester.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<MvxApp, App>, MvxApp, App>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //global::Xamarin.Forms.Forms.Init();

            Syncfusion.XForms.iOS.DataForm.SfDataFormRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
