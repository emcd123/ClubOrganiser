using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest.Helpers
{
    /// <summary>
    /// Used for all cases of navigating from one page into another during tests.
    /// </summary>
    public static class Navigation
    {
        private static IApp app;
        /// <summary>
        /// Sets App gateway property
        /// </summary>
        public static IApp App
        {
            get { return app; }
            set { app = value; }
        }

        /// <summary>
        /// Access the on screen home button
        /// </summary>
        public static void NavigateHome()
        {
            if (app.Query(CommonStringStore.Home).Any())
                app.Tap(CommonStringStore.Home);
            else if (app.Query(CommonStringStore.HomeButton).Any())
            {
                app.Tap(CommonStringStore.HomeButton);
            }
        }

        /// <summary>
        /// Access the system back button.
        /// </summary>
        public static void NavigateBack()
        {
            app.Back();
        }

        /// <summary>
        /// Standard navigate to <paramref name="pageName"/> page.
        /// </summary>
        /// <param name="pageName"></param>
        public static void NavigateToPage(string pageName)
        {
            if (app.Query(pageName).Any())
            {
                app.Tap(pageName);
                app.WaitForElement(x => x.Marked(pageName));
            }
            else
            {
                Console.WriteLine("Page not found");
            }
        }

        /// <summary>
        /// Navigate to a page using the automationId(i.e <paramref name="triggerTapped"/>) in the xaml of the current page.
        /// <para> Also checks if we have reached the <paramref name="destinationPage"/>.</para>
        /// </summary>
        /// <param name="triggerTapped"></param>
        /// <param name="destinationPage"></param>
        public static void NavigateToPageFromAutomationId(string triggerTapped, string destinationPage)
        {
            if (app.Query(triggerTapped).Any())
            {
                app.Tap(triggerTapped);
                app.WaitForElement(x => x.Marked(destinationPage));
            }
            else
            {
                Console.WriteLine("Automated trigger not found");
            }
        }

        /// <summary>
        /// Used to navigate to a page through a passed Query.
        /// </summary>
        /// <param name="query"></param>
        public static void NavigateToQuery(Query query)
        {
            app.Tap(query);
        }

        /// <summary>
        /// Used to navigate to a page through a passed Query in Calabash syntax.
        /// <para><c>string</c> <paramref name="query"/> is the xamarin.uitest query passed in.</para>
        /// <para><paramref name="MarkedEle"/> is then part of the app screen we want to access elements from</para>
        /// </summary>
        /// <param name="query"></param>
        /// <param name="MarkedEle"></param>
        public static void NavigateToRawQuery(string query, string MarkedEle)
        {
            var PreparedQuery = string.Format(query, MarkedEle);
            Console.WriteLine(PreparedQuery);
            app.Tap(q => q.Raw(PreparedQuery));
        }

        /// <summary>
        /// Navigate to a page being opened through an exposed method i.e <paramref name="methodString"/>
        /// <para><paramref name="methodString"/> differs depending on <paramref name="platform"/></para>
        /// </summary>
        /// <param name="methodString"></param>
        /// <param name="platform"></param>
        public static void NavigateToInvokedPage(string methodString, string platform)
        {
            if (platform == "iOS")
                app.Invoke(methodString, "value");
            else if (platform == "android")
                app.Invoke(methodString);

            System.Threading.Thread.Sleep(3000);
            //TODO: FInd way to check if correct page is opened without
            // making an exhaustive list of automation id's
        }

        /// <summary>
        ///  Used to navigate to a page from a on screen Tile or Button
        /// </summary>
        /// <param name="tileName"></param>
        public static void NavigateFromTile(string tileName)
        {
            app.WaitForElement(x => x.Marked(tileName));
            if (app.Query(tileName).Any())
                app.Tap(tileName);
            else
            {
                Console.WriteLine("Tile not found");
            }
        }

        /// <summary>
        /// Used to navigate to a page from a list through a passed text string <paramref name="str"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        public static void NavigateFromButtonInList(string str, int index)
        {
            app.Tap(x => x.Marked(str).Index(index));
        }

        /// <summary>
        /// Used to navigate to a page from a list through a passed Query in Calabash syntax.
        /// <para><c>string</c> <paramref name="query"/> is the xamarin.uitest query passed in.</para>
        /// <para><paramref name="MarkedEle"/> is then part of the app screen we want to access the elements of.</para>
        /// <para><paramref name="ListIndex"/> is the index of the <c>ListView</c> we want to access.</para>
        /// </summary>
        /// <param name="query"></param>
        /// <param name="MarkedEle"></param>
        /// <param name="ListIndex"></param>
        public static void NavigateToListRawQuery(string query, string MarkedEle, int ListIndex)
        {
            var PreparedQuery = string.Format(query, MarkedEle, ListIndex);
            Console.WriteLine(PreparedQuery);
            app.Tap(q => q.Raw(PreparedQuery));
        }

        /// <summary>
        /// Navigate to having the sidebar opened.
        /// </summary>
        public static void NavigateToSideBar()
        {
            OpenSidebar();
            if (!app.Query(x => x.Marked(AutomationIdStore.Hamburger)).Any())
            {
                Console.WriteLine("Sidebar could not be opened");
            }
        }

        /// <summary>
        /// Navigate to a page that can be accessed from the sidebar.
        /// </summary>
        /// <param name="pageName"></param>
        public static void NavigateToSideBarPage(string pageName)
        {
            OpenSidebar();
            if (app.Query(pageName).Any())
            {
                app.Tap(pageName);
                app.WaitForElement(x => x.Marked(pageName));
            }
            else
            {
                Console.WriteLine("Page not found on Sidebar");
            }
        }

        /// <summary>
        /// Opens the sidebar of the app
        /// </summary>
        public static void OpenSidebar()
        {
            app.WaitForElement(x => x.Marked("HomePageIdentifier")); // wait for home page to load
            System.Threading.Thread.Sleep(5000);
            app.Tap(x => x.Marked("hamburgerId"));
            Screenshot.TakeScreenShotPageOpen("Sidebar");
        }
    }
}
