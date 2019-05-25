using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ClubOrganiser.UITest
{
    public class Tests : AbstractSetup
    {

        public Tests(Platform platform) : base(platform)
        {
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            app.WaitForElement(c => c.Marked("Please Sign In!"));
            app.Screenshot("Welcome screen.");

            
        }
    }
}
