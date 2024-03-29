﻿using System;
using System.Collections.Generic;
using Xamarin.UITest;
using NUnit.Framework;
using System.Linq;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;

namespace ClubOrganiser.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public abstract class AbstractSetup
    {
        protected IApp app;
        protected Platform platform;
        protected bool OnAndroid;
        protected bool OniOS;

        public AbstractSetup(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            OnAndroid = app.GetType() == typeof(AndroidApp);
            OniOS = app.GetType() == typeof(iOSApp);


        }
    }
}
