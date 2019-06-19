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
    public class QueryLib
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
        /// App Query to wait for an element to appear on screen.
        /// </summary>
        public static void WaitForMarkedElement(string ele)
        {
            app.WaitForElement(x => x.Marked(ele));
        }

        /// <summary>
        /// Used to check if a specific Marked element is on-screen.
        /// </summary>
        /// <param name="ele"></param>
        /// <returns></returns>
        public static bool DoesMarkedElementExist(string ele)
        {
            return app.Query(x => x.Marked(ele)).Any();
        }

        /// <summary>
        /// Return the number of marked elements on screen.
        /// <para><paramref name="que"/> is a AppResult query</para>
        /// </summary>
        /// <param name="que"></param>
        /// <returns></returns>
        public static int MarkedElementCount(AppResult[] que)
        {
            return que.Length;
        }

        /// <summary>
        /// Return the number of marked elements on screen.
        /// <para><paramref name="ele"/> is a string used to query a marked element.</para>
        /// </summary>
        /// <param name="ele"></param>
        /// <returns></returns>
        public static int MarkedElementCount(string ele)
        {
            return app.Query(x => x.Marked(ele)).Length;
        }
    }
}
