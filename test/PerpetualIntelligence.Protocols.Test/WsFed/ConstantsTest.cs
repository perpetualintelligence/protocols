﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.WsFed
{
    [TestClass]
    public class ConstantsTest
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Constants), 1);

            Assert.AreEqual("wsfed", Constants.WebServicesFederation);
        }
    }
}
