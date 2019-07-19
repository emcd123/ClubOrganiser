using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest
{
    /// <summary>
    /// Contains all common strings in use in the app.
    /// /// <para>
    /// Should be used to interact with the UI through Marked text.
    /// </para>
    /// </summary>
    public static class CommonStringStore
    {
        public static string Home = "Home";
        public static string HomeButton = "Home";
        public static string YourProfile = "Your Profile";
        public static string NextSession = "Your Next Session";
        public static string Competitions = "Your Competitions";
        public static string Programs = "Your Programs";
        public static string News = "Club News";
        public static string Contact = "Contact Coach";
    }

    /// <summary>
    /// Directory of all Automation Id's in project.
    /// <para>
    /// Should be used to interact with the UI through placed automation id's
    /// </para>
    /// </summary>
    public static class AutomationIdStore
    {
        public static string Hamburger = "HamburgerId";
        public static string Home = "HomeId";
        public static string LogInButton = "LogInButtonId";
        public static string HomePage = "HomePageId";
    }

    #region Not Implemented yet
    /// <summary>
    /// Contains all valid appcenter-cli test suites categories for this project.
    /// <para>
    /// Should be used to define which tests will be sent to the cloud.
    /// </para>
    /// </summary>
    public static class TestCategoryStore
    {
    }

    /// <summary>
    /// Allows access to specific methods from within the project.
    /// <para>
    /// Should be used to define which tests will be sent to the cloud.
    /// </para>
    /// </summary>
    public static class InvokeStrings
    {
    }

    /// <summary>
    /// Contains all the data for the main query strings for app.Query()
    /// </summary>
    public static class QueryStrings
    {
    }
    #endregion
}
