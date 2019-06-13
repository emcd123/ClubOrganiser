using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ClubOrganiser.UITest
{
    public class AppInitializer
    {
        const string apkfile = "../../../ClubOrganiser.Android/bin/UiTest/com.companyname.ClubOrganiser-signed.apk";
        //        const string appfile = "../../../XamarinEvolve.iOS/bin/iPhoneSimulator/Debug/XamarinEvolveiOS.app";

        private static IApp app;

        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppInitializer.App' not set. Call 'AppInitializer.StartApp(platform)' before trying to access it.");
                return app;
            }
        }

        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                app = ConfigureApp.Android.ApkFile(apkfile)
                    .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);
            }
            else
            {
                app = ConfigureApp.iOS.InstalledApp("com.sample.cluborganiser")
                    .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);
            }

            return app;
        }
    }

}