using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITest;
using UITest.Helpers;
using Xamarin.UITest;

namespace ClubOrganiser.UITest.Tests
{
    public class HomePageTest : AbstractSetup
    {
        public HomePageTest(Platform platform) : base(platform) {
        }

        [Test]
        public void CheckAllTilesPresent()
        {
            app.WaitForElement(AutomationIdStore.LogInButton);
            Navigation.NavigateToPageFromAutomationId(AutomationIdStore.LogInButton, AutomationIdStore.HomePage);
            
        }
    }
}
