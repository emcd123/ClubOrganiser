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

namespace UITest
{
    /// <summary>
    /// Initialisation methods for uitest helper classes
    /// </summary>
    public static class InitialiseHelperParams
    {
        /// <summary>
        /// Initialise the necessary variables for using the full project functionality.
        /// <para> Screenshots are enabled by deafult through <paramref name="flag"/>.</para>
        /// </summary>
        /// <param name="app">Provides way of interacting with app through tests</param>
        /// <param name="flag">Used to enable or disable settings</param>
        /// <example><c> Init(app, false)</c> will initialise app along with disabling screenshots</example>
        public static void Init(IApp app, bool flag = true)
        {
            Navigation.App = app;
            QueryLib.App = app;
            Screenshot.App = app;
            Picker.App = app;
            Screenshot.EnableScreenshots(flag);
        }
    }
}
