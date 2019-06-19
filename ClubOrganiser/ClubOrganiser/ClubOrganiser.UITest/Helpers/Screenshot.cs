using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITest.Helpers;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest.Helpers
{
    /// <summary>
    /// Used to take screenshots during testing along with the appropriate message.
    /// <para>Wherever possible a non-custom message should be used to avoid ambiguity</para>
    /// </summary>
    public static class Screenshot
    {
        private static IApp app;
        private static bool enable_screenshots;

        /// <summary>
        /// Sets App gateway property
        /// </summary>
        public static IApp App
        {
            get { return app; }
            set { app = value; }
        }

        /// <summary>
        /// Called within <c>Init()</c> to enable or disable screenshots.
        /// <para>Should not be called elsewhere</para>
        /// </summary>
        /// <param name="val"></param>
        public static void EnableScreenshots(bool val)
        {
            enable_screenshots = val;
            Console.WriteLine(enable_screenshots);
        }

        /// <summary>
        /// Used take screenshot with a blank message attached
        /// </summary>
        public static void TakeScreenshot()
        {
            if (enable_screenshots)
                app.Screenshot("");
        }

        /// <summary>
        /// Used take screenshot with a custom message attached
        /// <para><c>string title</c> denotes the message.</para>
        /// </summary>
        /// <param name="title"></param>
        public static void TakeScreenshotCustomMessage(string title)
        {
            if (enable_screenshots)
                app.Screenshot(title);
        }

        /// <summary>
        /// Used to screenshot app when verifying that specific data is on screen.
        /// </summary>
        public static void TakeScreenshotVerifyData()
        {
            if (enable_screenshots)
                app.Screenshot("Session information verification");
        }

        /// <summary>
        /// Used to screenshot app with a specific page screen.
        /// <para><paramref name="pageName"/> should describe the on screen page.</para>
        /// </summary>
        /// <param name="pageName"></param>
        public static void TakeScreenShotPageOpen(string pageName)
        {
            if (enable_screenshots)
                app.Screenshot(pageName + " Page on screen");
        }

        /// <summary>
        /// Used to screenshot app when an exposed method has been used to force a specific page on screen.
        /// <para><paramref name="invokedPageName"/> should describe the on screen page.</para>
        /// </summary>
        /// <param name="invokedPageName"></param>
        public static void TakeScreenshotInvokedPage(string invokedPageName)
        {
            if (enable_screenshots)
                app.Screenshot("Invoked " + invokedPageName + " page on screen");
        }

        /// <summary>
        /// Used to screenshot app when app has transitioned to a detail page
        /// <para><paramref name="detailPageName"/>should describe the on screen page.</para>
        /// </summary>
        /// <param name="detailPageName"> should describe the on screen page</param>
        public static void TakeScreenshotDetailPage(string detailPageName)
        {
            if (enable_screenshots)
                app.Screenshot(detailPageName + " Detail page on screen");
        }

        /// <summary>
        /// Used to screenshot app when app has transitioned to a detail page
        /// <para><paramref name="listItemsType"/>should describe list items present on page.</para>
        /// </summary>
        /// <param name="listItemsType"></param>
        public static void TakeScreenshotListItems(string listItemsType)
        {
            if (enable_screenshots)
                app.Screenshot("Explore Location " + listItemsType);
        }

        /// <summary>
        /// Used to screenshot app when a popup menu is present
        /// </summary>
        public static void TakeScreenshotPopup()
        {
            if (enable_screenshots)
                app.Screenshot("PopUp Active on Screen");
        }
    }
}
