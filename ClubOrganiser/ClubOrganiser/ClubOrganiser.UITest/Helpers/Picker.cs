using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITest.Interfaces;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest.Helpers
{
    /// <summary>
    /// Used to interact with any picker present in the app.
    /// <para>Currently only works on Android</para>
    /// </summary>
    public class Picker : IPickable
    {
        private static IApp app;
        private bool _android;
        private bool _iOS;

        /// <summary>
        /// Instantiate a picker object for standardised interaction throughout app.
        /// <para> Functionality changes dependent on values of the <paramref name="Android"/> and <paramref name="iOS"/> parameters.</para>
        /// <para>Parameter must be supplied, no default values</para>
        /// </summary>
        /// <param name="Android">Tells the picker that Android is the current platform being tested</param>
        /// <param name="iOS">Tells the picker that iOS is the current platform being tested</param>
        public Picker(bool Android, bool iOS)
        {
            _android = Android;
            _iOS = iOS;
        }

        /// <summary>
        /// Sets AndroidPicker property
        /// </summary>
        public bool AndroidPicker
        {
            get { return _android; }
            set { _android = value; }
        }

        /// <summary>
        /// Sets iOSPicker property
        /// </summary>
        public bool iOSPicker
        {
            get { return _iOS; }
            set { _iOS = value; }
        }

        /// <summary>
        /// Sets App gateway property
        /// </summary>
        public static IApp App
        {
            get { return app; }
            set { app = value; }
        }

        /// <summary>
        /// Used to open any on screen picker
        /// <para>Implementation differs across platform</para>
        /// </summary>
        public void OpenPicker()
        {
            app.WaitForElement(x => x.Marked(AutomationIdStore.DurationPickerId));
            app.Tap(x => x.Marked(AutomationIdStore.DurationPickerId).Child(0));
        }

        /// <summary>
        /// Used to select an element any open on screen picker
        /// <para>Implementation differs across platform</para>
        /// </summary>
        public void SelectEleFromPicker(string ele)
        {
            app.WaitForElement(x => x.Marked(ele));
            if (app.Query(ele).Any())
                app.Tap(ele);
            else
            {
                Console.WriteLine("Element not found");
            }
        }

        /// <summary>
        /// Used to scroll through any open on screen picker
        /// <para>Implementation differs across platform</para>
        /// </summary>
        private void ScrollPicker()
        {
            throw new NotImplementedException();
        }
    }
}
